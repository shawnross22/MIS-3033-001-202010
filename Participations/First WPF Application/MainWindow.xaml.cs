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

namespace First_WPF_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txtName.Text = String.Empty;
            txtBday.Text = String.Empty;
            btnCalculateAge.IsEnabled = true;


        }

        private void btnCalculateAge_Click(object sender, RoutedEventArgs e)
        {
            
            string name = txtName.Text;
            string bday = txtBday.Text;

            DateTime bdaydatetime = Convert.ToDateTime(bday);

            int age = Convert.ToInt32((DateTime.Now - bdaydatetime).TotalDays);

            int ageinyears = age / 365;

            string message = $"{name}, you are {ageinyears} years old.";

            MessageBox.Show(message);




            
        }

        private void btnCalculateAge_MouseEnter(object sender, MouseEventArgs e)
        {
            btnCalculateAge.Background = Brushes.DeepPink;
        }

        private void btnCalculateAge_MouseLeave(object sender, MouseEventArgs e)
        {
            btnCalculateAge.Background = Brushes.OrangeRed;
        }

        private void btnCalculateAge_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
