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
using AppModels;
using AppServices;
using AppData;

namespace AppUI
{
    /// <summary>
    /// Логика взаимодействия для AutorizationPage.xaml
    /// </summary>
    public partial class AutorizationPage : Page
    {       
        UserService userService;
        DataBase dataBase;
        public AutorizationPage()
        {
            InitializeComponent();
            userService = new UserService();
            dataBase = new DataBase();
        }

        private void RegistrateButton_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as MainWindow).NavigationService.Navigate(new RegistratePage());
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            if (userService.CheckAutorization(loginTextBox.Text, passwordTextBox.Text))
            {
                noEnterTextBlock.Visibility = Visibility.Hidden;
                (this.Parent as MainWindow).NavigationService.Navigate(new HelloPage());
            }
            else
            {
                noEnterTextBlock.Visibility = Visibility.Visible;
            }
        }
    }
}
