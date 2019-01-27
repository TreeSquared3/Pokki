using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokki.Classes
{
    static public class Dialog
    {
        public enum Type
        {
            none,
            SelectStarterPokemon
        }

        #region "Constants"

        static String help = "Oops, we don't have a help for now";
        static String invalid = "Invalid input!";
        static public String selectStarterPokemon = "Select your starter Pokemon!" + "\n"
            + "[1] Charmander" + "\n"
            + "[2] Bulbasaur" + "\n"
            + "[3] Squirtle" + "\n"
            + "[4] Rattata";

        #endregion

        public static void ProcessUserInput(MainWindow window, string input)
        {
            switch (window.activeDialog)
            {
                case Type.none:

                    switch (input.ToLower())
                    {
                        case "h":

                        case "help":

                            window.AddLog(help);

                            window.activeDialog = Type.none;

                            break;

                        default:

                            window.AddLog(invalid);

                            break;
                    }

                    break;

                case Type.SelectStarterPokemon:

                    switch (input.ToLower())
                    {
                        case "1":

                            window.activeDialog = Type.none;

                            break;

                        case "2":

                            

                            window.activeDialog = Type.none;

                            break;

                        default:

                            window.AddLog(invalid);

                            break;
                    }

                    break;
            }
        }

    }
}
