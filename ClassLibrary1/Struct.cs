using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public struct Struct //This is a struct to make a mesurment on the furniture and/or shipping cost depending on the size. 
    {
        public int H { get; set; }

        public int L { get; set; }

        public int HeightAndLength()
        {
            return H * L; 
        }

        
    }

    
}
