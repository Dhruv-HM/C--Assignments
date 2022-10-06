using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace seatBookingException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] row = new int[6];
            int seats,seatno;
            string seatstring;
            Console.WriteLine("Enter booking details");
            seats=Convert.ToInt32(Console.ReadLine());
            seatstring=seats.ToString();
            row = seatstring.Select(o => Convert.ToInt32(o) - 48).ToArray();
            Console.WriteLine("Enter seat number to book: ");
            seatno = Convert.ToInt32(Console.ReadLine());
            seatno += 1;
            try
            {   if(seatno<1 || seatno>row.Length)
                {
                    IndexOutOfRangeException ex =new IndexOutOfRangeException();
                    throw ex;
                }
                if (row[seatno] == 1)
                {
                    SeatNotAvailableException ex = new SeatNotAvailableException("Seat booked already");
                    throw ex;
                }
                else
                {
                    Console.WriteLine("Booked Successfully");
                }

            }
            catch(SeatNotAvailableException ex)
            {
                Console.WriteLine( ex.Message );
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range");
            }
            
          
        }
    }

    class SeatNotAvailableException : Exception
    {
        public SeatNotAvailableException(string message) : base(message) { }
    }
}
