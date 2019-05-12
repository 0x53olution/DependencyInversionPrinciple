using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.x53olution.DependencyInversionPrinciple.Logic.InputOutputHandler
{
    public class FileWriter : IWriter, IDisposable
    {
        private StreamWriter _streamWriter;
        public FileWriter(string path)
        {
            _streamWriter = new StreamWriter(new FileStream(path, FileMode.Create));
        }

        public void Write(char character)
        {
            _streamWriter.Write(character);
        }

        public void Dispose()
        {
            _streamWriter.Dispose();
            _streamWriter = null;
        }
    }
}
