using System;
using System.Collections.Generic;
using System.Text;

namespace Sparcpoint.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SKU { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public int Inventory { get; set; }
    }
}
