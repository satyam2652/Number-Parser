using NumberParser.Helpers;
using NumberParser.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NumberParser.Common
{
    class ParseToXML : IParseCsv
    {
        public string NumberParser(string myNumbers)
        {
            var arrayData = new ConvertStringToArray();

            int[] myArray = arrayData.StringToIntArray(myNumbers);

            XDocument doc = new XDocument();
            doc.Add(new XElement("root", myArray.Select(x => new XElement("item", x))));

            return doc.ToString();
        }
      
    }
}
