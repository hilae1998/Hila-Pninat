using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Screenings
    {
        public int Code { get; set; }
        //מפתח זר מטבלה אחרת
        public int Screening { get; set; }
        //כנל
        public int  immunization { get; set; }
        public DateTime SDate { get; set; }
        public int Year { get; set; }
        public string Text { get; set; }
        public int PatientCode { get; set; }
}

