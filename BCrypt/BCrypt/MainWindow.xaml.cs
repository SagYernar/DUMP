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
using DevOne.Security.Cryptography.BCrypt;

namespace BCrypt
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string login, password, hashedPassword;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            NewMethod(out login, out password);

            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
            {
                //зашифровать и сохранить
                hashedPassword = BCryptHelper.HashPassword(password, BCryptHelper.GenerateSalt());
                MessageBox.Show(hashedPassword);
            }
        }

        private void CheckUser_Click(object sender, RoutedEventArgs e)
        {
            NewMethod(out login, out password);

            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
            {
                string newHashString = BCryptHelper.HashPassword(password, BCryptHelper.GenerateSalt());
                MessageBox.Show(newHashString);

                bool isEqual = BCryptHelper.CheckPassword(password, hashedPassword);
                if (isEqual)
                {
                    MessageBox.Show("Equal");
                }
                else
                {
                    MessageBox.Show("Not Equal");
                }
            }
        }

        private void NewMethod(out string login, out string password)
        {
            login = loginTextBox.Text;
            password = passwordTextBox.Text;
        }
    }
}
