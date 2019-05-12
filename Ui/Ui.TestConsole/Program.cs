using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.x53olution.DependencyInversionPrinciple.Ui.ConsoleCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            Copy();
        }

        private static void Copy()
        {
            while (true)
            {
                var characterInfo = Console.ReadKey(true);
                if (characterInfo.Key == ConsoleKey.Escape)
                {
                    return;
                }else
                {
                    Console.Write(characterInfo.KeyChar);
                }
            }
        }
    }
}
