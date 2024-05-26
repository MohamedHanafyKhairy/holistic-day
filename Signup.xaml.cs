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

namespace Exam3
{
    /// <summary>
    /// Interaction logic for Signup.xaml
    /// </summary>
    public partial class Signup : Page
    {
        public Signup()
        {
            InitializeComponent();
            List<string> countries = new List<string> { "Giza", "Cairo", "Fayom", "Luxor", "Aswan" };
            combo_choose.ItemsSource = countries;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Log_In ln = new Log_In();
            this.NavigationService.Navigate(ln);
        }

        private void combo_choose_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void sign_btn_Click(object sender, RoutedEventArgs e)
        {
            Entities13 dp = new Entities13();
            user_tabl user = new user_tabl();

            user.UserName = user_box.Text;
            user.Passworde = pass_box.Text;
            user.Phone_Number = phone_box.Text;
            user.Age = int.Parse(age_box.Text);
            user.City = combo_choose.SelectedIndex.ToString();

            if (male_rad.IsChecked == true)
            {
                user.Gender = "Male";
            }
            else 
            {
                user.Gender = "Female";
            }

            dp.user_tabl.Add(user);
            dp.SaveChanges();

            MessageBox.Show("Sign Up Succsesfully -_-");
            Log_In li = new Log_In();
            string mn = user_box.Text;
            this.NavigationService.Navigate(li , mn);
        }
    }
}