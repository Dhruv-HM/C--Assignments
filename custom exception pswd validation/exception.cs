using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_exception_pswd_validation
{
    internal class WeakPasswordException : Exception
    {
        public WeakPasswordException(string msg) : base(msg)
        {

        }
    }
}
