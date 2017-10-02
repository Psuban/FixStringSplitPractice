using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSplitFIXPractive
{
    class Program
    {
        private class FixField
        {
            public string Tag { get; set; }

            public string Value { get; set; }
        }

        static void Main(string[] args)
        {
            //Attemp1 attempt1 = new Attemp1();
            //attempt1.StringDelimeterExercise1();
            Attempt2 attempt2 = new Attempt2();
            attempt2.StringDelimeterExercise2();
        }

    }
}

