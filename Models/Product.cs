using System;

namespace TechStore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public decimal CalculateTax()
        {
            return Price * 0.18m; // Impuesto del 18%
        }
    }
}
