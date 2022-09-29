using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount,max = 40000;
            Console.WriteLine("enter amount to withdraw");
            amount=int.Parse(Console.ReadLine());
            try
            {
                if (amount > max)
                {
                    WithdrawalLimitExceededException limit = new WithdrawalLimitExceededException("Withdrawal Limit Exceeded!");
                    throw limit;
                }
                else
                {
                    Console.WriteLine("Transaction Successful!");
                }
            }
            catch(WithdrawalLimitExceededException limit)
            {
                Console.WriteLine(limit.Message);
            }
        }
    }
    
    
}
