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
        protected string nextEvolution;
        protected int levelNextEvolution;

        public Pokemon_Base(string name, string nextEvolution, int levelNextEvolution)
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

        public string NextEvolution()
        {
            return this.nextEvolution;
        }

        public int LevelNextEvolution()
        {
            return this.levelNextEvolution;
        }

        #endregion


    }
}
