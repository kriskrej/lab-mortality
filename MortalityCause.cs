namespace MortalityWHO {
    public class MortalityCause {
        /// <summary>
        /// Cause of death – For details consult Part 2 below or ICD publications
        /// </summary>
        public string cause{ get; set; }
        /// <summary>
        /// 1 male, 2 female and 9 sex unspecified
        /// </summary>
        public int sex{ get; set; }
        /// <summary>
        /// Age-group format for breakdown of deaths at 0-95+ yrs – see Annex Table 1 below for details
        /// </summary>
        public int frmat{ get; set; }
        /// <summary>
        /// Age format for breakdown of infant deaths (0 year) – see Annex Table 1 below for details
        /// </summary>
        public int IM_Frmat{ get; set; }
        /// <summary>
        /// deaths at all ages
        /// </summary>
        public int deaths1{ get; set; }
        /// <summary>
        /// deaths at age 0 year
        /// </summary>
        public int deaths2{ get; set; }
        /// <summary>
        /// deaths at age 1 year
        /// </summary>
        public int deaths3{ get; set; }
        /// <summary>
        /// deaths at age 2 year
        /// </summary>
        public int deaths4{ get; set; }
        /// <summary>
        /// deaths at age 3 year
        /// </summary>
        public int deaths5{ get; set; }
        /// <summary>
        /// deaths at age 4 year
        /// </summary>
        public int deaths6{ get; set; }
        /// <summary>
        /// deaths at age 5-9 years
        /// </summary>
        public int deaths7{ get; set; }
        /// <summary>
        /// deaths at age 10-14 years
        /// </summary>
        public int deaths8{ get; set; }
        /// <summary>
        /// deaths at age 15-19 years
        /// </summary>
        public int deaths9{ get; set; }
        /// <summary>
        /// deaths at age 20-24 years
        /// </summary>
        public int deaths10{ get; set; }
        /// <summary>
        /// deaths at age 25-29 years
        /// </summary>
        public int deaths11{ get; set; }
        /// <summary>
        /// deaths at age 30-34 years
        /// </summary>
        public int deaths12{ get; set; }
        /// <summary>
        /// deaths at age 35-39 years
        /// </summary>
        public int deaths13{ get; set; }
        /// <summary>
        /// deaths at age 40-44 years
        /// </summary>
        public int deaths14{ get; set; }
        /// <summary>
        /// deaths at age 45-49 years
        /// </summary>
        public int deaths15{ get; set; }
        /// <summary>
        /// deaths at age 50-54 years
        /// </summary>
        public int deaths16{ get; set; }
        /// <summary>
        /// deaths at age 55-59 years
        /// </summary>
        public int deaths17{ get; set; }
        /// <summary>
        /// deaths at age 60-64 years
        /// </summary>
        public int deaths18{ get; set; }
        /// <summary>
        /// deaths at age 65-69 years
        /// </summary>
        public int deaths19{ get; set; }
        /// <summary>
        /// deaths at age 70-74 years
        /// </summary>
        public int deaths20{ get; set; }
        /// <summary>
        /// deaths at age 75-79 years
        /// </summary>
        public int deaths21{ get; set; }
        /// <summary>
        /// deaths at age 80-84 years
        /// </summary>
        public int deaths22{ get; set; }
        /// <summary>
        /// deaths at age 85-89 years
        /// </summary>
        public int deaths23{ get; set; }
        /// <summary>
        /// deaths at age 90-94 years
        /// </summary>
        public int deaths24{ get; set; }
        /// <summary>
        /// deaths at age 95 years and above 
        /// </summary>
        public int deaths25{ get; set; }
        /// <summary>
        /// deaths at age unspecified
        /// </summary>
        public int deaths26{ get; set; }
        /// <summary>
        /// Infant deaths at age 0 day
        /// </summary>
        public int IM_deaths1{ get; set; }
        /// <summary>
        /// Infant deaths at age 1-6 days
        /// </summary>
        public int IM_deaths2{ get; set; }
        /// <summary>
        /// Infant deaths at age 7-27 days
        /// </summary>
        public int IM_deaths3{ get; set; }
        /// <summary>
        /// Infant deaths at age 28-364 days
        /// </summary>
        public int IM_deaths4{ get; set; }
    }
}