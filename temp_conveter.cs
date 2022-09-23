using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.exercise_bt_menu_driven_temperature_converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temp, result;
            int choice;
            Console.WriteLine("1.Centigrade to Fahrenheit\n2.Fahrenheit to Centigrade");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the Temperature");
            temp = double.Parse(Console.ReadLine());
            if (choice == 1)
            {
                result = temp * 1.8 + 32;
            }
            else if (choice== 2)
            {
                result = (temp - 32) * 5 / 9;
            }
            else
            {
                result = 893758;
            }
            Console.WriteLine(result);

        }
    }
}
