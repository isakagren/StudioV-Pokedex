# Pokemonklass
class Pokemon:
    def __init__(self, namn, liv, attack):
        self.namn=namn
        self.liv=liv
        self.attack=attack

    def __str__(self):
        return (self.namn + ', liv: ' + str(self.liv) + ', attack: ' + str(self.attack))


# Skapa en lista med alla pokemons i databasen
def skapa_pokemonlista():
    pokelist=list()

    # Läser in databasen
    f=open("./sokvag till databasen", "r")

    # Skippar forsta raden
    aPokemon = f.readline().strip().split(",")
    
    # Laser in filen och sparar pokemons i listan pokelist
    for p in f:
        enPokemon = p.strip().split(",")
        pokeobjekt=Pokemon(enPokemon[2].strip(), int(enPokemon[3]), int(enPokemon[4]))
        pokelist.append(pokeobjekt)
    return (pokelist)
