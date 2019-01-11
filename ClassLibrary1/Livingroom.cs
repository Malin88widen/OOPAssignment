using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Livingroom : Shop //Inheritance because it´s less code. DRY.
    {
        public Livingroom()
        {
            Item = "Couch";     
        }

    }
}

