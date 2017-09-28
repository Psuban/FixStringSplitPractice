using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSplitFIXPractive
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] delimiterCharSpace = { "\u0001","="," "};
            string test = "8=FIX.4.4\u00019=0000324\u000135=W\u000149=SENDER\u000156=RECEIVER\u000134=18180\u000152=20170530-01:05:02.907\u0001369=164\u0001262=15\u000155=CA\u0001";
            Console.WriteLine(test);
            string[] fixsohdelimited;
            fixsohdelimited = test.Split(delimiterCharSpace, StringSplitOptions.None);
            foreach (string s in fixsohdelimited)
            {
                Console.WriteLine(s);
            }

            string[] fixField = new string[fixsohdelimited.Length];
            string[] fixValue = new string[fixsohdelimited.Length];

            for (int i = 0; i < fixsohdelimited.Length;)
            {
                Console.WriteLine("Below are the Fix Field Tags");
                fixField[i] = fixsohdelimited[i];
                Console.WriteLine("Fix Field " + i + " is " + fixField[i]);
                i = i + 2;
                
            }
            
            for (int i = 1; i < fixsohdelimited.Length;)
                {
                    Console.WriteLine("Below are the Fix Value Tags");
                    fixValue[i] = fixsohdelimited[i];
                    Console.WriteLine("Fix Value " + i + " is " + fixValue[i]);
                i = i + 2;

                }






        }
    }
}
