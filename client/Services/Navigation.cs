using client.Services.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Services
{
    public class Navigation
    {
        private static Navigation? _instance;
        public static Navigation Instance
        {
            get
            {
                _instance ??= new Navigation();
                return _instance;
            }
        }

        private Navigation() { }

        public void RedirectTo<T>() where T : Form, new()
        {
            Form? currentForm = Application.OpenForms.Cast<Form>().FirstOrDefault(f => f.Focused);

            foreach (Form form in Application.OpenForms)
            {
                form.Hide();
            }

            T formToShow = new T();
            formToShow.Show();

            formToShow.FormClosed += (s, args) =>
            {
                if (CurrentUser.IsLoggedIn)
                {
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form != formToShow)
                        {
                            form.Show();
                        }
                    }
                }
            };
        }
    }
}
