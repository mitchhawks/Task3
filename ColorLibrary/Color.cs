using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorLibrary
{
    /// <summary>  
    ///  This class stores information relating to the hex code of a colour.  
    /// </summary>  
    class Colour
    {
        public string colourHex { get; set; }

        public Colour(string hex)
        {
            colourHex = hex;
        }
    }
}
