using client.Forms;
using client.Models;
using client.Network;
using client.Services.Auth;
using client.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using client.Models.Audit;
using System.Net.Sockets;
using System.Net;

namespace client.Controllers
{
    public class AuthController
    {
        AuditService _auditService = new AuditService();

        public void RedirectToLogin()
        {
            Navigation.Instance.RedirectTo<Login>();
        }

        public void Logout()
        {
            try
            {
                if (MessageBox.Show("Confirm your logout", "Logout",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    _auditService.Log(new AuditRecord
                    {
                        UserId = CurrentUser.Current!.UserId,
                        Username = CurrentUser.Current.Username,
                        Action = AuditActionType.Logout,
                        EntityType = AuditEntityType.User,
                        EntityId = CurrentUser.Current.UserId.ToString(),
                        Description = "User initiated logout",
                        IPAddress = GetCurrentIP()
                    });

                    CurrentUser.Clear();
                    Navigation.Instance.RedirectTo<Login>();
                }
                else
                {
                    _auditService.Log(new AuditRecord
                    {
                        UserId = CurrentUser.Current!.UserId,
                        Username = CurrentUser.Current.Username,
                        Action = AuditActionType.SystemEvent,
                        EntityType = AuditEntityType.User,
                        EntityId = CurrentUser.Current.UserId.ToString(),
                        Description = "User cancelled logout attempt",
                        IPAddress = GetCurrentIP()
                    });
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("emergency.log", $"{DateTime.UtcNow} - Logout failed: {ex}\n");
                CurrentUser.Clear();
                Navigation.Instance.RedirectTo<Login>();
            }
        }

        public async Task<bool> Login(string username, string password)
        {
            // Create audit record for login attempt
            var auditRecord = new AuditRecord
            {
                Username = username,
                Action = AuditActionType.Login,
                EntityType = AuditEntityType.User,
                EntityId = "NotAuthenticated",
                Description = "Login attempt initiated"
            };

            if (!ValidateLogin(username, password))
            {
                auditRecord.Action = AuditActionType.LoginFailure;
                auditRecord.Description = "Invalid credentials format";
                _auditService.Log(auditRecord);
                return false;
            }

            var loginPacket = new Packet
            {
                Type = PacketType.Login,
                Data = new Dictionary<string, string>
        {
            { "username", username },
            { "password", password }
        }
            };

            try
            {
                var response = await Task.Run(() => Client.Instance.SendToServerAndWaitResponse(loginPacket));

                if (response == null)
                {
                    auditRecord.Action = AuditActionType.LoginFailure;
                    auditRecord.Description = "No server response";
                    _auditService.Log(auditRecord);

                    MessageBox.Show("No response received from server", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (response.Data != null && response.Data.ContainsKey("success"))
                {
                    if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                    {
                        // Successful login
                        auditRecord.Action = AuditActionType.Login;
                        auditRecord.Description = "Login successful";
                        auditRecord.NewValue = "Authenticated";
                        auditRecord.UserId = CurrentUser.Current!.UserId;
                        auditRecord.EntityId = auditRecord.UserId.ToString();
                        _auditService.Log(auditRecord);

                        return true;
                    }
                    else
                    {
                        // Failed login
                        string errorMessage = response.Data.ContainsKey("message")
                            ? response.Data["message"]
                            : "Unknown error occurred";

                        auditRecord.Action = AuditActionType.LoginFailure;
                        auditRecord.Description = $"Login failed: {errorMessage}";
                        auditRecord.NewValue = errorMessage;
                        _auditService.Log(auditRecord);

                        MessageBox.Show($"Login failed: {errorMessage}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    auditRecord.Action = AuditActionType.LoginFailure;
                    auditRecord.Description = "Invalid server response format";
                    _auditService.Log(auditRecord);

                    MessageBox.Show("Invalid response format from server", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                auditRecord.Action = AuditActionType.LoginFailure;
                auditRecord.Description = $"Login exception: {ex.Message}";
                auditRecord.NewValue = ex.ToString();
                _auditService.Log(auditRecord);

                MessageBox.Show($"Login error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<bool> Register(string username, string password, string confirmPassword)
        {
            // Validating the fields.
            if (!ValidateRegistration(username, password, confirmPassword)) return false;

            // Registration packet to send to the server.
            var registerPacket = new Packet
            {
                Type = PacketType.Register,
                Data = new Dictionary<string, string>
                {
                    { "username", username },
                    { "password", password }
                }
            };

            // Send packet to the server and wait for a response
            var response = await Task.Run(() => Client.Instance.SendToServerAndWaitResponse(registerPacket));

            if (response == null)
            {
                MessageBox.Show("No response received from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Handle server response
            if (response.Data != null && response.Data.ContainsKey("success"))
            {
                if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Registration successful! Please login.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;
                }
                else
                {
                    string errorMessage = "Registration failed: ";

                    if (response.Data.ContainsKey("message"))
                    {
                        errorMessage += response.Data["message"];
                    }
                    else
                    {
                        errorMessage += "Unknown error occurred";
                    }

                    MessageBox.Show(errorMessage, "Registration Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }
            else
            {
                MessageBox.Show("Invalid response format from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password are required", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Username validation
            if (username.Length < 4)
            {
                MessageBox.Show("Username must be at least 4 characters long", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!username.All(c => char.IsLetterOrDigit(c) || c == '_'))
            {
                MessageBox.Show("Username can only contain letters, numbers, and underscores",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Password validation
            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool ValidateRegistration(string username, string password, string confirmpass)
        {
            // Username validation
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username cannot be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (username.Length < 4)
            {
                MessageBox.Show("Username must be at least 4 characters long", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!username.All(c => char.IsLetterOrDigit(c) || c == '_'))
            {
                MessageBox.Show("Username can only contain letters, numbers, and underscores", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Password validation
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password cannot be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check for common passwords
            var commonPasswords = new HashSet<string>
            {
                "password123", "12345678", "qwerty123", "admin123"
            };

            if (commonPasswords.Contains(password.ToLower()))
            {
                MessageBox.Show("This password is too common. Please choose a stronger password.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsDigit) || !password.Any(c => !char.IsLetterOrDigit(c)))
            {
                MessageBox.Show("Password must contain at least:\n" +
                              "- One uppercase letter\n" +
                              "- One lowercase letter\n" +
                              "- One number\n" +
                              "- One special character",
                              "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Confirm password validation
            if (string.IsNullOrWhiteSpace(confirmpass))
            {
                MessageBox.Show("Please confirm your password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (password != confirmpass)
            {
                MessageBox.Show("Passwords do not match", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private string GetCurrentIP()
        {
            try
            {
                return Dns.GetHostEntry(Dns.GetHostName())
                    .AddressList
                    .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork)?
                    .ToString() ?? "Unknown";
            }
            catch
            {
                return "Unknown";
            }
        }
    }
}
