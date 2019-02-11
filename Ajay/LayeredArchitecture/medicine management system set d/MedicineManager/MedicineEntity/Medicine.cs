using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineEntity
{
    //creating entityClass and declaring the required Properties
    public class Medicine
    {
        public int MedicineID { get; set; }
        public string MedicineName { get; set; }
        public string Type { get; set; }
        public string Manufacturer { get; set; }
        public string BatchNo { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public double Price { get; set; }
    }
}
