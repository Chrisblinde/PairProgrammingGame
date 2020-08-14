using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramGame.GameConsole
{
    public class RealGame : IGame
    {
        public void Clear()
        {
            Console.Clear();
        }

        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void Write(string s)
        {
            Console.Write(s);
        }

        public void WriteLine(string s)
        {
            Console.WriteLine(s);
        }

        public void WriteLine(object o)
        {
            Console.WriteLine(o);
        }
    }
}

    

