using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brusmaskin.Commands
{
    internal interface IKommando
    {
        string GetKommando();
        void Run();
    }
}
