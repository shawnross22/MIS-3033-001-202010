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

namespace JSON___Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string pokemonurl = "https://pokeapi.co/api/v2/pokemon?offset=0&limit=1100/";
            PokemonAPI pokemonapi;
            using (var client = new HttpClient())
            {
                string pokeResults = client.GetStringAsync(pokemonurl).Result;

                pokemonapi = JsonConvert.DeserializeObject<PokemonAPI>(pokeResults);
            }

            foreach (var poke in pokemonapi.results)
            {
                cboPoke.Items.Add(poke);
            }

            PokeInfoAPI pokeInfoAPI;
            string pokeInfoURL = "";
            if (pokemonWasSelected == false)
            {
                Pokemon selectedPokemon = new Pokemon();
                pokeInfoURL = selectedPokemon.url;
            }
            
            using (var client = new HttpClient())
            {
                    string pokeInfo = client.GetStringAsync(pokeInfoURL).Result;

                    pokeInfoAPI = JsonConvert.DeserializeObject<PokeInfoAPI>(pokeInfo);
            }
            

            
        }

        private void cboPoke_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            bool pokemonWasSelected = true;
            Pokemon selectedpokemon = (Pokemon)cboPoke.SelectedItem;
            PokeInfoAPI selectedInfo = selectedpokemon.url;
            Uri uri;

            if (button1wasClicked == false)
            {
                uri = new Uri(selectedInfo.sprites.front_default);
                BitmapImage frontsprite = new BitmapImage(uri);
                imgPoke.Source = frontsprite;
                lblPokeInfo.Content = $"{selectedpokemon.name}, Height: {selectedInfo.height}, Weight {selectedInfo.weight}";
            }
            else if (button1wasClicked == true)
            {
                uri = new Uri(selectedPokeInfo.sprites.back_default);
                BitmapImage backsprite = new BitmapImage(uri);
                imgPoke.Source = backsprite;
            }


        }

        public bool button1wasClicked = false;
        public bool pokemonWasSelected = false;
        private void btnSprite_Click(object sender, RoutedEventArgs e)
        {
            int i = 1;
            i = i + 1;
            if (i%2==0)
            {
                button1wasClicked = true;
            }
            else if (i % 2 == 1)
            {
                button1wasClicked = false;
            }
        }
    }
}
