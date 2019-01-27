using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Pokki.Classes;

namespace Pokki
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Dialog.Type activeDialog;

        public MainWindow()
        {
            InitializeComponent();

            InitializeLevelUpList();

            AddLog(Dialog.selectStarterPokemon);

            activeDialog = Dialog.Type.SelectStarterPokemon;
        }

        private void InitializeLevelUpList()
        {
            uint levelCount = 100;

            int xpRequiredFirstLevel = 200;

            int[] levelUpList = new int[levelCount];


            levelUpList[0] = xpRequiredFirstLevel;

            for (uint i = 1; i <= levelCount-1; i++)
            {
                levelUpList[i] = Convert.ToInt32(levelUpList[i - 1] * 1.2);
            }

            Pokedex.SetLevelUpList(levelUpList);
        }

        

        public void AddLog(string message)
        {
            if (Tb_logs.Text.Length > 0 && Tb_logs.Text.Last() != '\n') Tb_logs.Text += "\n";

            Tb_logs.Text += message + "\n";
        }

        private void Tb_input_TextChanged(object sender, TextChangedEventArgs e)
        {
            //get every line of input from the user and process it
            if (Tb_input.Text.Contains('\n'))
            {
                String[] inputs = Tb_input.Text.Split('\n');

                foreach(String input in inputs)
                {
                    if (input == "") continue;

                    Dialog.ProcessUserInput(activeDialog, input);
                }
            }
        }

    }
}
