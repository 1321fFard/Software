using SoftwareV2._1.ViewSoftware.RegisterWindow;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SoftwareV2._1
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerAccount = new();
            this.Close();
            registerAccount.Show();
        }

        private void login_to_Account_Click(object sender, RoutedEventArgs e)
        {
            if (login.Text.Length > 0)
            {
                if (password.Password.Length > 0)
                {
                    MessageBox.Show("Успешный вход");
                }
                else MessageBox.Show("Введите пароль");
            }
            else MessageBox.Show("Введите логин");
        }
    }
}
