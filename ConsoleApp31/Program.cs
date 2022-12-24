using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price = 750;
            Console.WriteLine("Введите стоимость вашей покупки:");
            double.TryParse(Console.ReadLine(), out price);
            if (price > 400 && price < 600) price = price - price * .05;
            else if (price >= 600 && price < 1000) price = price - price * .1;
            Console.WriteLine($"Цена вашей покупки со скидкой: {price}");

            Console.Read();
        }
    }
}
