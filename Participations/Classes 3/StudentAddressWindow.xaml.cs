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

namespace Classes_3
{
    /// <summary>
    /// Interaction logic for StudentAddressWindow.xaml
    /// </summary>
    public partial class StudentAddressWindow : Window
    {
        
        public StudentAddressWindow()
        {
            InitializeComponent();
        }
        public void Setup(Student s)
        {
            lblName.Content = $"{s.FirstName} {s.LastName}";
            lblAddress.Content = $"{s.Address.StreetNumber} {s.Address.StreetName}, {s.Address.City}, {s.Address.State}, {s.Address.Zipcode}";

            this.Title = $"{s.FirstName.ToUpper()} {s.LastName.ToUpper()} Address!";
        }
    }
}
