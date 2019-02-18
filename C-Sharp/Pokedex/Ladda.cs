using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public class Ladda
    {
        public static List<Pokemon> LaddaPokemons()
        {
            // Skapa en lista där vi kan lädda pokemons
            var pokemons = new List<Pokemon>();

            // Läs in listan med pokemons
            using (var reader = new StreamReader(@"./Sökväg till databas"))
            {
                // Hoppa över den första raden
                reader.ReadLine();

                // Så länge det finns mer att läsa
                while (!reader.EndOfStream)
                {
                    // Läs in en rad
                    var line = reader.ReadLine();

                    // Dela raden i bitar vid varje kommatecken ( , ). 
                    var values = line.Split(',');

                    // Skapa en pokemonklass som håller datan från cell 2,3,4 i den uppdelade raden
                    var pokemon = new Pokemon
                    {
                        PokemonName = values[2],
                        HP = Int32.Parse(values[3]),
                        Atk = Int32.Parse(values[4])
                    };

                    // Lägg till pokemonen i listan
                    pokemons.Add(pokemon);
                }
            }

            return pokemons;
        }
    }
}
