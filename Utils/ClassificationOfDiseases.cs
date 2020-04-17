using CsvHelper;
using CsvHelper.Configuration.Attributes;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace MortalityWHO.Utils {
    public class ClassificationOfDiseases {
        public List<Diesease> dieseases;
        public ClassificationOfDiseases() {
            var reader = new StreamReader("data/ICD10pl.csv");
            var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            csv.Configuration.Delimiter = ";";
            dieseases = csv.GetRecords<Diesease>().ToList();
        }
    }

    public class Diesease {
        [Name("Podkategoria")]
        public string Subcategory { get; set; }
        [Name("Kod podkategorii")]
        public string Code { get; set; }
    }
}
