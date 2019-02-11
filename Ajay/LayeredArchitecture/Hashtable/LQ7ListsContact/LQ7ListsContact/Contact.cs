using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LQ7ListsContact
{
    class Contact
    {
//        i.AddContact() – To add contact detail to List
//ii.DisplayContact() – To display particular contact detail from List
//iii.EditContact() – To modiy particular contact detail from List
//iv.ShowAllContacts() – To display all contact details from List


        public int ContactNo { get; set; }
        public string ContactName { get; set; }
        public string CellNo { get; set; }

        List<Contact> mylist = new List<Contact>();

        public void addcontact( int contact,string name,string cellno) {
            Contact c = new Contact();
            c.ContactNo = contact;
            c.ContactName = name;
            c.CellNo = cellno;
            mylist.Add(c);
        }

        public void EditContact(int contact)
        {
            foreach (var item in mylist)
            {
                //object it = contact;
                if (item.ContactNo == contact) {
                    //int j = mylist.IndexOf(item);
                    Console.WriteLine($"  {item.ContactNo} + {item.ContactName} +{item.CellNo} ");
                    Console.WriteLine("enter the values to update:");
                    int cont = int.Parse(Console.ReadLine());
                    string name = Console.ReadLine();
                    string cellno = Console.ReadLine();
                    item.ContactNo = cont;
                    item.ContactName = name;
                    item.CellNo = cellno;

                }

            }
        }

        public void ShowContact()
        {
            foreach (var item in mylist)
            {
                Console.WriteLine(item.ContactNo + " ," +item.ContactName +"," +item.CellNo);
            }
        }
        public void DisplayContact(int contact)
        {

            foreach (var item in mylist)
            {

                if (item.ContactNo == contact)
                {
                    Console.WriteLine(item.ContactNo + " ," + item.ContactName+ ","+ item.CellNo);
                }
                
            }
        }
        

    }

}
