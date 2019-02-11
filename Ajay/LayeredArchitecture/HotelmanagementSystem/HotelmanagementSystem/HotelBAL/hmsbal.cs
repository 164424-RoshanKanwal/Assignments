using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelDAL;
using HotelEntity;
using HotelException;
using System.Text.RegularExpressions;

namespace HotelBAL
{
    public class hmsbal
    {
        public bool IsValid(Worker workers)
        {
            bool valid = true;
            StringBuilder sb = new StringBuilder();
            if (workers.ID <= 0)
            {
                valid = false;
                sb.Append(Environment.NewLine + "Please enter the valid worker Id");
            }
            if (!(Regex.IsMatch(workers.Name, @"^[A-Z][a-z]+$")))
            {
                valid = false;
                sb.Append(Environment.NewLine + "Name should not contain number and special charecters");
            }
            if (workers.Salary <= 0)
            {
                valid = false;
                sb.Append(Environment.NewLine + "please enter the valid worker salary");
            }
            if (workers.DOJ > DateTime.Now)
            {
                valid = false;
                sb.Append(Environment.NewLine + "Please enter the correct joining date of the worker");
            }
            if (!valid)
            {
                throw new WorkerNotFoundException(sb.ToString());
            }
            return valid;

        }
        hmsdal dAL = new hmsdal();
        public void Add(Worker workers)
        {
            try
            {
                if (IsValid(workers))
                {
                    dAL.Insert(workers);
                }
            }
            catch (WorkerNotFoundException ex1)
            {
                throw ex1;

            }
            catch (Exception ex2)
            {

                throw ex2;
            }
        }
        public void Remove(int ID)
        {
            try
            {

                dAL.Delete(ID);


            }
            catch (WorkerNotFoundException ex1)
            {
                throw ex1;

            }
            catch (Exception ex2)
            {

                throw ex2;
            }
        }
       
        public List<Worker> GetAll()
        {

            try
            {
                return dAL.SelectAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
       

        public void Modify(Worker workers)
        {
            try
            {
                if (IsValid(workers))
                {
                    dAL.Update(workers);
                }
            }
            catch (WorkerNotFoundException ex1)
            {
                throw ex1;

            }
            catch (Exception ex2)
            {

                throw ex2;
            }
        }
        public static void SerializeData()
        {
            hmsdal.SerializeData();
        }
    }
}