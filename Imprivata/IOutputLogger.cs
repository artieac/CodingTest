using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imprivata
{
    public interface IOutputLogger
    {
        void WriteMessage(string message);

        void ClearLog();
    }
}
