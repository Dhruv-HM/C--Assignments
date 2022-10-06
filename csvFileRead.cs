using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csv_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("C:/stackroute_assignments/products.txt", FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string data = sr.ReadLine();
            
            while (!String.IsNullOrEmpty(data))
            {
                //Console.WriteLine(data);
                string[] strings = data.Split(',');
                int slno=int.Parse(strings[0]);
                string product=strings[1];
                int price=int.Parse(strings[2]);
                products pro = new products(slno,product,price);
                update(pro);
                Console.WriteLine(data);
                data = sr.ReadLine();
            }
            
            fs.Close();
            sr.Close();

        }

        static void update(products pro)
        {
            FileStream fs = new FileStream("C:/stackroute_assignments/updated_products.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            if (pro.price<1000)
            {
                pro.price = pro.price + 50;
            }else if (pro.price > 1000)
            {
                pro.price+=1000;
            }
           
            sw.WriteLine(pro.slno+pro.product + + pro.price);
            sw.Close();
            fs.Close();
        }
    }
    public class products
    {
        public int slno;
        public string product;
        public int price;
        public products(int slno, string product, int price)
        {
            this.slno = slno;
            this.product = product;
            this.price = price;
        }
    }


}
