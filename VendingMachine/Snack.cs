using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine1
{
    
    
        public class Snack : Product
        {
            public Snack(int _id, string _name, int _price, int _weight, string _description)
            {
                this.Id = _id;
                this.Price = _price;
                this.Name = _name;
                this.Weight = _weight;
                this.Description = _description;
            }
            public override void Examine()
            {
                System.Console.WriteLine($"Product Name: {this.Name}: Product Price: {this.Price}kr Description: {this.Description}");

            }

            public override void Use()
            {
                Console.WriteLine("Make sure to Eat it cautiously and share it with others :)");
            }
        }
    
}
