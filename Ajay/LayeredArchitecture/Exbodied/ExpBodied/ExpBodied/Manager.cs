using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpBodied
{
    class Manager
    {
        public Manager(int managerId, string Name)
        {
            id = managerId;
            mname = Name;
        }

        private int id;
        private string mname;

        public override string ToString() => $"{id} {mname}".Trim();
        public void DisplayName() => Console.WriteLine(ToString());
    }
}
