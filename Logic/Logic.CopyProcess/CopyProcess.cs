using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.x53olution.DependencyInversionPrinciple.Logic.InputOutputHandler;

namespace com.x53olution.DependencyInversionPrinciple.Logic.CopyProcess
{
    public class CopyProcess
    {
        private readonly IReader _reader;
        private readonly IWriter _writer;

        public CopyProcess(IReader reader, IWriter writer)
        {
            _reader = reader;
            _writer = writer;
        }

        public void Copy()
        {
            while (true)
            {
                var characterInfo = _reader.Read();
                if (characterInfo.ShouldQuit)
                {
                    break;
                }
                _writer.Write(characterInfo.Character);
            }
        }
    }
}
