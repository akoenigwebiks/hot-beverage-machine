using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hot_beverage_machine
{
    /*
     *     <name>שוקו</name>
    <sugar>1</sugar>
    <milk>0.5</milk>
    <cocoa>2</cocoa>
    <coffee>1.5</coffee>
    <price>2.9</price>
     */
    internal class DrinkDTO
    {
        public string Name { get; set; }
        public string Sugar { get; set; }
        public string Milk { get; set; }
        public string Cocoa { get; set; }
        public string Price { get; set; }
        public string Coffee { get; set; }

        public DrinkDTO(string name, string price, string sugar, string milk, string cocoa, string coffee)
        {
            Name = name;
            Price = price;
            Sugar = sugar;
            Milk = milk;
            Cocoa = cocoa;
            Coffee = coffee;
        }
    }
}
