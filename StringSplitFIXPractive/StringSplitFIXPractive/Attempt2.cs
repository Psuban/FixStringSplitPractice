using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StringSplitFIXPractive
{
    class Attempt2
    {
        public void StringDelimeterExercise2()
        {
            string test = "8=FIX.4.4 9=0000324 35=W 49=SENDER 56=RECEIVER 34=18180 52=20170530-01:05:02.907 1369=164 262=15 55=CA ";
            List<string> tagList = new List<string>();
            List<string> valueList = new List<string>();
            int i = 0;

          

            int startIndex = 0;
            

            while (startIndex!=test.Length)
            {
                i++;
                int indexOfEquals = test.IndexOf('=', startIndex);
                tagList.Add(test.Substring(startIndex, indexOfEquals-startIndex));
                int indexOfSpace = test.IndexOf(' ', indexOfEquals + 1);
                startIndex = indexOfSpace + 1;
                valueList.Add(test.Substring(indexOfEquals + 1, indexOfSpace - (indexOfEquals + 1)));

            }
            Console.WriteLine("\nThe number of tags is: " + tagList.Count);
            foreach (string t in tagList)
            {
                Console.WriteLine(t);
            }
            Console.WriteLine("\nThe number of values is: " + valueList.Count);
            foreach (string v in valueList)
            {
                Console.WriteLine(v);
            }

            Console.Read();
        }
    }
}
