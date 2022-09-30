using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobileNumberValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContactDetail cd = new ContactDetail();
            ContactDetailBO cdbo = new ContactDetailBO();
            Console.WriteLine("Enter mobile number");
            cd.mobile = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter alternate mobile number");
            cd.alternateMobile = long.Parse(Console.ReadLine());
            try
            {
                cdbo.validate(cd);
            }
            catch(DuplicateNumberException dup)
            {
                Console.WriteLine(dup.Message);
            }
        }
    }

    class ContactDetail
    {
        public long mobile { get; set; }
        public long alternateMobile { get; set; }
        long landLine { get; set; } 
        string email { get; set; }
        string address { get; set; }
        //public ContactDetail(long mobile, long alternateMobile, long landLine, string email, string address)
        //{
        //    this.mobile = mobile;
        //    this.alternateMobile = alternateMobile;
        //    this.landLine = landLine;
        //    this.email = email;
        //    this.address = address;
        //}

    }
    class ContactDetailBO
    {
        public void validate(ContactDetail cd)
        {
            if (cd.mobile == cd.alternateMobile)
            {
                DuplicateNumberException dup = new DuplicateNumberException("Exception: Same Mobile number and Alternate Mobile number.");
                throw dup;
            }
            else
            {
                Console.WriteLine($"mobile number: {cd.mobile}");
                Console.WriteLine($"mobile number: {cd.alternateMobile}");

            }
        }
    }

    class DuplicateNumberException:Exception
    {
        public DuplicateNumberException(string message) : base(message)
        {

        }
    }
}
