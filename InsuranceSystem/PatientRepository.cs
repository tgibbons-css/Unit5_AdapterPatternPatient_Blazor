using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unit5_AdapterPatternPatient_Blazor.InsuranceSystem
{
    public class PatientRepository
    {
        //List<InsuranceInterface> patients = new List<InsuranceInterface>();
        Dictionary<string, InsuranceInterface> patients = new Dictionary<string, InsuranceInterface>();

        public PatientRepository()
        {
            patients.Add("A111B222", new InNetworkPatient("Tom Gibbons", "A111B222", PolicyLevels.Gold));
            patients.Add("A222C444", new InNetworkPatient("Jen Rosato", "A222C444", PolicyLevels.Platnum));
            patients.Add("D333B111", new InNetworkPatient("Dave Vosen", "D333B111", PolicyLevels.Silver));

            patients.Add("112233", new OutNetworkAdapter("Kathy Modin", 112233));
        }

        public IEnumerable<InsuranceInterface> getAllPatients()
        {
            return patients.Values;
        }

        public InsuranceInterface getPatientByPolicy(string PolicyNumber) {
            // TODO --- actually return the patient with this policy number
            return patients[PolicyNumber];
        }
    }
}
