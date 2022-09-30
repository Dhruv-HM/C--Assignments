using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace corporateRulesInterfaceAss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TCS tcs1 = new TCS(1223,"ramu", "sales","manager",25000);
            Accenture acc1 = new Accenture(1223, "ramu", "sales", "manager", 25000);

            Console.WriteLine($"employee pf: {tcs1.employeePF(tcs1.basicSalary)}");
            Console.WriteLine($"gratuity amount: {tcs1.gratuityAmount(6,tcs1.basicSalary)}");
            Console.WriteLine($"employee pf: {acc1.employeePF(acc1.basicSalary)}");
            Console.WriteLine($"gratuity amount: {acc1.gratuityAmount(6, acc1.basicSalary)}");
        }
    }
    interface CorporateRules
    {
         double employeePF(double basicSalary);
         double gratuityAmount(int serviceCompleted, double basicSalary);
    }
    class TCS : CorporateRules
    {
        int empid { get; set; }
        string empname { get; set; }
        string dept { get; set; }
        string desgn { get; set; }
        public double basicSalary { get; set; }
        public TCS(int empid, string empname, string dept, string desgn, double basicSalary)
        {
            this.empid = empid;
            this.empname = empname;
            this.dept = dept;
            this.desgn = desgn;
            this.basicSalary = basicSalary;
        }

        public double employeePF(double basicSalary) {
            double pf1 = 0.12 * basicSalary;
            double pf2= 0.0833*basicSalary;
            double pft=pf1+ pf2 + 0.0367*basicSalary;
            return pft;

        }
        public double gratuityAmount(int serviceCompleted, double basicSalary) {
            double gratuity;
            if (serviceCompleted >5 && serviceCompleted<=10)
            {
                gratuity = basicSalary;
            }
            else if (serviceCompleted >10 && serviceCompleted <= 20)
            {
                gratuity=basicSalary*2;
            }
            else if (serviceCompleted > 20)
            {
                gratuity = 3 * basicSalary;
            }
            else
            {
                gratuity = 0;
            }
            return gratuity;
        }
    }
    class Accenture : CorporateRules
    {
        int empid { get; set; }
        string empname { get; set; }
        string dept { get; set; }
        string desgn { get; set; }
        public double basicSalary { get; set; }
        public Accenture ( int empid, string empname, string dept, string desgn, double basicSalary)
        {
            this.empid = empid;
            this.empname = empname;
            this.dept = dept;
            this.desgn = desgn;
            this.basicSalary = basicSalary;
        }

        public double employeePF(double basicSalary)
        {
            double pf1 = 0.12 * basicSalary;
            double pf2 = 0.12 * basicSalary;
            double pft = pf1 + pf2;
            return pft;

        }
        public double gratuityAmount(int serviceCompleted, double basicSalary)
        {
            double gratuity;
            if (serviceCompleted > 5 && serviceCompleted <= 10)
            {
                gratuity = basicSalary;
            }
            else if (serviceCompleted > 10 && serviceCompleted <= 20)
            {
                gratuity = basicSalary * 2;
            }
            else if (serviceCompleted > 20)
            {
                gratuity = 3 * basicSalary;
            }
            else
            {
                gratuity = 0;
            }
            return gratuity;
        }
    }



}
