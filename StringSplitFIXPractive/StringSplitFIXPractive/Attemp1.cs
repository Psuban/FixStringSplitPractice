using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSplitFIXPractive
{
    class Attemp1
    {
        public void StringDelimeterExercise1()
        {

            string[] delimiterCharSpace = { " ", "=" };
            string test =
                "8=FIX.4.4 9=0000324 35=W 49=SENDER 56=RECEIVER 34=18180 52=20170530-01:05:02.907 1369=164 262=15 55=CA";
            Console.WriteLine(test);
            string[] fixsohdelimited;
            fixsohdelimited = test.Split(delimiterCharSpace, StringSplitOptions.None);
            foreach (string s in fixsohdelimited)
            {
                Console.WriteLine(s);
            }
            string[] fixField = new string[fixsohdelimited.Length];
            string[] fixValue = new string[fixsohdelimited.Length];
            Console.WriteLine("\nBelow are the Fix Field Tags\n");
            for (int i = 0; i < fixsohdelimited.Length;)
            {
                fixField[i] = fixsohdelimited[i];
                Console.WriteLine("Fix Field " + i + " is " + fixField[i]);
                i = i + 2;

            }
            Console.WriteLine("\nBelow are the Fix Value Tags\n");
            for (int i = 1; i < fixsohdelimited.Length;)
            {
                fixValue[i] = fixsohdelimited[i];
                Console.WriteLine("Fix Value " + i + " is " + fixValue[i]);
                i = i + 2;
            }
        }
    }
}
