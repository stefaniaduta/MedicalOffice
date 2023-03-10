using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalOffice
{
    public class Patient
    {
        public int PatID { get; set; }
        public string PatName { get; set; }
        public int PatAddress { get; set; }
        public string PatPhone { get; set; }
        public int PatAge { get; set; }
        public string PatGender { get; set; }
        public int PatBlood { get; set; }
        public int PatDisease { get; set; }


        public Patient()
        {
        }

        public Patient(int pat_id, string pat_name, int address, string phone, int age, string gender, int blood, int disease )
        {

        }
    }
}
