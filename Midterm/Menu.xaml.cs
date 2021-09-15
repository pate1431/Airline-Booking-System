using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Midterm
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
      
        public Menu()
        {
            InitializeComponent();
        }

        private void cbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            CustomerPage cp = new CustomerPage();
            cp.Show();
        }

        private void exitbtn_Click(object sender, RoutedEventArgs e)
        {

            System.Windows.Application.Current.Shutdown();

        }

        private void fbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Flight_Page fp = new Flight_Page();
            fp.Show();
        }

        private void abtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Airline_Page ap = new Airline_Page();
            ap.Show();
        }

        private void pbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Passenger_Page pp = new Passenger_Page();
            pp.Show();
        }
    }
}
