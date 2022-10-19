using static delegateAss1_part2.Dgate;

namespace delegateAss1_part2
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Enter employee id");
            string empid = Console.ReadLine();

            Dgate dgate = new Dgate();
            //Q3 . 
            //AttendenceLogHandler attendenceLogHandler = new AttendenceLogHandler(dgate.createLog);
            //attendenceLogHandler += dgate.markAttendence;
            //attendenceLogHandler.Invoke(empid);
            
            //Q4 . Action Delegate
            Action<string> val1 = dgate.createLog;
            Action<string> val2 = dgate.markAttendence;
            val1(empid);
            val2(empid);
        }
    }

    class Dgate
    {
        public delegate void AttendenceLogHandler(string empid);
        public void createLog(string empid)
        {
            FileStream fs = null;
            if (!File.Exists(($"./{empid}.txt")))
            {
                fs = new FileStream($"./{empid}.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.Close();
                fs.Close();
                Console.WriteLine("File Created");
            }
            else
            {
                Console.WriteLine("File already exists");
            }
        }
        public void markAttendence(string empid)
        {
            FileStream fs = null;
            
            fs = new FileStream($"./{empid}.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine($"{empid} has marked the attendence on {DateTime.Now}");
            sw.Close();
            fs.Close();
            Console.WriteLine("Attendence Marked");
        }
    }
}