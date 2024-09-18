//Варіант 10 - Ковач Роман
//Розробити метод CRM для копіювання замовлення користувача
//(Дата, сума замовлення, адреса доставки, секретний токен оплати,
//стан оплати (так/ні),
//список товарів, де кожен Товар - об'єкт (Назва, ціна, виробник)).
//Врахувати що копія замовлення завжди повинна бути неоплаченою.

using System;
using System.Collections.Generic;

namespace CRM
{
    class Program
    {
        public static void Main()
        {
            List<ProductClass> products = new List<ProductClass>
            {
                new ProductClass("Laptop", 1500, "Apple"),
                new ProductClass("Mouse", 250, "HyperX")
            };

            OrderClass originalOrder = new OrderClass(
                1552,
                "123 Main St, Springfield",
                "payment_token_12345",
                true,
                products
            );

            Console.WriteLine("Оригінальне замовлення:");
            originalOrder.PrintOrderDetails();

            OrderClass copiedOrder = originalOrder.Clone();

            Console.WriteLine("\nСкопійоване замовлення:");
            copiedOrder.PrintOrderDetails();

            copiedOrder.Products[0].Name = "Smartphone";
            copiedOrder.Products[0].Price = 1000;
            copiedOrder.DeliveryAddress = "456 Elm St, Shelbyville";

            Console.WriteLine("\nОригінальне замовлення після змін:");
            originalOrder.PrintOrderDetails();

            Console.WriteLine("\nЗмінене копійоване замовлення:");
            copiedOrder.PrintOrderDetails();

        }
    }
}