using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelEntity
{

    public enum category
    { chef=1,serviceBoy=2,receptionist=3}
    [Serializable]
    public class Worker
    {
        
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public category type{ get; set; }
        public DateTime DOJ { get; set; }
        public DateTime WorkTime { get; set; }

        public object Find(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"{ID},{Name},{Salary},{type},{DOJ},{WorkTime}";
        }
    }
}
