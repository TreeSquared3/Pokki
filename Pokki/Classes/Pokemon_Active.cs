using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokki.Classes
{
    class Pokemon_Active : Pokemon_Base
    {
        private UInt32 xpActual;
        private UInt32 levelActual;

        public Pokemon_Active(Pokemon_Base pokemon) : base(pokemon.Name(), pokemon.NextEvolution(), pokemon.LevelNextEvolution())
        {
            xpActual = 0;
            levelActual = 1;
        }

        public UInt32 XpActual()
        {
            return xpActual;
        }

        public UInt32 LevelActual()
        {
            return levelActual;
        }
    }
}
