using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExcp
{
    internal class DataNOtFoundException : Exception
    {
        public DataNOtFoundException(string message) : base(message)
        {
        }
    }
}
