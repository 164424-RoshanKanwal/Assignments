using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LQ7ListsContact
{
    class Program
    {
        enum functions { addcontact,editcontact, displaycontacts, showcontacts  }
        static void Main(string[] args)
        {
            int functionselect;
            Contact contact = new Contact();
            Console.WriteLine("enter the list:");
            do {
                
                Console.WriteLine( functions.addcontact + " " + (int)functions.addcontact);
                Console.WriteLine( functions.editcontact + " " + (int)functions.editcontact);
                Console.WriteLine( functions.displaycontacts + " " + (int)functions.displaycontacts);
                Console.WriteLine( functions.showcontacts + " " + (int)functions.showcontacts);
                Console.WriteLine("enter the function number:");
                functionselect = int.Parse(Console.ReadLine());
                switch (functionselect) {
                    case 0:
                        Console.Write("enter the contact,name,cellno:");
                        contact.addcontact(int.Parse(Console.ReadLine()),Console.ReadLine(),Console.ReadLine());
                        break;
                    case 1:
                        Console.WriteLine("enter the contact");
                        contact.EditContact(int.Parse(Console.ReadLine()));
                        break;
                    case 2:
                        Console.WriteLine("enter the contact");
                        contact.DisplayContact(int.Parse(Console.ReadLine()));
                        break;
                    case 3: contact.ShowContact();
                        break;
                    case 4:
                       Console.WriteLine("Exit of functions");
                        break;
                }
            } while (functionselect !=4);
        }
    }
}
