using Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Repositories
{
    public class ProductRepository
    {
        // declare field of type DataContext
        DataContext dc;

        public ProductRepository(DataContext dc)
        {
            //initialize the DataContext field with parameter passed
            this.dc = dc;
            
        }

        /*
         * this method should accept product data and add it to the product collection
         * 
         */
        public void AddProduct(Product product)
        {
            // code to add product to file, ensuring that product is not null
            if (product != null)
            {
                dc.AddProduct(product);
                dc.SaveChanges();
            }

        }


        /*
         * this method should search for the product by the provided product id 
         * and if found should remove it from the collection
         * 
         * the method should return true for success and false for invalid id 
         */
        public bool RemoveProduct(int pro_id)
        {
            // code to remove product by the id provided from file as parameter
            var products = dc.ReadProducts();
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].ProductId == pro_id) 
                {
                    products.RemoveAt(i);
                    dc.SaveChanges();
                    return true;
                }

            }
            return false;   
        }

        /*
         * this method should search and return product by product name from the file 
         * 
         * the search value should be passed as parameter
         * 
         * the method should return null for non-matching product name
         */
        public Product GetProduct(string name)
        {
            var products = dc.ReadProducts();
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].ProductName ==name)
                {

                    return products[i];
                }

            }
            return null;

        }

        /*
         * this method should search and return product by product id from the collection 
         * 
         * the search value should be passed as parameter
         * 
         * the method should return null for non-matching product id
         */
        public Product GetProduct(int id)
        {
            var products = dc.ReadProducts();
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].ProductId == id)
                {

                    return products[i];
                }

            }
            return null;

        }

        
        /*
         * this method should return all items from the product collection
         */
        public List<Product> GetAllProducts()
        {
            return dc.ReadProducts();
        }
    }
}
