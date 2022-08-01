using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine1
{
    public abstract class Product
    {
        public int Id;
        public string Name = "";
        public int Price = 0;
        public int Weight = 0;
        public string Description = "";
        public string Massage = "";


        public abstract void Examine();
        public abstract void Use();

    }
}
