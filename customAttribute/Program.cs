using System.Reflection.Metadata;

namespace customAttribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    
    [System.AttributeUsage(System.AttributeTargets.Class)]
    public class Author: Attribute
    {
        string name { get; set; }
        string email { get; set; }
        string createdAt { get; set; }
        
        public Author(string name,string email,string createdAt)
        {
            this.name = name;
            this.email = email;
            this.createdAt = createdAt; 
        }
    }
    [System.AttributeUsage(System.AttributeTargets.Method)]
    public class subroutine : Attribute
    {
        string description { get; set; }

        public subroutine(string description)
        {
            this.description = description;
        }
    }

    [Author ("john","John@gmail.com","thursday")]
    public class calculator
    {
        [subroutine("this is a subroutine")]
        public static void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        [subroutine("this is a subroutine")]
        public static void subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        [subroutine("this is a subroutine")]
        public static void multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        [subroutine("this is a subroutine")]
        public static void divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }

}