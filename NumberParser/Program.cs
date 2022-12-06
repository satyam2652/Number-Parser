using NumberParser.Factories;
using NumberParser.Interfaces;
using System;

namespace NumberParser
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a csv string to be processed");

            var ipCsv = Console.ReadLine();

            Console.WriteLine("Please enter one of the output file formats (text/json/xml)");

            var opFileFormat = Console.ReadLine();

            if (ipCsv.Length > 0 && (opFileFormat != null || opFileFormat.ToLower() != "text" || opFileFormat.ToLower() != "json" || opFileFormat.ToLower() != "xml"))
            {
                ParseInputData(ipCsv, opFileFormat);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
        public static void ParseInputData(string csv, string fileFormat)
        {
            IParseCsv parseCsv = NumberParserFactory.ParseNumber(fileFormat);

            Console.WriteLine("Output:\n" + parseCsv.NumberParser(csv));

            Console.ReadLine();
        }

    }
}
