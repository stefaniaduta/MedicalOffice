using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalOffice
{
    public class Prescription
    {
        public int PresID { get; set; }
        public int PatID { get; set; }
        public string PatName { get; set; }
        public int DocID { get; set; }
        public string PresSym { get; set; }
        public string PresDiag { get; set; }
        public string PresMed { get; set; }

        public Prescription()
        {
        }

        public Prescription(int pres_id, int pat_id, string pat_name, int doc_id, string symptoms, string diagnosis, string medicine)
        {

        }
    }
}
