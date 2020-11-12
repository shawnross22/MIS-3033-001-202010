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

namespace Classes_3
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

        private void btnValidate_Click(object sender, RoutedEventArgs e)
        {
            double gpa;
            int streetnumber;
            int zipcode;

            if (txtFirstName.Text != "" && txtLastName.Text != "" && txtMajor.Text != "" && txtGPA.Text != "" && txtStreetNumber.Text != ""
                && txtStreetName.Text != "" && txtCity.Text != "" && txtState.Text != "" && txtZipCode.Text != "")
            {
                if (Double.TryParse(txtGPA.Text, out gpa) == true && Int32.TryParse(txtStreetNumber.Text, out streetnumber) == true
                    && Int32.TryParse(txtZipCode.Text, out zipcode) == true)
                {
                    gpa = Convert.ToDouble(txtGPA.Text);
                    streetnumber = Convert.ToInt32(txtStreetNumber.Text);
                    zipcode = Convert.ToInt32(txtZipCode.Text);

                    Student student = new Student();
                    student.FirstName = txtFirstName.Text;
                    student.LastName = txtLastName.Text;
                    student.Major = txtMajor.Text;
                    student.GPA = gpa;
                    student.SetAddress(streetnumber, txtStreetName.Text, txtState.Text, txtCity.Text, zipcode);

                    

                    lstInfo.Items.Add(student);


                }
                else
                {
                    if (Double.TryParse(txtGPA.Text, out gpa) == false)
                    {
                        MessageBox.Show("The GPA you entered is not a valid double.");
                    }
                    if (Int32.TryParse(txtStreetNumber.Text, out streetnumber) == false)
                    {
                        MessageBox.Show("The Street Number you entered is not a valid integer.");
                    }
                    if (Int32.TryParse(txtZipCode.Text, out zipcode) == false)
                    {
                        MessageBox.Show("The Zip Code you entered is not a valid integer.");
                    }
                }
            }
            else
            {
                if (txtFirstName.Text == "")
                {
                    MessageBox.Show("You did not enter a First Name.");
                }
                if (txtLastName.Text == "")
                {
                    MessageBox.Show("You did not enter a Last Name.");
                }
                if (txtMajor.Text == "")
                {
                    MessageBox.Show("You did not enter a Major.");
                }
                if (txtGPA.Text == "")
                {
                    MessageBox.Show("You did not enter a GPA.");
                }
                if (txtStreetNumber.Text == "")
                {
                    MessageBox.Show("You did not enter a Street Number.");
                }
                if (txtStreetName.Text == "")
                {
                    MessageBox.Show("You did not enter a Street Name.");
                }
                if (txtCity.Text == "")
                {
                    MessageBox.Show("You did not enter a City.");
                }
                if (txtState.Text == "")
                {
                    MessageBox.Show("You did not enter a State.");
                }
                if (txtZipCode.Text == "")
                {
                    MessageBox.Show("You did not enter a Zip Code.");
                }
            }
        }

        private void lstInfo_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lstInfo.SelectedItem != null)
            {
                
                Student selectedStudent = (Student)lstInfo.SelectedItem;
                
              
                StudentAddressWindow studentAddress = new StudentAddressWindow();
                studentAddress.Setup(selectedStudent);
                studentAddress.ShowDialog();
            }
        }
    }
}
