using System;
using Activity_1;

namespace Program
{
    class Program

    {
        private static void Main(string[] args)
        {
            Order ord = new Order();
            Product num1 = new Product();
            num1.price = 20000M;
            num1.quantity = 4;
            num1.title = "Motocycle";
            num1.description = "Speed and comfortable";
            num1.discount = 20;
            num1.code = "827512";

            Product num2 = new Product();
            num2.price = 15000M;
            num2.quantity = 3;
            num2.title = "TV";
            num2.description = "You can watch movies";
            num2.discount = 17;
            num2.code = "767123";

            ord.addProduct(num1);
            ord.addProduct(num2);
            Console.WriteLine("Quantity of " +num1.title+": "+ num1.quantity);
            Console.WriteLine("Quantity of "+num2.title+": " + num2.quantity);
            Console.WriteLine("Products: " + ord.total);
            ord.totalP();
            Console.WriteLine("Tot: " + ord.totalPrice);
        }
    }
}