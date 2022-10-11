using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unit5_AdapterPatternPatient_Blazor.InsuranceSystem
{
    public class OutNetworkAdapter : InsuranceInterface
    {
        OutNetworkPatient patient;

        public OutNetworkAdapter(string newName, int newPolicyNumber)
        {
            patient = new OutNetworkPatient(newName, newPolicyNumber);
        }

        public decimal CoverageAmount(int ProcedureID, decimal ProcedureCost)
        {
            decimal percentCovered = patient.CoveragePercent(ProcedureCost);
            return ProcedureCost * percentCovered;
        }

        public string getPatientName()
        {
            return patient.getPatientName();
        }

        public string getPolicyNumber()
        {
            return patient.PolicyNumber.ToString();
        }

        public bool IsCovered(string patientName, string policyNumber)
        {
            int intPolicyNumber = int.Parse(policyNumber);
            string strCovered = patient.IsCovered(patientName, intPolicyNumber);

            if (strCovered == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
