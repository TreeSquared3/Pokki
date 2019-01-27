using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokki.Classes
{
    static class Pokedex
    {
        
        private static Dictionary<String, Pokemon_Base> pokedex = new Dictionary<string, Pokemon_Base>() //stores info about all pokemon in the game
        {
            { "Raticate", new Pokemon_Base("Raticate", null, 0)},
            { "Rattata", new Pokemon_Base("Rattata", "Raticate", 20)},

            { "Blastoise", new Pokemon_Base("Blastoise", null, 0)},
            { "Wartortle", new Pokemon_Base("Wartortle", "Blastoise", 36)},
            { "Squirtle", new Pokemon_Base("Squirtle", "Wartortle", 16)},

            { "Venusaur", new Pokemon_Base("Venusaur", null, 0)},
            { "Ivysaur", new Pokemon_Base("Ivysaur", "Venusaur", 32)},
            { "Bulbasaur", new Pokemon_Base("Bulbasaur", "Ivysaur", 16)},

            { "Charizard", new Pokemon_Base("Charizard", null, 0)},
            { "Charmelon", new Pokemon_Base("Charmelon", "Charizard", 36)},
            { "Charmander", new Pokemon_Base("Charmander", "Charmelon", 16)}
        };

        private static int[] levelUpList = new int[] //stores the required xp for the next level for the current level
        {
            // for now values will be added at startup through the InitializeLevelUpList() method in MainWindow.xaml
        };


        #region "GET functions"

        public static int GetLevelUpXpRequired(UInt32 currentLevel)
        {
            if (currentLevel > levelUpList.Count()) return -1;

            return levelUpList[currentLevel - 1];
        }

        public static Pokemon_Base GetPokemon(String name)
        {
            Pokemon_Base pokemon;

            if (pokedex.TryGetValue(name, out pokemon))
            {
                return pokemon;
            }

            return null;
        }

        public static Boolean DoesPokemonExist(String name)
        {
            return pokedex.ContainsKey(name);
        }

        #endregion


        #region "SET functions"

        public static void SetLevelUpList(int[] levelUpListNew)
        {
            levelUpList = levelUpListNew;
        }

        #endregion

        
    }
}
