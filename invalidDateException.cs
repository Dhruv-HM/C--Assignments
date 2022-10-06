using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string start, end;
            DateTime start1, end1;
            try
            {

                Console.WriteLine("enter start date: ");
                start = (Console.ReadLine());
                Console.WriteLine("enter end date: ");
                end = (Console.ReadLine());
                start1 = DateTime.Parse(start);
                end1 = DateTime.Parse(end);
                Console.WriteLine("\n");
                Console.WriteLine(start1);
                Console.WriteLine(end1);
            }
            catch
            {
                Console.WriteLine("Invalid input");
            }

            
        }
    }
}

