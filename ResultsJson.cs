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
    // Class that will hold data converted from Json
    class ResultsJson : MetaJson
    {
        public List<Result> results { get; set; }
    }

    public class Result
    {
        public string term { get; set; }
        public int count { get; set; }
    }
}
