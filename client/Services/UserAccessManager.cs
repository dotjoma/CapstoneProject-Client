using client.Controllers;
using client.Services.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Services
{
    public class UserAccessManager
    {
        private readonly AuthController _authController;
        private readonly ToolStripMenuItem[] _adminItems;
        private readonly ToolStripMenuItem[] _staffItems;

        public UserAccessManager(AuthController authController,
                                 ToolStripMenuItem? file = null,
                                 ToolStripMenuItem? inventory = null,
                                 ToolStripMenuItem? reservation = null,
                                 ToolStripMenuItem? administration = null,
                                 ToolStripMenuItem? reports = null,
                                 ToolStripMenuItem? refresh = null,
                                 ToolStripMenuItem? help = null)
        {
            _authController = authController ?? throw new ArgumentNullException(nameof(authController));

            _adminItems = new[] { file, inventory, reservation, administration, reports, refresh, help }
                          .OfType<ToolStripMenuItem>()
                          .ToArray();

            _staffItems = new[] { file, reservation, refresh, help }
                          .OfType<ToolStripMenuItem>()
                          .ToArray();
        }

        public void ProcessUserAccess()
        {
            if (!CurrentUser.IsLoggedIn)
            {
                MessageBox.Show("Please log in to continue.", "Authentication Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                _authController.RedirectToLogin();
                return;
            }

            ApplyUserAccess();
        }

        private void ApplyUserAccess()
        {
            bool isAdmin = CurrentUser.IsAdmin;

            foreach (var item in _adminItems)
            {
                item.Visible = isAdmin;
            }

            foreach (var item in _staffItems)
            {
                item.Visible = true; 
            }
        }
    }
}
