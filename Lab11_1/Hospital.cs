using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11_1
{
    public class Hospital
    {
        public static void GetMtr(Patient patient)
        {
            patient.MrtIsDone = true;
        }

        public static void GetKT(Patient patient)
        {
            patient.KtIsDone = true;
        }
        public static void GetRoentgen(Patient patient)
        {
            patient.RoentgenIsDone = true;
        }
        public static void PassEnt(Patient patient)
        {
            patient.EntIsPassed = true;
        }
        public static void GetUzi(Patient patient)
        {
            patient.UziIsDone = true;
        }
        public static void GetRheumo(Patient patient)
        {
            patient.RheumoIsDone = true;
        }

    }
}
