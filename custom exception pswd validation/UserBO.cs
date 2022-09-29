using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_exception_pswd_validation
{
    public class UserBO
    {
        public static void validatePassword(string password)
        {
            WeakPasswordException weakpswdexp = new  WeakPasswordException("Weak password exception");
            bool spchar = password.Any(ch => !Char.IsLetterOrDigit(ch));
            if (spchar ==true)
            {
                spchar=false;
            }
            if (password.Length<10 || password.Length > 20)
            {
                throw weakpswdexp;
            }
            else if (!password.Any(char.IsDigit))
            {
                throw weakpswdexp;
            }
            else if (spchar)
            {
                throw weakpswdexp;
            }
            else
            {
                Console.WriteLine($"Password :{password}");
                
            }
        }
    }
}
