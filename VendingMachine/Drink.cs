using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine1
{
    public class Drink : Product
    {

        public Drink(int _id, string _name, int _price, int _weight, string _description)
        {
            this.Id = _id;
            this.Name = _name;
            this.Price = _price;
            this.Weight = _weight;
            this.Description = _description;
        }
        public override void Examine()
        {
            System.Console.WriteLine($"Product Name: {this.Name}: Product Price: {this.Price}kr Description: {this.Description}");

        }

        public override void Use()
        {
            Console.WriteLine("Make sure to drink it slowly to taste it better");
        }
    }
}
