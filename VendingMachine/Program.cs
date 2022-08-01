
using VendingMachine1;
internal class Program1
{
    private static void Main(string[] args)
    {
        VendingMachine vm = new VendingMachine();

        Console.WriteLine("Do you wish to buy a product?\nPress 1 To Buy A Product || Press 2 To End The Process");

        int choice = int.Parse(Console.ReadLine());


        bool resultOfUserAnswer = choice == 1 ? true : false;

        if (resultOfUserAnswer)
        {


            //1: Add money inside the vendingMachine
            vm.InsertMoney();

            //print amount of money in vendingMachine;
            Console.WriteLine("Amount of Money inside the Machine: " + vm.amountOfMoneyInVendingMachine + " kr");

            //2: show products.
            while (true)
            {

                vm.ShowAll();
                Console.WriteLine("-------------------------------------------------");

                //3: Choose Products.
                Console.WriteLine("Please choose a product you would like to buy:");
                int productChoice = int.Parse(Console.ReadLine());
                vm.Purchase(productChoice);
               

            

                Console.WriteLine("Would you like to continue Purchasing?");
                Console.WriteLine("Press 1: To Continue\n Press 2: To Stop the process");
                int continueProcess = int.Parse(Console.ReadLine());
                if (continueProcess == 1)
                {
                    continue;
                }
                else { 
                    vm.EndTransaction();
                    break;
                }

                
            }




            //2B: Ask if he is sure to continue


            //3: Get the balance back
            //vm.EndTransaction();

        }






    }
}