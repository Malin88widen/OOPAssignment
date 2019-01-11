using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Kassa_Polymorphism
    {
  
        public class Table : Kassa_Polymorphism
        {
           
        }

        public class Cheer : Kassa_Polymorphism
        {

        }

        public bool Kassa()
        { 
            return true;
        }  
        //I decide to use polymorphism so that i can use the same code on all the orderd objects. 
    }
}
