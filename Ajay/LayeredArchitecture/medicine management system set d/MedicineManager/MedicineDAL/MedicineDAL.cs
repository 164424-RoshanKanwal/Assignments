using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MedicineEntity;
using MedicineException;

namespace MedicineDAL
{
    //creating DAL for Sql Connection and adding the values to database
    public class MedicineDAL
    {
        //taking connection string as static so we can add as parameter for SQlCOnnection Object
        static string ConnectionString = @"Data Source=NDAMSSQL\SQLILEARN;Initial Catalog=Training_14Nov18_Mumbai;Persist Security Info=True;User ID=sqluser;Password=sqluser";
        SqlConnection Connection = new SqlConnection(ConnectionString);
        //this method will return the bool value
        public bool AddMedicineDAL(Medicine medicine)
        {
            bool isAdded = false;
            try
            {

                SqlCommand Command = new SqlCommand("AddMedicine_032", Connection);
                Command.CommandType = System.Data.CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@MedicineName", medicine.MedicineName);
                Command.Parameters.AddWithValue("@Type",medicine.Type);
                Command.Parameters.AddWithValue("@BatchNo", medicine.BatchNo);
                Command.Parameters.AddWithValue("@Manufacturer",medicine.Manufacturer);
                Command.Parameters.AddWithValue("@ManufactureDate", medicine.ManufactureDate);
                Command.Parameters.AddWithValue("@ExpiryDate", medicine.ExpiryDate);
                Command.Parameters.AddWithValue("@Price", medicine.Price);
                
                Connection.Open();
                Command.ExecuteNonQuery();
                isAdded = true;
            }
            catch (MedicineException.MedicineException me)
            {
                throw me;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Connection.Close();
            }
            return isAdded;
        }
    }
}
