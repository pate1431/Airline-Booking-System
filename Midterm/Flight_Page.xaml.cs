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
    /// Interaction logic for Flight_Page.xaml
    /// </summary>
    public partial class Flight_Page : Window
    {
       static Flights f = new Flights();
        static List<Flights> flist = f.getFlight();
        public Flight_Page()
        {
            InitializeComponent();
            foreach(var x in flist)
            {
                flightbox.Items.Add(x);
            }
            flightbox.SelectionMode = SelectionMode.Single;


        }



        private void add_Click(object sender, RoutedEventArgs e)
        {
            var id = int.Parse(idbox.Text);
            var airlineid = int.Parse(airbox.Text);
            var deptcity = deptbox.Text;
            var destcity = estbox.Text;
            var flighttime = double.Parse(timebox.Text);
            var date = datebox.Text;

            Flights f = new Flights(id,airlineid,deptcity,destcity,date,flighttime);
            flightbox.Items.Add(f);
            flist.Add(f);

            idbox.Text = "";
            airbox.Text = "";
            deptbox.Text = "";
            estbox.Text = "";
            timebox.Text = "";
            datebox.Text = "";
            

        }

        private void delbtn_Click(object sender, RoutedEventArgs e)
        {
            flightbox.Items.Remove(flightbox.SelectedItem);
            Flights f = (Flights)flightbox.SelectedItem;
            flist.Remove(f);
        }

        private void editbtn_Click(object sender, RoutedEventArgs e)
        {
            Flights fp = (Flights)flightbox.SelectedItem;
            idbox.Text = (fp.Id).ToString();
            airbox.Text = (fp.AirlineId).ToString();
            deptbox.Text = fp.Departurecity;
            estbox.Text = fp.Destinationcity;
            datebox.Text = fp.Departuredate;
            timebox.Text = (fp.Flighttime).ToString();

            flightbox.Items.Remove(flightbox.SelectedItem);
            flist.Remove(fp);
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Show();
        }

        
    }
}
