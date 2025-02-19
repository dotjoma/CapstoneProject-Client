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

        // Check if the user is logged in.
        public static bool IsLoggedIn => Current != null;

        // Check if the user is admin.
        public static bool IsAdmin => _currentUser?.Role?.ToLower() == "admin";

        // Get current user session.
        public static UserSession? Current => _currentUser;

        // Set current user.
        public static void SetCurrentUser(UserSession user)
        {
            _currentUser = user;
        }

        // Clear user session on logout.
        public static void Clear()
        {
            _currentUser = null;
        }
    }
}
