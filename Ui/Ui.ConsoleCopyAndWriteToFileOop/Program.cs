using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.x53olution.DependencyInversionPrinciple.Logic.CopyProcess;
using com.x53olution.DependencyInversionPrinciple.Logic.InputOutputHandler;

namespace com.x53olution.DependencyInversionPrinciple.Ui.ConsoleCopyAndWriteToFileOop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Composition Root
            var reader = new ConsoleReader();
            //var writer = new ConsoleWriter();
            var writer = new FileWriter("result.txt");
            var copyProcess = new CopyProcess(reader, writer);

            // Run programm
            copyProcess.Copy();
            writer.Dispose();
        }
    }
}
