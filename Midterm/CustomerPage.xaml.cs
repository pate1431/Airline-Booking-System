using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Converters;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Midterm
{
    /// <summary>
    /// Interaction logic for CustomerPage.xaml
    /// </summary>
    public partial class CustomerPage : Window
    {
        static Customer c = new Customer();
       static List<Customer> clist = c.getcustomer();        

        public CustomerPage()
        {
            
            InitializeComponent();
            foreach (var x in clist) {
                clistbox.Items.Add(x);
                      
            }
            clistbox.SelectionMode = SelectionMode.Multiple;
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            var id = int.Parse(idbox.Text);
            var name = namebox.Text;
            var email = emailbox.Text;
            var address = addbox.Text;
            var phone = phonebox.Text;

            Customer nc = new Customer(id, name, email, address, phone);
            clist.Add(nc);
            clistbox.Items.Add(nc);
            foreach(var p in clist) {
                Console.WriteLine(p);
            }
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Show();
        }

        private void delbtn_Click(object sender, RoutedEventArgs e)
        {
            clistbox.Items.Remove(clistbox.SelectedItem);
            Customer c = (Customer)clistbox.SelectedItem;
            clist.Remove(c);
        }

        private void upbtn_Click(object sender, RoutedEventArgs e)
        {
            Customer c1 = (Customer)clistbox.SelectedItem;
            idbox.Text = (c1.Id).ToString();
            namebox.Text = c1.Name;
            emailbox.Text = c1.Email;
            addbox.Text = c1.Address;
            phonebox.Text = c1.Phone;

            clistbox.Items.Remove(clistbox.SelectedItem);
            clist.Remove(c1);
            
        }
    }
}
