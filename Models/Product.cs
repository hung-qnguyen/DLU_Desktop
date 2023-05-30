using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public ProductSize Size { get; set; }

        public ProductColor Color { get; set; }

        public enum ProductSize
        {
            Small,
            Medium,
            Large,
            VeryLarge
        }
        public enum ProductColor
        {
            Red,
            Green,
            Blue,
            White,
            Black
        }

    }
}
