using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number=");
            int a=int.Parse(Console.ReadLine());
            int count = 0;
            for(int i=1;i<=a;i++)
            {
                if(a%i==0)
                {
                    count++;
                }
            }
            if(count==2)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("NOt prime");
            }
        }
    }
}
