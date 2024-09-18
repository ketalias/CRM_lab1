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
        protected string PaymentToken { get; set; }
        protected bool IsPaid { get; set; }
        public List<ProductClass> Products { get; set; }

        public OrderClass(decimal totalAmount, string deliveryAddress, string paymentToken, bool isPaid, List<ProductClass> products)
        {
            Date = DateTime.Now;
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
                Console.WriteLine(product.ToString());
            }
        }
    }
}

