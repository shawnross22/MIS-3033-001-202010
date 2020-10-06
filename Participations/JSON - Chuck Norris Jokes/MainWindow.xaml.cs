using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace JSON___Chuck_Norris_Jokes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string[] categories;

            using(var Client = new HttpClient())
            {
                string jsonResults = Client.GetStringAsync("https://api.chucknorris.io/jokes/categories").Result;

                categories = JsonConvert.DeserializeObject<string[]>(jsonResults);
            }

            cboCategories.Items.Add("all");
            foreach (var cat in categories)
            {
                cboCategories.Items.Add(cat);
            }

            

        }

        private void btnRandom_Click(object sender, RoutedEventArgs e)
        {
            string selecteditem = cboCategories.SelectedItem.ToString();
            if (selecteditem =="all")
            {
                string url = "https://api.chucknorris.io/jokes/random";
                ChuckJokeAPI api;
                using (var Client = new HttpClient())
                {
                    string results = Client.GetStringAsync(url).Result;
                    api = JsonConvert.DeserializeObject<ChuckJokeAPI>(results);
                }

                lblJoke.Content = api.value;
            }
            else
            {
                string caturl = $"https://api.chucknorris.io/jokes/random?category={selecteditem}";
                ChuckJokeAPI catapi;
                using (var Client = new HttpClient())
                {
                    string results = Client.GetStringAsync(caturl).Result;
                    catapi = JsonConvert.DeserializeObject<ChuckJokeAPI>(results);
                }

                lblJoke.Content = catapi.value;
            }
            
        }
    }
}
