using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unit5_AdapterPatternPatient_Blazor.InsuranceSystem
{
    public class PatientRepository
    {
        List<InsuranceInterface> patients = new List<InsuranceInterface>();

        public PatientRepository()
        {
            patients.Add(new InNetworkPatient("Tom Gibbons", "A111B222", PolicyLevels.Gold));
            patients.Add(new InNetworkPatient("Jen Rosato", "A222C444", PolicyLevels.Platnum));
            patients.Add(new InNetworkPatient("Dave Vosen", "D333B111", PolicyLevels.Silver));
        }

        public List<InsuranceInterface> getAllPatients()
        {
            return patients;
        }

        public InsuranceInterface getPatientByPolicy(string PolicyNumber) {
            // TODO --- actually return the patient with this policy number
            return patients[0];
        }
    }
}
