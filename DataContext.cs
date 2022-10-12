using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Repositories
{
    // this class provides functionalities to read and write product collection data with file

    public class DataContext
    {
        // declare field for filename with path
        // declare field for list of products

        List<Product> products;
        static string folder = "test";
        static int rootPosition = Environment.CurrentDirectory.IndexOf("bin");
        string path = Environment.CurrentDirectory.Substring(0, rootPosition - folder.Length - 1);
        string filename = "products.dat";


        // the constructor should accept filename and path strings
        public DataContext(string filename,string path)
        {
            // the constructor code should open file if it exists else create new
            if(File.Exists(path+filename))
            {
                FileStream fs = null;
                fs = new FileStream(path + filename, FileMode.Open, FileAccess.Read);

                // the code should read data from file if it contains any data
                BinaryFormatter formatter = new BinaryFormatter();
                object objs = formatter.Deserialize(fs);
                products = (List<Product>)objs;
                fs.Close();
            }


            //if file is not there create a new one
            else
            { 
            FileStream fs = null;
            fs = new FileStream(path+filename, FileMode.Create, FileAccess.Write);
            fs.Close ();    
            products = new List<Product>();
            }

            // the code should read data from file if it contains any data
            

            // the data read should populate the list of products field
            


            // if no data is present an empty list should be created
            

        }

        // this method should return the list of products read from file
        public List<Product> ReadProducts()
        {
            // return data of the product list
            return products;
        }

        // this method should add the product data passed as parameter to the list of products
        public void AddProduct(Product product)
        {
            products.Add(product);
            SaveChanges();

            
        }

        // this method should write the data from list of products to file and make data persistent
        public void SaveChanges()
        {
            // implement serialization
            FileStream fs = null;
            fs = new FileStream(path + filename, FileMode.Append, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, products);
            fs.Close();

        }

        // this method should delete the file if exists
        public void CleanUp()
        {
            if(File.Exists(path+filename))
            {
                File.Delete(path+filename);
            }
        }
    }
}
