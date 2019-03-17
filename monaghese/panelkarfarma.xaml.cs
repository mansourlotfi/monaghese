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
    /// Interaction logic for panelkarfarma.xaml
    /// </summary>
    public partial class panelkarfarma : Window
    {
        public panelkarfarma()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MainWindow win = new MainWindow();
            App.Current.MainWindow = win;
            this.Hide();
            win.Show();
        }
    }
}
