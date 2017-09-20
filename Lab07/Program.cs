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
            var product = new List<string>() { "Shirts", "Shoes", "Pants", "Ties", "Hats", "Gloves", "Socks", "Wallets", "Purses", "Sunglasses" };
            foreach(string item in product)
            {
                Console.WriteLine("Item: " + item) ;
            }
                Console.Read()

        }


    }
}
