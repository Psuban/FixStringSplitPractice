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
            string test = "8=FIX.4.49=000024735=X49=LME56=FSM1MDV34=4984952=20170821-16:18:03.263369=1262=1268=1279=2269=255=SN461=FCEPS10010=210004=S541=2017092910004=S541=20171006270=-815=USD271=-25272=20170821273=08:33:54.792277=07555=257554=2453221574=410035=EL10=177";
            List<string> tagList = new List<string>();
            List<string> valueList = new List<string>();
            int i = 0;

            int startIndex = 0;
            
            while (startIndex!=test.Length)
            {
                i++;
                int indexOfEquals = test.IndexOf('=', startIndex);
                tagList.Add(test.Substring(startIndex, indexOfEquals-startIndex));
                int indexOfSpace = test.IndexOf("\u0001", indexOfEquals + 1);
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

            for (int n = 0; n < tagList.Count; n++)
            {
                Console.WriteLine("\n" + tagList[n]+"=" + valueList[n]);
            }

            Console.Read();
        }
    }
}
