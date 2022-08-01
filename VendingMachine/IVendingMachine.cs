using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine1
{
    
    
        public interface IVendingMachine
        {
            bool Purchase(int choiceOfProduct);
            void ShowAll();
            void InsertMoney();
            void EndTransaction();
        }

    
}
