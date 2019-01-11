using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    interface Interface //Interface so that I don´t miss anything important in the Shop-class.
    {
        String Item { get; set; }

        String Name { get; set; }

        String LastName { get; set; }

        Int32 Age { get; set; }

    }
}
