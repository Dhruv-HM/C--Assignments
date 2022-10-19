using static delegate_ass1.Dgate;

namespace delegate_ass1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1 . Multicast delegate

            Dgate dgate = new Dgate();
            //initialization ie binding
            CalculateHandler calculateHandler = new CalculateHandler(Dgate.add);
            calculateHandler += Dgate.subtract;
            calculateHandler += Dgate.divide;
            calculateHandler += Dgate.multiply;

            //invoke
            calculateHandler.Invoke(20, 10);

            //Q2. Func Delegate
            Func<int, int, int> val = Dgate.add;
            Console.WriteLine(val(20,10));
        }


    }
    class Dgate {
        //declaration
        //Q1 multicast delegate 
        public delegate void CalculateHandler(int x, int y);
        public static void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public static void multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public static void divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }

    }

    class DgateFunc {
        //Q2.Func Delegate
            public static int add(int a, int b)
        {
            return a + b;
        }
        public static int subtract(int a, int b)
        {
            return (a - b);
        }
        public static int multiply(int a, int b)
        {
            return (a * b);
        }
        public static int divide(int a, int b)
        {
            return (a / b);
        }
    }


}