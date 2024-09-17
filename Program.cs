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
                DateTime.Now,
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
        }
    }
}4