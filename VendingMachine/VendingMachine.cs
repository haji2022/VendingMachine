using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VendingMachine1
{
    public class VendingMachine : IVendingMachine
    {

        //1: Money Pool.

        public int[] validDenomination = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 };
        public int amountOfMoneyInVendingMachine = 0;
        public int LatestBoughtProduct { get; set; }
        public List<Product> products = new List<Product>();


        public VendingMachine()
        {
            //Welcome Message
            WelcomeMessage();
            //Initialize the Items
            InitilizeProducts();
        }




        public void WelcomeMessage()
        {
            System.Console.WriteLine("Welcome to Hajis Vending Machine");
        }

        public void InitilizeProducts()
        {
            //Drink: 2
            Drink PowerRade = new Drink(1, "Powerrade Lemon", 50, 1, "Powerrade is a inner sports gear to Power your Performance");
            products.Add(PowerRade);
            Drink Celcius = new Drink(2, "Celcius Lemon", 35, 1, "Celcius is a drink for maximazing your performance");
            products.Add(Celcius);
            
            //Snacks: 2
            Snack OWL = new Snack(3, "SourceCreme OWL", 15, 2, "OWL is for the ones who likes to Share");
            products.Add(OWL);
            Snack Extrella = new Snack(4, "SourceCreme Extrella", 15, 2, "Extrella is for the ones who likes to Share");
            products.Add(Extrella);
          
            //Candy: 2
            Candy LollipopGinger = new Candy(5, "Lollipop Ginger", 2, 1, "Make your tounge Green With our Special Lollipop");
            products.Add(LollipopGinger);
            Candy LollipopRed = new Candy(6, "Lollipop Red", 2, 1, "Make your tounge Red With our Special Lollipop");
            products.Add(LollipopRed);
            
        }

        public void ClearVendingMachineMoney()
        {
            amountOfMoneyInVendingMachine = 0;
        }





        public bool Purchase(int choiceOfProduct)
        {
            //Check if product is inside
            if (products.Any(product => product.Id == choiceOfProduct))
            {

            Product foundProduct = products.Where(product => product.Id == choiceOfProduct).First();
         
            //purchase the product 
            if (amountOfMoneyInVendingMachine >= foundProduct.Price)
            {    
                //if (foundProduct = Drink)
                //{
                //    Console.WriteLine("energetic drink");
                //}
                //print the product
                // Console.WriteLine($"Product Name: {foundProduct.Name} And COST = {foundProduct.Price} Kr");
                foundProduct.Examine();
                    Console.WriteLine("Would youlke to use the product? (y/n)");
                    if (Console.ReadKey().KeyChar=='y')
                    {
                        foundProduct.Use();
                    }

                //Helper Method PrintUsage(Product product)
                PrintUsage(foundProduct);
                //decrease the amount
                DecreaseTheMoneyPoolAmount(foundProduct);
                return true;

            }
            }
            else
            {
                Console.WriteLine("Sorry the amount of money is less");
            }

            return false;


            //and decrease the moneyPool


            // throw new NotImplementedException();
        }

        private void PrintUsage(Product foundProduct)
        {
            foundProduct.Use();
        }

        private void DecreaseTheMoneyPoolAmount(Product foundProduct)
        {
            amountOfMoneyInVendingMachine -= foundProduct.Price;
            if (amountOfMoneyInVendingMachine <= 0)
            {
                amountOfMoneyInVendingMachine = 0;
            }
        }



        public void InsertMoney()
        {
            Console.WriteLine("Please Insert The Amount");
            Console.WriteLine("OBS: You can only insert the following values\n1kr, 5kr, 10kr, 20kr, 50kr, 100kr, 500kr, 1000kr");

            int amountEntered = int.Parse(Console.ReadLine());
            
            if (amountEntered != null)
            {
                Insert(amountEntered);
                //check if the value of user is corresponding to the valid denominations¨
               



            }

        }

        public void Insert(int amountEntered)
        {
            bool isValid = CheckValidDenomination(amountEntered);

            if (isValid)
            {
                //Add the money into the money pool: 
                amountOfMoneyInVendingMachine += amountEntered;

            }
        }

        public bool CheckValidDenomination(int price)
        {
            bool result = validDenomination.Any(validDenom => validDenom == price);
            return result;
        }

        public void ShowAll()
        {
            for (int i = 0; i < products.Count; i++)
            {
                Product product = products[i];
               Console.WriteLine($"Id:{product.Id} {product.Name} Price = {product.Price} kr Description: {product.Description}");
               
            }
        }




        
        public void EndTransaction()
        {
            

                int noOfDenomination = 0;
                for (int i = validDenomination.Length-1; i >=0 ; i--)
                {
                    if (amountOfMoneyInVendingMachine >= validDenomination[i])
                    {
                        noOfDenomination = amountOfMoneyInVendingMachine / validDenomination[i];
                        Console.WriteLine($"{noOfDenomination} x {validDenomination[i]} kr" );
                        amountOfMoneyInVendingMachine = amountOfMoneyInVendingMachine % validDenomination[i];
                     
                      
                
                    }
                }
            //    Console.WriteLine("The amount of change you will receive after purchasing is: " + amountOfMoneyInVendingMachine + " kr");
            //return amountOfMoneyInVendingMachine;

        }
    }
}
