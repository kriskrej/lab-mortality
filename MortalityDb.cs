using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace MortalityWHO {
    internal class MortalityDb {
        public IEnumerable<MortalityCause> records;

        public MortalityDb() {
            var reader = new StreamReader("data/mortality-Poland-2017.txt");
            var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            records = csv.GetRecords<MortalityCause>();
        }

    }
}