using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    /*
     * this serializable class models product data that includes product id, product name, price and in-stock status
     */
    [Serializable]
    public class Product
    {
        /*
         * define properties for Product model attributes 
         */
        public int ProductId { get; set; }
        public int Price { get; set; }
        public string ProductName { get; set; }
        public bool InStock { get; set; }

        public Product()
            {
            
            }
        public Product(int ProductId,string ProductName, int Price, bool InStock=true)
        {
            this.ProductId = ProductId;
            this.ProductName = ProductName;
            this.Price = Price;
            this.InStock = InStock;
        }




    /*
     * Override ToString() method to return string equivalent of product object containing product details
     */

    public override string ToString()
        {
            return $"Product Name: {this.ProductName},Price: {this.Price}, Instock: {this.InStock}";
        }
    }
}
