using System;
using System.Collections.Generic;
namespace CRM {

    public class ProductClass : IPrototype<ProductClass>
    {
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Manufacturer { get; set; }

        public ProductClass(string name, decimal price, string manufacturer)
        {
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
        }
    
        public ProductClass Clone()
        {
            return new ProductClass(Name, Price, Manufacturer);
        }

        public override string ToString()
        {
            return $"Товар: {Name}, Ціна: {Price}, Виробник: {Manufacturer}";
        }


    }
}
