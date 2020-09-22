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

namespace WPF___Classes_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Toy> toys = new List<Toy>();

        }

        

        private void btnAisle_Click(object sender, RoutedEventArgs e)
        {
            double price;

            if (txtManufacturer.Text.Length > 0 && txtName.Text.Length > 0 && txtPrice.Text.Length > 0)
            {
                if (Double.TryParse(txtPrice.Text, out price) == true)
                {
                    price = Convert.ToDouble(txtPrice.Text);
                    Toy toy = new Toy();
                    toy.Manufacturer = txtManufacturer.Text;
                    toy.Name = txtName.Text;
                    toy.Price = price;

                    lstToys.Items.Add(toy);
                    lstToys.Items.ToString();
                }
                else
                {
                    MessageBox.Show($"The price you entered is not a valid double.");
                }
            }
            else
            {
                MessageBox.Show($"You did not enter all of the criteria necessary.");
            }
            
        }

        private void lstToys_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Toy selectedtoy = (Toy)lstToys.SelectedItem;
            MessageBox.Show(selectedtoy.GetAisle());
        }
    }
}
