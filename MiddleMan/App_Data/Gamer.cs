using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//This is the class that is going to be used for all the data inputs

namespace MiddleMan
{
    public class Gamer
    {
        public string lName;
        public string rName;
        public double lMove;
        public double rMove;
        //CUSTOM CONSTRUCTOR
        public Gamer(string lName, string rName, double lMove, double rMove)
        {
            this.lName = "";
            this.rName = "";
            this.lMove = 0;
            this.rMove = 0;
        }
    }
}