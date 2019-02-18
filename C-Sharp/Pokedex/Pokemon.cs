namespace Pokedex
{
    public class Pokemon
    {
        public string PokemonName { get; set; }
        public int HP { get; set; }
        public int Atk { get; set; }

        public override string ToString()
        {
            return $"Pokemon: ${this.PokemonName} \t HP: ${this.HP} \t Atk: ${this.Atk}\n";
        }
    }

}