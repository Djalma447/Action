using System;
using System.Collections.Generic;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            Action<Product> act = p => { p.Price += p.Price * 0.1; }; // Como é uma 'Ação (Action)', deve ser feita entre 'chaves', para indicar que a expressão tem um corpo, mas é um void (Não retorna nenhum valor)

            list.ForEach(act);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}
