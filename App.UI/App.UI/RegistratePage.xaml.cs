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
using App.Models;

namespace AppUI
{
    /// <summary>
    /// Логика взаимодействия для RegistratePage.xaml
    /// </summary>
    public partial class RegistratePage : Page
    {
        User currentUser;
        public RegistratePage()
        {
            InitializeComponent();
            currentUser = new User();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
           
        }


    }
}
