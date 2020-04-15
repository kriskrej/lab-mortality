using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace MortalityWHO {
    internal class MortalityDb {
        IEnumerable<MortalityCause> records;

        public MortalityDb() {
            using (var reader = new StreamReader("data\\mortality-Poland-2017.txt"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture)) {
                csv.Configuration.PrepareHeaderForMatch = (string header, int index) => header.ToLower();
                records = csv.GetRecords<MortalityCause>();
            }
        }

    }

    public class PolishPopulation2017 {
        public PolishPopulation2017SingleSex male = new PolishPopulation2017SingleSex() {
            agesAll = 18373411,
            age0 = 199755,
            age1 = 192274,
            age2 = 192076,
            age3 = 191309,
            age4 = 193823,
            age5to9 = 1054100,
            age10to14 = 931414,
            age15to19 = 959415,
            age20to24 = 1143000,
            age25to29 = 1375647,
            age30to34 = 1577179,
            age35to39 = 1540525,
            age40to44 = 1421590,
            age45to49 = 1185127,
            age50to54 = 1137011,
            age55to59 = 1280068,
            age60to64 = 1280348,
            age65to69 = 1029578,
            age70to74 = 572603,
            age75to79 = 414744,
            age80to84 = 292450,
            age85to89 = 155817,
            age90to94 = 45305,
            age95andOver = 8253,
            ageUnspecified = 0,
            liveBirths = 206410,
        };

        public PolishPopulation2017SingleSex female = new PolishPopulation2017SingleSex() {
            agesAll = 19588907,
            age0 = 189768,
            age1 = 182228,
            age2 = 181720,
            age3 = 181134,
            age4 = 183441,
            age5to9 = 1000086,
            age10to14 = 884080,
            age15to19 = 912634,
            age20to24 = 1099687,
            age25to29 = 1321744,
            age30to34 = 1519457,
            age35to39 = 1495110,
            age40to44 = 1391123,
            age45to49 = 1175699,
            age50to54 = 1157420,
            age55to59 = 1369873,
            age60to64 = 1458090,
            age65to69 = 1281264,
            age70to74 = 797935,
            age75to79 = 684858,
            age80to84 = 576027,
            age85to89 = 371554,
            age90to94 = 143759,
            age95andOver = 30216,
            ageUnspecified = 0,
            liveBirths = 195572
        };
    }

    public class PolishPopulation2017SingleSex {
        public int agesAll;
        public int age0;
        public int age1;
        public int age2;
        public int age3;
        public int age4;
        public int age5to9;
        public int age10to14;
        public int age15to19;
        public int age20to24;
        public int age25to29;
        public int age30to34;
        public int age35to39;
        public int age40to44;
        public int age45to49;
        public int age50to54;
        public int age55to59;
        public int age60to64;
        public int age65to69;
        public int age70to74;
        public int age75to79;
        public int age80to84;
        public int age85to89;
        public int age90to94;
        public int age95andOver;
        public int ageUnspecified;
        public int liveBirths;

    }

    public class MortalityCause {
        /// <summary>
        /// Cause of death – For details consult Part 2 below or ICD publications
        /// </summary>
        public string cause;
        /// <summary>
        /// 1 male, 2 female and 9 sex unspecified
        /// </summary>
        public int sex;
        /// <summary>
        /// Age-group format for breakdown of deaths at 0-95+ yrs – see Annex Table 1 below for details
        /// </summary>
        public int frmat;
        /// <summary>
        /// Age format for breakdown of infant deaths (0 year) – see Annex Table 1 below for details
        /// </summary>
        public int IM_Frmat;
        /// <summary>
        /// deaths at all ages
        /// </summary>
        public int deaths1;
        /// <summary>
        /// deaths at age 0 year
        /// </summary>
        public int deaths2;
        /// <summary>
        /// deaths at age 1 year
        /// </summary>
        public int deaths3;
        /// <summary>
        /// deaths at age 2 year
        /// </summary>
        public int deaths4;
        /// <summary>
        /// deaths at age 3 year
        /// </summary>
        public int deaths5;
        /// <summary>
        /// deaths at age 4 year
        /// </summary>
        public int deaths6;
        /// <summary>
        /// deaths at age 5-9 years
        /// </summary>
        public int deaths7;
        /// <summary>
        /// deaths at age 10-14 years
        /// </summary>
        public int deaths8;
        /// <summary>
        /// deaths at age 15-19 years
        /// </summary>
        public int deaths9;
        /// <summary>
        /// deaths at age 20-24 years
        /// </summary>
        public int deaths10;
        /// <summary>
        /// deaths at age 25-29 years
        /// </summary>
        public int deaths11;
        /// <summary>
        /// deaths at age 30-34 years
        /// </summary>
        public int deaths12;
        /// <summary>
        /// deaths at age 35-39 years
        /// </summary>
        public int deaths13;
        /// <summary>
        /// deaths at age 40-44 years
        /// </summary>
        public int deaths14;
        /// <summary>
        /// deaths at age 45-49 years
        /// </summary>
        public int deaths15;
        /// <summary>
        /// deaths at age 50-54 years
        /// </summary>
        public int deaths16;
        /// <summary>
        /// deaths at age 55-59 years
        /// </summary>
        public int deaths17;
        /// <summary>
        /// deaths at age 60-64 years
        /// </summary>
        public int deaths18;
        /// <summary>
        /// deaths at age 65-69 years
        /// </summary>
        public int deaths19;
        /// <summary>
        /// deaths at age 70-74 years
        /// </summary>
        public int deaths20;
        /// <summary>
        /// deaths at age 75-79 years
        /// </summary>
        public int deaths21;
        /// <summary>
        /// deaths at age 80-84 years
        /// </summary>
        public int deaths22;
        /// <summary>
        /// deaths at age 85-89 years
        /// </summary>
        public int deaths23;
        /// <summary>
        /// deaths at age 90-94 years
        /// </summary>
        public int deaths24;
        /// <summary>
        /// deaths at age 95 years and above 
        /// </summary>
        public int deaths25;
        /// <summary>
        /// deaths at age unspecified
        /// </summary>
        public int deaths26;
        /// <summary>
        /// Infant deaths at age 0 day
        /// </summary>
        public int IM_deaths1;
        /// <summary>
        /// Infant deaths at age 1-6 days
        /// </summary>
        public int IM_deaths2;
        /// <summary>
        /// Infant deaths at age 7-27 days
        /// </summary>
        public int IM_deaths3;
        /// <summary>
        /// Infant deaths at age 28-364 days
        /// </summary>
        public int IM_deaths4;
    }
}