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
using System.Windows.Shapes;

namespace monaghese
{
    /// <summary>
    /// Interaction logic for sabtpeimankar.xaml
    /// </summary>
    public partial class sabtpeimankar : Window
    {
        public sabtpeimankar()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow win = new MainWindow();
            App.Current.MainWindow = win;
            this.Hide();
            win.Show();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow win = new MainWindow();
            App.Current.MainWindow = win;
            this.Hide();
            win.Show();
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow win = new MainWindow();
            App.Current.MainWindow = win;
            this.Hide();
            win.Show();
        }

        private void Rectangle_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Label_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
