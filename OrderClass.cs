using System;
using System.Collections.Generic;
namespace CRM
{
    public interface IPrototype<T>
    {
        T Clone();
    }

    public class OrderClass : IPrototype<OrderClass>
    {
        public DateTime Date { get; set; }
        public decimal TotalAmount { get; set; }
        public string DeliveryAddress { get; set; }
        public string PaymentToken { get; set; }
        public bool IsPaid { get; set; }
        public List<ProductClass> Products { get; set; }

        public OrderClass(DateTime date, decimal totalAmount, string deliveryAddress, string paymentToken, bool isPaid, List<ProductClass> products)
        {
            Date = date;
            TotalAmount = totalAmount;
            DeliveryAddress = deliveryAddress;
            PaymentToken = paymentToken;
            IsPaid = isPaid;
            Products = products;
        }

        public OrderClass Clone()
        {
            List<ProductClass> copiedProducts = new List<ProductClass>();
            foreach (var product in Products)
            {
                copiedProducts.Add(product.Clone());
            }

            return new OrderClass(
            DateTime.Now,
            TotalAmount,
            DeliveryAddress,
            null,
            false,
            copiedProducts);          
        }


        public void PrintOrderDetails()
        {

            Console.WriteLine($"Дата: {Date}");
            Console.WriteLine($"Загальна сума: {TotalAmount}");
            Console.WriteLine($"Адреса доставки: {DeliveryAddress}");
            Console.WriteLine($"Оплачено: {IsPaid}");
            Console.WriteLine($"Токен платежу: {PaymentToken ?? "Відсутній"}");
            Console.WriteLine("Продукти:");
            foreach (var product in Products)
            {
                Console.WriteLine($"- {product.Name}, Ціна: {product.Price}, Кількість: {product.Manufacturer}");
            }
        }


    }

}

