using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
   public class Bedroom : Shop // Inheritance so that it´s less code. DRY.
    {
        public Bedroom()
        {
            Item = "Bed";
        }  
    } 
}

