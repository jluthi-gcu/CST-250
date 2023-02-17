using CarsClassLibrary;
using System.Drawing;

namespace CarShopConsoleApp
{
    internal class Program
    {
        static Store CarStore = new Store();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the car store. First you must create some cars and put them " +
                "into the store inventory. Then you may add cars to the cart. Finally, you may checkout, which will calculate your total bill. ");

            int action = chooseAction();

            while (action != 0)
            {
                // Add case statements and actions here.
                switch (action) 
                { 
                
                    case 1:
                        
                        // You chose add a car
                        Console.Out.WriteLine("\nYou chose to add a new car to the store: ");

                        // ask for three property details.
                        String carMake = "";
                        String carModel = "";
                        Decimal carPrice = 0;
                        string color = "";
                        int miles = 0;

                        Console.Out.WriteLine("What is the car make? Ford, GM, Toyota, etc.: ");
                        carMake = Console.ReadLine();

                        Console.Out.WriteLine("What is the car model? Corvette, Focus, Ranger, etc.: ");
                        carModel = Console.ReadLine();

                        // Error handling
                        do
                        {
                            try
                            {
                                Console.Out.WriteLine("What is the car price? Only numbers please greater than zero allowed: ");
                                carPrice = decimal.Parse(Console.ReadLine());

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Only numbers and numbers that are > 0 are allowed. Please try again.");
                            }

                            // Keep prompting user until they enter a valid choice. We aren't giving it a way for free nor are we a charity. 
                        } while (carPrice <= 0);




                        Console.Out.WriteLine("What is the car's color? Black, White, Blue, etc.: ");
                        color = Console.ReadLine();



                        // Error handling for custom field prompt - miles.
                        do
                        {
                            try
                            {
                                Console.Out.WriteLine("What is the car miles? Only numbers please that are >= to 0 allowed: ");
                                miles = int.Parse(Console.ReadLine());

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Only numbers and numbers that are >= 0 are allowed. Please try again.");
                            }

                            // Keep prompting user until they enter a valid choice.
                        } while (miles < 0);



                        // create a new car object and add it to the list
                        Car newCar = new Car();
                        newCar.Make = carMake;
                        newCar.Model = carModel;
                        newCar.Price = carPrice;
                        newCar.Color = color;
                        newCar.Miles = miles;

                        CarStore.CarList.Add(newCar);
                        printStoreInventory(CarStore);
                        break;

                    case 2:
                        // You chose add item to cart

                        // display the list of cars in inventory
                        printStoreInventory(CarStore);


                        // ask for a car number to purchase
                        // Updated with error handling
                        int choice = -1;
                        do
                        {
                            try
                            {
                                Console.Out.Write("\nWhich car would you like to add to the cart? (number): ");
                                choice = int.Parse(Console.ReadLine());

                                // If out of excepted value range, display message.
                                if (choice < 0 || choice >= CarStore.CarList.Count)
                                {
                                    choice = -1;
                                    Console.WriteLine("Choice out of range. Please try again.");
                                }
                            }
                            catch (Exception e)
                            {
                                choice = -1;
                                Console.WriteLine("Only numbers allowed. Please try again.");
                            }

                            // Keep prompting user until they enter a valid choice.
                        } while (choice == -1);


                  

                        // add the car to the shopping cart
                        CarStore.ShoppingList.Add(CarStore.CarList[choice]);

                        printShoppingCart(CarStore);


                        break;

                    case 3:
                        // checkout
                        printShoppingCart(CarStore);
                        Console.Out.WriteLine("Your total cost is ${0}", CarStore.checkout());

                        break;

                    default:
                        break;

                
                }



                action = chooseAction();

            }


        }

        public static int chooseAction()
        {
            // Updated to display message to user if user's input is invalid

            int choice = -1;
            do
            {
                try
                {
                    Console.Out.Write("\nChoose an action (0) quit (1) add a car (2) add item to cart (3) checkout: ");
                    choice = int.Parse(Console.ReadLine());

                    // If out of excepted value range, throw error which will cause catch to be executed.
                    if (choice < 0 || choice > 3)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception e)
                {
                    choice = -1;
                    Console.WriteLine("Invalid action. Please try again.");
                }

                // Keep prompting user until they enter a valid choice.
            } while (choice == -1);
    



            return choice;


        }


        public static void printStoreInventory(Store carStore)
        {
            Console.Out.WriteLine("These are the cars in the store inventory: ");
            int i = 0;

            foreach (var c in carStore.CarList)
            {
                Console.Out.WriteLine(String.Format("Car # = {0} {1}", i, c.ToString()));
                i++;
            }

        }


        public static void printShoppingCart(Store carStore)
        {
            Console.Out.WriteLine("These are the cars in your shopping cart: ");
            int i = 0;

            foreach (var c in carStore.ShoppingList)
            {
                Console.Out.WriteLine(String.Format("Car # = {0} {1}", i, c.ToString()));
                i++;
            }

        }



    }
}