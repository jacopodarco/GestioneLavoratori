using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizioLavoratori
{
    class CustomExc : Exception
    {
        public CustomExc() : base()
        {

        }
        public CustomExc(string message) : base(message)
        {

        }
        public CustomExc(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
