using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramGame.GameConsole
{ 
      class Program
      {
            static void Main(string[] args)
            {
                var game = new RealGame();

                GameUI ui = new GameUI(game);
                ui.Start();

            }
      }
}
