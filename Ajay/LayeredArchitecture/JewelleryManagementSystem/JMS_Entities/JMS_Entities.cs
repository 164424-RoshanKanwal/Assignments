using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   

    public enum Region
    {
        East=1, West=2, North=3, South =4
    }
    [Serializable]
    public class JMS_Entities
    {

        static int count;
      

        static JMS_Entities()
        {
            count = 1000;
        }

        public JMS_Entities()
        {
            SalesManCode = ++count;
        }

        public int SalesManCode { get; set; }
        public String SalesManName { get; set; }
        public Region Region2 { get; set; }
        public float TargetSet { get; set; }
        public float ActualSales { get; set; }
        public static int Count
        {
            get { return count; }
            set { count = value; }
        }
    }
}
