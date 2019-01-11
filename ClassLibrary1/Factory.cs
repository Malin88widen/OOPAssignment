using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
   public class Factory
    {
        public static Shop getShop(Int32 ShopID)
        {
            Shop retval = null;

            switch (ShopID)
            {
                case 1:
                    retval = new Livingroom();
                    break;
                case 2:
                    retval = new Kitchen();
                    break;
                case 3:
                    retval = new Bedroom();
                    break;
                
            }

            return retval;
        }
    }
}
