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
    /// Interaction logic for Airline_Page.xaml
    /// </summary>
    public partial class Airline_Page : Window
    {
        static Airline a = new Airline();
        static List<Airline> alist = a.getairlines();
        public Airline_Page()
        {
            InitializeComponent();
            foreach(var x in alist)
            {
                planebox.Items.Add(x);
            }
            planebox.SelectionMode = SelectionMode.Single;

        }



        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            var id = int.Parse(idbox.Text);
            var name = namebox.Text;

            
          
                string pl = (string)plane.Content;
            
            if(plane2.IsChecked == true)
            {
                pl = (string)plane2.Content;
            }

            
                string ml = (string)meal.Content;
            
            if(meal2.IsChecked == true)
            {
                 ml = (string)meal2.Content;
            }
            var seats = int.Parse(seatbox.Text);
            Airline ap = new Airline(id,name,pl,seats,ml);
            planebox.Items.Add(ap);
            alist.Add(ap);

            idbox.Text = "";
            namebox.Text = "";
            seatbox.Text = "";
            plane.IsChecked = true;
            meal2.IsChecked = true;


        }

        private void delbtn_Click(object sender, RoutedEventArgs e)
        {
            planebox.Items.Remove(planebox.SelectedItem);
            Airline a = (Airline)planebox.SelectedItem;
            alist.Remove(a);
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Show();
        }

        private void editbtn_Click(object sender, RoutedEventArgs e)
        {
            Airline al = (Airline)planebox.SelectedItem;
            idbox.Text = (al.Id).ToString();
            namebox.Text = al.Name;
            string planes = al.Airplane;
            string meals = al.Meals;
            int seats = al.Seats;

            if(planes == plane.Content)
            {
                plane.IsChecked = true;
                plane2.IsChecked = false;
            }
            else if(planes == plane2.Content)
            {
                plane.IsChecked = false;
                plane2.IsChecked = true;
            }
            if(meals == meal.Content)
            {
                meal.IsChecked = true;
                meal2.IsChecked = false;
            }
            else if (meals == meal2.Content)
            {
                meal.IsChecked = false;
                meal2.IsChecked = true;
            }
            planebox.Items.Remove(planebox.SelectedItem);
            alist.Remove(al);


        }
    }
}
