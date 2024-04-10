using Mini_KTK.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Mini_KTK.View
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
            ApplicationDbContext.Connect("10.14.206.28", "5432", "user9", "&6hM#c3h", "CollegeNews");
        }

        private void onSingIn(object sender, RoutedEventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Password.Trim();
            if (username.Length < 1 || password.Length < 1)
            {
                MessageBox.Show("Необходимо ввести логин и пароль");
                return;
            }

            var user = DbCommandSender.SignIn(username, password);
            if (user == null)
            {
                MessageBox.Show("Неверный логин или пароль");
                return;
            }
        }
    }
}
