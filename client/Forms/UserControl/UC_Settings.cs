using client.Controllers;
using client.Helpers;
using client.Services.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.Forms.UserControll
{
    public partial class UC_Settings : UserControl
    {
        private readonly AuthController _authController;
        public UC_Settings()
        {
            InitializeComponent();
            _authController = new AuthController();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (CurrentUser.IsLoggedIn)
            {
                _authController.Logout();
            }
        }
    }
}
