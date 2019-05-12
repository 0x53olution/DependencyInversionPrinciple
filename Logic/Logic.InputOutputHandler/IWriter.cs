using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.x53olution.DependencyInversionPrinciple.Logic.InputOutputHandler
{
    public interface IWriter
    {
        void Write(char character);
    }
}
