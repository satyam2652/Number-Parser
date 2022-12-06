using NumberParser.Common;
using NumberParser.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberParser.Factories
{
    class NumberParserFactory
    {
        public static IParseCsv ParseNumber(string fileFormat)
        {
            IParseCsv parseCsv = null;

            switch (fileFormat)
            {
                case "text":
                    {
                        parseCsv = new ParseToText();
                        break;
                    }
                case "xml":
                    {
                        parseCsv = new ParseToXML();
                        break;
                    }
                case "json":
                    {
                        parseCsv = new ParseToJson();
                        break;
                    }
            }
           
            return parseCsv;
        }
    }
}
