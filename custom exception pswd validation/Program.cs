using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_exception_pswd_validation
{
    public class Program
    {
        static void Main(string[] args)
        {

            string firstName,lastName,email,password;
            Console.WriteLine("Enter First Name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter Email:");
            email = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            password = Console.ReadLine();

            User user = new User
            {
                firstName=firstName,
                lastName=lastName,  
                email=email,
                password=password
            };

            try
            {
                Console.WriteLine($"first name: {user.firstName}");
                Console.WriteLine($"last name: {user.lastName}");
                Console.WriteLine($"email: {user.email}");
                UserBO.validatePassword(password);
               
                //Console.WriteLine(user.password);

            }
            
            catch(WeakPasswordException weakpswdexp)
            {
                Console.WriteLine(weakpswdexp.Message);  
            }
        }
    }
}
