using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokki.Classes
{
    class Pokemon_Base
    {
        protected string name;
        protected Pokemon_Base nextEvolution;
        protected UInt16 levelNextEvolution;

        public Pokemon_Base(string name, Pokemon_Base nextEvolution, UInt16 levelNextEvolution)
        {
            this.name = name;
            this.nextEvolution = nextEvolution;
            this.levelNextEvolution = levelNextEvolution;
        }

        #region "GET functions"

        public string Name()
        {
            return this.name;
        }

        public Pokemon_Base NextEvolution()
        {
            return this.nextEvolution;
        }

        public UInt16 LevelNextEvolution()
        {
            return this.levelNextEvolution;
        }

        #endregion


    }
}
