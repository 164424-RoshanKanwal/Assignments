using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicineDAL;
using MedicineEntity;
using MedicineException;

namespace MedicineBLL
{
    //creating BLL for passing data between PL and DAL
    public class MedicineBLL
    {
        //this method will valid the data and returns the bool value
        public bool IsValid(Medicine med)
        {
            bool isValid = true;
            if(med.Price<0 || med.MedicineName == string.Empty||med.BatchNo==string.Empty)
            {
                isValid = false;
            }
            return isValid;
        }

        //this method will pass te data
        public bool AddMedicineBLL(Medicine medicine)
        {
            //creating object for DAL class
            MedicineDAL.MedicineDAL medDAL = new MedicineDAL.MedicineDAL();
            bool IsAdded = false;
            try
            {
                if (IsValid(medicine))
                {
                    medDAL.AddMedicineDAL(medicine);
                    IsAdded = true;
                }
            }
            catch(MedicineException.MedicineException me)
            {
                throw me;
            }
            return IsAdded;
        }
    }
}
