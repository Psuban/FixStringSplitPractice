using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StringSplitFIXPractive
{
    class WebRequest1
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.metalbulletin.com/xmlfeed/xml_prices_full.asp?code=99203&user=hoganas&pass=hoga2016");
        
    }
}
