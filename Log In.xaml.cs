using System;
using System.Linq;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Documents;

namespace Exam3
{
    public partial class Log_In : Page
    {
        public Log_In()
        {
            InitializeComponent();
        }

         Entities13 dp = new Entities13();
        private void loog_btn_Click(object sender, RoutedEventArgs e)
        {   
           user_tabl user = dp.user_tabl.FirstOrDefault(x => x.UserName == user_box.Text && x.Passworde == pass_box.Text);
            string name = user_box.Text;
            if (user != null)  
            {
                Profile pf = new Profile();
                string n = user_box.Text;
                pf.pg.ItemsSource = dp.user_tabl.Where(x =>x.UserName == user_box.Text);
                pf.px = user_box.Text;
                this.NavigationService.Navigate(pf , user_box.Text);
  
            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}
