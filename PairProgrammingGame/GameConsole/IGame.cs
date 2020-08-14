using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramGame.GameConsole
{
    public interface IGame
    {
        void WriteLine(string s);
        void WriteLine(object o);
        void Write(string s);
        void Clear();
        string ReadLine();
        ConsoleKeyInfo ReadKey();

    }
}
