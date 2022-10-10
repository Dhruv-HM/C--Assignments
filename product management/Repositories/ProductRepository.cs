using Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public class ProductRepository
    {
       // declare field to store collection of products
       List<Product> products;

        public ProductRepository(List<Product> products_in)
        {
            //initialize the collection field with parameter passed
            products = products_in;
            
        }

        /*
         * this method should accept product data and add it to the product collection
         * 
         */
        public void AddProduct(Product pro)
        {
            // code to add product to product collection, ensuring that product is not null
            if (pro != null)
            {
                products.Add(pro);
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
            // code to remove product by the id provided as parameter
            for (int i = 0; i < products.Count; i++)
            {
                
                Product pro = products[i];
                if(pro.ProductId == pro_id)
                {
                    products.RemoveAt(i);
                    return true;
                   
                    
                }
            }
            return false;
            
        }


        /*
         * this method should search and return product by product name from the collection 
         * 
         * the search value should be passed as parameter
         * 
         * the method should return null for non-matching product name
         */
        public Product GetProduct(string pro_name)
        {
            for (int i = 0; i < products.Count; i++)
            {
                Product p = products[i];
                if (p.ProductName == pro_name)
                {
                    return p;
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
        public Product GetProduct(int pro_id)
        {
            for (int i = 0; i < products.Count; i++)
            {
                Product p = products[i];
                if (p.ProductId== pro_id)
                {
                    return p;
                }
            }
            return null;
        }


        /*
         * this method should return all items from the product collection
         * 
         */
        public List<Product> GetAllProducts()
        {
            return products;
        }
    }
}
