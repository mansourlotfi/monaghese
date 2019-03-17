using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace monaghese
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

        monagheseEntities db = new monagheseEntities();
        
        


        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Sabtkarfarma win = new Sabtkarfarma();
            App.Current.MainWindow = win;
            this.Hide();
            win.Show();
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Sabtkarfarma win = new Sabtkarfarma();
            App.Current.MainWindow = win;
            this.Hide();
            win.Show();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Sabtkarfarma win = new Sabtkarfarma();
            App.Current.MainWindow = win;
            this.Hide();
            win.Show();
        }

        private void Rectangle_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Label_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Rectangle_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            sabtpeimankar win = new sabtpeimankar();
            App.Current.MainWindow = win;
            this.Hide();
            win.Show();
        }

        private void Label_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            sabtpeimankar win = new sabtpeimankar();
            App.Current.MainWindow = win;
            this.Hide();
            win.Show();
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            sabtpeimankar win = new sabtpeimankar();
            App.Current.MainWindow = win;
            this.Hide();
            win.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=monaghese;Integrated Security=True");
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            string query = "select count(1) from Table_modir where Username=@Username AND Password=@Password";
            SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.Parameters.AddWithValue("@Username", txt_username.Text);
            sqlcmd.Parameters.AddWithValue("@Password", txt_password.Password);
            int count = Convert.ToInt32(sqlcmd.ExecuteScalar());
            if (count == 1)

            {
                if (rd_modir.IsChecked == true)
                {
                    paneladmin pn = new paneladmin();
                    pn.Show();
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه است");
            }


        }
    }
}
