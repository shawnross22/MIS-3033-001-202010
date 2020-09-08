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

namespace IntroToWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txtFavColor.Text = string.Empty;
            txtName.Clear();
            btn.IsEnabled = false;

            





        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            
            Info i = new Info();
            i.FavColor = txtFavColor.Text;
            i.Name = txtName.Text;
            string message = $"Hey {i.Name}, that's cool your favorite color is {i.FavColor}!";
            MessageBox.Show(message, "Welcome to MIS 3033!");
        }

        private bool ShouldWeEnableButtton()
        {
            bool result = false;
            if (txtFavColor.Text != string.Empty && txtName.Text != string.Empty)
            {
                result = true;
            }

            return result;
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            btn.IsEnabled = ShouldWeEnableButtton();
        }
    }
}
