using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokki.Classes
{
    class Pokemon_Active : Pokemon_Base
    {
        private int xpActual;
        private int levelActual;

        public Pokemon_Active(Pokemon_Base pokemon) : base(pokemon.Name(), pokemon.NextEvolution(), pokemon.LevelNextEvolution())
        {
            xpActual = 0;
            levelActual = 1;
        }


        #region "GET functions"

        public int XpActual()
        {
            return xpActual;
        }

        public int LevelActual()
        {
            return levelActual;
        }

        #endregion


        #region "SET functions"



        #endregion
    }
}
