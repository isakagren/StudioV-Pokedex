import sys
import io
from Ladda import *
from Filter import *

pokelist = skapa_pokemonlista()

print("Ange sokning")
sok = sys.stdin.readline()

filtrerade_pokemons = filtrera_pokemons(sok[:-1], pokelist)
for pokemon in filtrerade_pokemons:
    print(pokemon.namn + "\t \t " + str(pokemon.liv) + "\t" + str(pokemon.attack))

