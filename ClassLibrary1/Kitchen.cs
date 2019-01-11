using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Kitchen : Shop //Inheritance because it´s less code. DRY.
    {
        public Kitchen()
        {
            Item = "Chair";
        }

    }
}
