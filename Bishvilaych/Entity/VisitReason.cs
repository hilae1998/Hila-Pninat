using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// מחלקת סיבת ביקור
namespace Entity
{
    public class VisitReason
    {
        public bool GeneralCheck { get; set; }
        public bool BreastExam { get; set; }
        public bool Pap { get; set; }
        public bool Diaphragm { get; set; }
        public bool OtherConcetraption { get; set; }
        public bool MenstrualCycle { get; set; }
        public bool Kallah { get; set; }
        public bool OtherReason { get; set; }
        public string Text { get; set; }
    }
}
