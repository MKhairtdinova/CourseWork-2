using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Информационная_система_v2
{
    class PatientComparer: IEqualityComparer<Patient>, IComparer<Patient>
    {
        public bool Equals(Patient p1, Patient p2)
        {
            if (p1.UserCode == p2.UserCode)
                return true;
            else return false;
        }

        public int GetHashCode(Patient patient)
        {
            return patient.FullName.GetHashCode();
        }

        public int Compare(Patient p1, Patient p2)
        {
            if (p1.UserCode > p2.UserCode)
                return 1;
            else
            {
                if (p1.UserCode == p2.UserCode)
                    return 0;
                else return -1;
            }
        }
    }
}
