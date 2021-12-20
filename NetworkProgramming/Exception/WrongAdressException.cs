using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkProgramming.Exception1
{
    public class WrongAdressException:Exception
    {
        public WrongAdressException(string message):base(message)
        {

        }
    }
}
