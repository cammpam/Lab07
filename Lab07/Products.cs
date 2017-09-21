using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class Products
    {       
        public int Quantity { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public Season Gear { get; set; }



        public Products(string brand)
        {
            Brand = brand;
        }

        public bool InSeason()
        {
            if (Gear == Season.Spring || Gear == Season.Summer)
            {
                return false;
            }
            return true;
        }

        public string WaterResistant(string material)
        {
            if (Gear == Season.Winter || Gear == Season.Fall)
            {
                return $"All {material} jackets are 100% waterproof!";
            }
            return $"All {material} jackets are 100% breathable!";

    }

    }
    enum Season : int
    {
        Winter = 1,
        Spring,
        Summer,
        Fall
    }
}
