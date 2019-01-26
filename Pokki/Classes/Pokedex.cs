using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokki.Classes
{
    class Pokedex
    {
        private Dictionary<String, Pokemon_Base> pokedex; //stores info about all pokemon in the game
        private Dictionary<UInt32, UInt32> levelUpList; //stores the required xp for the next level for the current level


        #region "constructor"

        public Pokedex()
        {
            InitializePokemon();
            InitializeLevelUpList();
        }
               
        private void InitializePokemon()
        {
            pokedex.Add("Raticate", new Pokemon_Base("Raticate", null, 0));
            pokedex.Add("Rattata", new Pokemon_Base("Rattata", GetPokemon("Raticate"), 20));

            pokedex.Add("Blastoise", new Pokemon_Base("Blastoise", null, 0));
            pokedex.Add("Wartortle", new Pokemon_Base("Wartortle", GetPokemon("Blastoise"), 36));
            pokedex.Add("Squirtle", new Pokemon_Base("Squirtle", GetPokemon("Wartortle"), 16));

            pokedex.Add("Venusaur", new Pokemon_Base("Venusaur", null, 0));
            pokedex.Add("Ivysaur", new Pokemon_Base("Ivysaur", GetPokemon("Venusaur"), 32));
            pokedex.Add("Bulbasaur", new Pokemon_Base("Bulbasaur", GetPokemon("Ivysaur"), 16));

            pokedex.Add("Charizard", new Pokemon_Base("Charizard", null, 0));
            pokedex.Add("Charmelon", new Pokemon_Base("Charmelon", GetPokemon("Charizard"), 36));
            pokedex.Add("Charmander", new Pokemon_Base("Charmander", GetPokemon("Charmelon"), 16));
        }

        private void InitializeLevelUpList()
        {
            levelUpList.Add(1, 200);

            for(UInt32 i=2;i<=100;i++)
            {
                UInt32 nextLevel;

                levelUpList.TryGetValue(i - 1, out nextLevel);

                levelUpList.Add(i, Convert.ToUInt32(nextLevel * 1.2));
            }
        }

        #endregion

               
        public Pokemon_Base GetPokemon(String name)
        {
            Pokemon_Base pokemon;

            if (pokedex.TryGetValue(name, out pokemon))
            {
                return pokemon;
            }

            return null;
        }

        public Boolean DoesPokemonExist(String name)
        {
            return pokedex.ContainsKey(name);
        }
    }
}
