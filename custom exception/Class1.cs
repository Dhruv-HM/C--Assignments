using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_exception
{
    internal class WithdrawalLimitExceededException : Exception
    {
        public WithdrawalLimitExceededException(string message) : base(message)
        {

        }
    }

    
}
