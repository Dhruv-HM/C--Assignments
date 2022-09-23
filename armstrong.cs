using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.exercise_bt_check_armstrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, t1,t2, remainder, result = 0,count=0;
            Console.WriteLine("Enter a number");
            n = int.Parse(Console.ReadLine());
            t1=t2= n;
            while(t2>0)
            {
                
                t2 = t2 / 10;
                count++;
            }
           
            while (n > 0)
            {
                remainder = n % 10;
                result=result + (int)Math.Pow(remainder,count);
                n = n / 10;
            }
            
            if(result == t1)
            {
                Console.WriteLine("The number is an armstrong number");
            }
            else
            {
                Console.WriteLine("The number is not an armstrong number");
            }
        }
    }
}
