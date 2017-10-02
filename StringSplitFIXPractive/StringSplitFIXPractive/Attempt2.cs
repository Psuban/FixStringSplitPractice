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
            int i = 1;

            while (test.Length!=0)
            {
                Console.WriteLine("This is the " + i + " iteration");
                i++;
                int indexOfEquals = test.IndexOf('=');
                Console.WriteLine("This is the index number of the equals sign " + indexOfEquals);
                tagList.Add(test.Substring(0, indexOfEquals));
                //string tag = test.Substring(0, indexOfEquals);
                //Console.WriteLine("The tag value is: " + tag);
                if (test.Contains(' '))
                {
                    int indexOfSpace = test.IndexOf(' ');
                    Console.WriteLine("This is the index number of the space " + indexOfSpace + "\n");
                    valueList.Add(test.Substring(indexOfEquals + 1, indexOfSpace - (indexOfEquals + 1)));
                    //string value = test.Substring(indexOfEquals + 1, indexOfSpace - (indexOfEquals + 1));
                    //Console.WriteLine(value);

                    test = test.Substring(indexOfSpace + 1, test.Length - (indexOfSpace + 1));
                }
                else
                {
                    break;
                }
                Console.WriteLine(test);

            }
            Console.WriteLine("\nthe number of tags is: " + tagList.Count);
            foreach (string t in tagList)
            {
                Console.WriteLine(t);
            }
            Console.WriteLine("\nthe number of values is: " + valueList.Count);
            foreach (string v in valueList)
            {
                Console.WriteLine(v);
            }

            Console.Read();
        }
    }
}
