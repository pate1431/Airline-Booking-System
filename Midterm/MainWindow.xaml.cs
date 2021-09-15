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

namespace Midterm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
    public MainWindow()
        {
            InitializeComponent();
           
        
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<string, string> credentials = new Dictionary<string, string>();

            Login l = new Login();
            List<Login> users = new List<Login>();
            users = l.getcredentials();
            foreach (var u in users)
            {
                credentials.Add(u.Username, u.Password);
            }
           

            var username = userbox.Text;
            string password = passbox.Password;

            if(credentials.Any(entry => entry.Key == username && entry.Value == password))
            {
                this.Hide();
                Menu m = new Menu();
                m.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login Entry");
            }
        }
    }
}
