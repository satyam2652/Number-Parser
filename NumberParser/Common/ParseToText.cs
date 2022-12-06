using NumberParser.Helpers;
using NumberParser.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberParser.Common
{
    class ParseToText : IParseCsv
    {
        public string NumberParser(string myNumbers)
        {
            var arrayData = new ConvertStringToArray();

            int[] myArray = arrayData.StringToIntArray(myNumbers);

            string op ="";
            foreach (int i in myArray)
            {
                op = op + i + ",";
            }
            return op.Remove(op.Length - 1); 

        }
       
    }
}
