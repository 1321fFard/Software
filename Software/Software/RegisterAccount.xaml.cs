﻿using System;
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

namespace Software
{
    /// <summary>
    /// Логика взаимодействия для RegisterAccount.xaml
    /// </summary>
    public partial class RegisterAccount : Window
    {
        public RegisterAccount()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            if (NewLogin.Text.Length > 0)
            {
                if (NewPassword.Password.Length > 0)
                {
                    if(RepeatPassword.Password.Length > 0)
                    {
                        if (NewPassword.Password == RepeatPassword.Password)
                        {
                            MessageBox.Show("Успешный вход");
                        }
                        else MessageBox.Show("Пароли не совпадают");
                    }
                    else MessageBox.Show("Вы забыли ввести повторный пароль");
                }
                else MessageBox.Show("Вы забыли придумать пароль");
            }
            else MessageBox.Show("Вы забыли придумать логин");
        }

        private void Login_to_Account_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new();
            this.Close();
            mainWindow.Show();
        }
    }
}
