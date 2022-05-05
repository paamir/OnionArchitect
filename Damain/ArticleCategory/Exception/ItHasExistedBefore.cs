using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damain
{
    class ItHasExistedBefore : System.Exception
    {
        public ItHasExistedBefore(string Message): base(Message)
        {
        }
    }
}
