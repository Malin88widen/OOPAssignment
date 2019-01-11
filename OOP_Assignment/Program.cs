using System;
using System.Collections.Generic;
using ClassLibrary1;
using OOP_Assignment;
using static ClassLibrary1.Kassa_Polymorphism; 

namespace OOP_Assignment
{
    class Program 
    {

        static void Main(string[] args)
        {
            //Overloaded Constructor. For example to write out the customers name that they put in before this. For this example I put in a name.
            var customer = new Customer("Greta", "Garbo");

            System.Console.WriteLine("Welcome {0} {1}.",
                customer.Name,
                customer.LastName);

            System.Console.WriteLine("What item do you wish to put in your shopping-bag, {0}?", customer.FullName);
            Console.WriteLine(" ");


            // This is a while loop that makes alternatives to put in your shopping-bag.

            while (true)
            {

                Console.WriteLine("1. Coutch");
                Console.WriteLine("2. Chair");
                Console.WriteLine("3. Bed");
                Console.WriteLine(" ");

                Int32 answer = Int32.Parse(Console.ReadKey(true).KeyChar.ToString());


                Shop shop = Factory.getShop(answer);

                Console.WriteLine("Choose a color on your " + shop.Item + ":");

                Console.Write("1."); Console.WriteLine(ChooseColor.black); 
                Console.Write("2."); Console.WriteLine(ChooseColor.white); //using enum to make it easier for me to write out the colors for the customer to choose from.
                Console.Write("3."); Console.WriteLine(ChooseColor.beige);
             
                Console.WriteLine(" ");

                answer = Int32.Parse(Console.ReadKey(true).KeyChar.ToString());

                shop.getShop(answer);
                Console.WriteLine(" ");
                Console.WriteLine("Your shopping-bag is full. Your order will arrive soon.");
                Console.WriteLine("Press any key to exit.");

                Console.ReadKey();
                break;

            }

            //I decide to use polymorphism so that i can use the same code on all the orderd objects.

            var cheer = new Cheer();
            cheer.Kassa();  

            var table = new Table();
            table.Kassa();

            Kassa_Polymorphism kassa_polymorphism = cheer;
            kassa_polymorphism.Kassa();
            
            // and so on if you want to add some more objects with this function.

        }

    }
}

