using System;
using System.Collections.Generic;
using System.Text;

namespace Sparcpoint.Models
{
    public class ProductSearchCriteria
    {
        public string Name { get; set; }
        public string SKU { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }

        // Constructor to initialize criteria
        public ProductSearchCriteria(string name, string sku, string color, string brand)
        {
            Name = name;
            SKU = sku;
            Color = color;
            Brand = brand;
        }

        // Method to check if criteria are specified
        public bool HasCriteria()
        {
            return !string.IsNullOrEmpty(Name) || !string.IsNullOrEmpty(SKU) ||
                   !string.IsNullOrEmpty(Color) || !string.IsNullOrEmpty(Brand);
        }
    }
}
