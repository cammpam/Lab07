using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class Program
    {
        static void Main(string[] args)
        {
            Store<Products> storeFront = new Store<Products>();

            Products jacket = new Products("Northface");
            Products pants = new Products("Levi");
            Products shirt = new Products("Ralph Lauren");
            Products hat = new Products("Kangoo");
            Products shoes = new Products("Adidas");

            storeFront.Add(jacket);
            storeFront.Add(pants);
            storeFront.Add(shirt);
            storeFront.Add(hat);
            storeFront.Add(shoes);

            foreach(Products p in storeFront)
            {
                Console.WriteLine(p.Brand);
            }
            Console.WriteLine();

            storeFront.Remove(shirt);

            foreach(Products p in storeFront)
            {
                Console.WriteLine(p.Brand);
            }


            Console.Read();
        }

    }
}
