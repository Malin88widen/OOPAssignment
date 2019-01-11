using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{

    public class Shop : Interface //I use the interface to make a rule for the class that I want theese propertys to be in the class for it to work.
    {

        public string Name { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Item { get; set; }

        public Shop() { }

        public Shop(string firstName, string lastName) 
        {
            Name = firstName;
            LastName = lastName;
        }

        protected string GetFullName()
        {
            return string.Format("{0} {1}", Name, LastName);
        }

        public void Black()
        {
            Console.WriteLine("Thank you. You put a " + Item + " with the color of " + ChooseColor.black + " in your shopping bag!"); //I use the enum to pick the color I want on the Item. 
        }

        public void White()
        {
            Console.WriteLine("Thank you. You put a " + Item + " with the color of " + ChooseColor.white + " in your shopping bag!"); 
        }

        public void Beige()
        {
            Console.WriteLine("Thank you. You put a " + Item + " with the color of " + ChooseColor.beige + " in your shopping-bag!");
        }
       
        //Improvement - to make different enums so that I only see the colors that are avaiable for that specifik item!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public void getShop(Int32 shopID)
        {

            switch (shopID)
            {
                case 1:
                    Black();
                    break;
                case 2:
                    White();
                    break;
                case 3:
                    Beige();
                    break;
                
            }
        }

    }

}

