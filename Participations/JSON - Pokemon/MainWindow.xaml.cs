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

            
        }

        private void cboPoke_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PokeInfoAPI pokeInfoAPI;
            Pokemon selectedpokemon = (Pokemon)cboPoke.SelectedItem;
            string pokeInfoURL = selectedpokemon.url;

            using (var client = new HttpClient())
            {
                string pokeInfo = client.GetStringAsync(pokeInfoURL).Result;

                pokeInfoAPI = JsonConvert.DeserializeObject<PokeInfoAPI>(pokeInfo);
            }
            Uri uri;
            uri = new Uri(pokeInfoAPI.sprites.front_default);
            BitmapImage frontsprite = new BitmapImage(uri);
            imgPoke.Source = frontsprite;
            lblPokeInfo.Content = $"{selectedpokemon.name}, Height: {pokeInfoAPI.height}, Weight {pokeInfoAPI.weight}";
            frontSpriteShowing = true;
        }

        private bool frontSpriteShowing;
        
        private void btnSprite_Click(object sender, RoutedEventArgs e)
        {
            
            PokeInfoAPI pokeInfoAPI;
            Pokemon selectedpokemon = (Pokemon)cboPoke.SelectedItem;
            string pokeInfoURL = selectedpokemon.url;

            using (var client = new HttpClient())
            {
                string pokeInfo = client.GetStringAsync(pokeInfoURL).Result;

                pokeInfoAPI = JsonConvert.DeserializeObject<PokeInfoAPI>(pokeInfo);
            }
            Uri uri;

            if (frontSpriteShowing == true)
            {
                uri = new Uri(pokeInfoAPI.sprites.back_default);
                BitmapImage backsprite = new BitmapImage(uri);
                imgPoke.Source = backsprite;
                frontSpriteShowing = false;
            }
            else if (frontSpriteShowing == false)
            {
                uri = new Uri(pokeInfoAPI.sprites.front_default);
                BitmapImage frontsprite = new BitmapImage(uri);
                imgPoke.Source = frontsprite;
                frontSpriteShowing = true;
            }
        
    }
    }
}
