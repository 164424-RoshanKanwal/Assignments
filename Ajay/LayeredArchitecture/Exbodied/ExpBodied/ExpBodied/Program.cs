using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpBodied
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager(1001, "Suresh");
            //Console.WriteLine(m);
            m.DisplayName();
            Console.ReadKey();
        }
    }
}
