using NumberParser.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NumberParser.Helpers;

namespace NumberParser.Common
{
    class ParseToJson : IParseCsv
    {
        public string NumberParser(string myNumbers)
        {
            var arrayData = new ConvertStringToArray();

            int[] myArray = arrayData.StringToIntArray(myNumbers);

            return JsonConvert.SerializeObject(myArray);
        }
       
    }
}
