using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.x53olution.DependencyInversionPrinciple.Ui.ConsoleCopyAndWriteToFile
{
    class Program
    {

        static void Main(string[] args)
        {
            Copy(Target.File);
        }

        private static void Copy(Target target)
        {
            if (target == Target.File)
            {
                File.Initialize("result.txt");
            }

            while (true)
            {
                var characterInfo = Console.ReadKey(true);
                if (characterInfo.Key == ConsoleKey.Escape)
                {
                    break;
                }
                if (target == Target.Console)
                {
                    Console.Write(characterInfo.KeyChar);
                }
                else if (target == Target.File)
                {
                    File.Write(characterInfo.KeyChar);                   
                }
            }

            if (target == Target.File)
            {
                File.Dispose();
            }
        }
    }

    public enum Target
    {
        Console,
        File
    }

    public static class File
    {
        private static StreamWriter _streamWriter;

        public static void Initialize(string path)
        {
            _streamWriter = new StreamWriter(new FileStream(path, FileMode.OpenOrCreate));
        }

        public static void Write(char character)
        {
            _streamWriter.Write(character);
        }

        public static void Dispose()
        {
            _streamWriter.Dispose();
            _streamWriter = null;
        }
    }
}
