using System;

namespace exercise_state_wise_temperature_average
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*declare array for collecting temperature of cities of 3 states
             *
             *first state provides temperature of 3 cities
             *second state provides temperature of 7 cities
             *third state provides temperature of 4 cities
            */

            int[][] first = new int[3][] {
                new int[] { 1, 2, 3 },
                new int[] { 1, 2, 3, 4, 5 ,6,7},
                new int[] { 1, 2, 3, 4},
            };





            /*
             * Call GetStateWiseAverage() with state position and temperature data
             */

            int avg=GetStateWiseAverage(2, first);


            /*
             * Display Average
             */
            Console.WriteLine($"The average temperature of the state is {avg}");
        }

        /* 
         * Method calculates average of temperature for the state whose position is provided
         */

        public static int GetStateWiseAverage(int state, int[][] cities)
        {
            int average=0;
            foreach( int city in cities[state])
            {
                average += city;
            }

            return average / cities[state].Length;
        }
    }
}
