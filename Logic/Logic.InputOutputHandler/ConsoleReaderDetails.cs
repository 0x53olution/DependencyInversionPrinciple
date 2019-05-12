using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.x53olution.DependencyInversionPrinciple.Logic.InputOutputHandler
{
    class ConsoleReaderDetails : IReaderDetails
    {
        public ConsoleKeyInfo Read()
        {
            return Console.ReadKey();
        }
    }
}
