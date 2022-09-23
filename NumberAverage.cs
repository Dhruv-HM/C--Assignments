using System;

namespace NumberAverage
{
    public class NumberAverage
    {
        static void Main(string[] args)
        {
            int arr_len;
            int flag = 0;
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
                if(ints[i]<0)
                {
                    //Console.WriteLine("Error");
                    flag = 1;
                }
            }


            //call FindAverage() method to calculate average and receive string response

            

            if (flag == 1)
            {
                Console.WriteLine("Error");
            }

            else
            {
                string avgg = FindAverage(ints);

                //print the result
                Console.WriteLine($"The average value is: {avgg}");
            }
        }

        //write here logic to calculate the average an array
        public static String FindAverage(int[] arr)
        {
            int avg = 0;
            foreach(int i in arr)
            {
                avg += i;
            }
            avg=avg/(arr.Length);
            
            return avg.ToString();

        }
    }
}
