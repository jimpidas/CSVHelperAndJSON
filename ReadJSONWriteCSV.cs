using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Linq;
using Newtonsoft.Json;

namespace CSVHelperAndJson
{
    class ReadJSONWriteCSV
    {
        public static void ImplementJSONToCSV()
        {
            string importFilePath = @"C:\Users\Dell\DotNetProjects\CSVHelperAndJson\Utility\export.json";
            string exportFilePath = @"C:\Users\Dell\DotNetProjects\CSVHelperAndJson\Utility\export.csv";
            IList<AddressData> addressData = JsonConvert.DeserializeObject<IList<AddressData>>(File.ReadAllText(importFilePath));
            
                Console.WriteLine("**********************Reading from Json file and Write to csv file **************************");
                using (var writer = new StreamWriter(exportFilePath))
                using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(addressData);
                }
            
        }
    }

}
