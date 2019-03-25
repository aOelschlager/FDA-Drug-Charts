using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Anne-Marie Oelschlager
 * z102098
 * CSCI 680v4 (section 2)
 * Assignment 6
 * Due: May 1, 2018
*/

namespace Assign6
{
    // Class that will hold data converted form Json
    class MetaJson
    {
        public string disclaimer { get; set; }
        public string terms { get; set; }
        public string license { get; set; }
        public string last_updated { get; set; }
    }
}
