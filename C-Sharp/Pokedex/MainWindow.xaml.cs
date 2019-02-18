using System;
using System.Collections.Generic;
using System.IO;
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

namespace Pokedex
{
    
    public partial class MainWindow : Window
    {
        private List<Pokemon> _pokemons;

        public MainWindow()
        {
            InitializeComponent();
            _pokemons = Ladda.LaddaPokemons();
        }
       
        public void RedrawPokemons (List<Pokemon> pokemons)
        {

            Results.Children.Clear();

            var nameL = new Label();
            var hpL = new Label();
            var atkL = new Label();

            nameL.Content = "Namn";
            hpL.Content = "HP";
            atkL.Content = "Atk";

            Grid.SetColumn(nameL, 0);
            Grid.SetColumn(hpL, 1);
            Grid.SetColumn(atkL, 2);

            Grid.SetRow(nameL, 0);
            Grid.SetRow(hpL, 0);
            Grid.SetRow(atkL, 0);

            Results.RowDefinitions.Add(new RowDefinition());

            Results.Children.Add(nameL);
            Results.Children.Add(hpL);
            Results.Children.Add(atkL);

            for (int i = 0; i < pokemons.Count; i++)
            {
                var pokemon = pokemons[i];

                var name = new Label();
                var hp = new Label();
                var atk = new Label();

                name.Content = pokemon.PokemonName;
                hp.Content = pokemon.HP;
                atk.Content = pokemon.Atk;

                Grid.SetColumn(name, 0);
                Grid.SetColumn(hp, 1);
                Grid.SetColumn(atk, 2);

                Grid.SetRow(name, i+1);
                Grid.SetRow(hp, i+1);
                Grid.SetRow(atk, i+1);

                Results.RowDefinitions.Add(new RowDefinition());

                Results.Children.Add(name);
                Results.Children.Add(hp);
                Results.Children.Add(atk);
            }
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            RedrawPokemons(Filter.FiltreraPokemons(SearchBox.Text, _pokemons));
        }
    }
}
