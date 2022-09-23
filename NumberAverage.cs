using System;

namespace NumberAverage
{
    public class NumberAverage
    {
        static void Main(string[] args)
        {
            int arr_len;
            // get size of array
            Console.WriteLine("Enter the size of the Array");
            arr_len = int.Parse(Console.ReadLine());



            // declare array for the given size
            int[] ints = new int[arr_len];

            //get the values of the array from the user
            Console.WriteLine($"Enter the {arr_len} values to find average of");
            string arr_string=Console.ReadLine();
            string[] str=arr_string.Split(' ');

            for (int i = 0; i < str.Length; i++)
            {
                ints[i]=int.Parse(str[i]);
            }


            //call FindAverage() method to calculate average and receive string response

            string avgg=FindAverage(ints);

            //print the result
            Console.WriteLine($"The average value is: {avgg}");
        }

        //write here logic to calculate the average an array
        public static String FindAverage(int[] arr)
        {
            int neg_flag = 0;
            int avg = 0;
            foreach(int i in arr)
            {
                avg += i;
                if (i < 0)
                {
                    neg_flag = 1;   
                }
            }

            if (arr.Length == 0)
            {
                return "Array is Empty";
            }

            avg =avg/(arr.Length);

            

            if (neg_flag == 0)
            {
                return $"The Average is: {avg}";
            }

            else 
            {
                return "Negative values in array";
            }



        }
    }
}
