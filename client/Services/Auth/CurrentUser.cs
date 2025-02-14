using client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Services.Auth
{
    public class CurrentUser
    {
        private static UserSession? _currentUser;

        public static UserSession? Session
        {
            get => _currentUser;
            private set => _currentUser = value;
        }

        public static void SetCurrentUser(int userId, string username, string role)
        {
            Session = new UserSession
            {
                UserId = userId,
                Username = username,
                Role = role,
                LoginTime = DateTime.Now
            };
        }

        public static void Clear()
        {
            Session = null;
        }

        public static bool IsAuthenticated => Session != null;

        public static bool HasRole(string role)
        {
            return IsAuthenticated && Session!.Role.Equals(role, StringComparison.OrdinalIgnoreCase);
        }
    }
}
