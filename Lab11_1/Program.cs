using System;

namespace Lab11_1
{
    public delegate void GetAllResults(Patient patient);
   
    class Program
    {
       

        static void Main(string[] args)
        {

            var patient = new Patient();
            GetAllResults getAllResults = null;

            GetAllResults getKT = (patient) => 
            {
                Hospital.GetKT(patient); 
            };

            GetAllResults getMrt = (patient) =>
            {
                Hospital.GetMtr(patient);
            };

            GetAllResults getRoentgen = (patient) =>
            {
                Hospital.GetRoentgen(patient);
            };

            GetAllResults getEnt = (patient) =>
            {
                Hospital.GetUzi(patient);
            };

            GetAllResults getRheumo = (patient) =>
            {
                Hospital.GetRheumo(patient);
            };

            getAllResults = getKT + getMrt + getRoentgen + getEnt + getRheumo;

            getAllResults.Invoke(patient);
        }
        
      
        
    }
}
