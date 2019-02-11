using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using BLL;
using EntityDTH;
using DTHExceptions;

namespace TWRMSPL
{
    class DTHMain
    {
        public static int ID = 1;
        public static void AddUserPL()
        {
            try
            {
                Entity objApplicant = new Entity();
                Console.WriteLine("Enter the  Email :");
                bool chkid;
                string  aid = Console.ReadLine();
                //Use Regex.IsMatch to chk if the entered value valid
                chkid = Regex.IsMatch(aid, @"[a-zA-Z0 - 9]{0,}[@]{1}[a-zA-Z]{2,}[.]{1}[a-zA-Z]{2,4}");
                //chkid = Regex.IsMatch(aid, @"/^[a-zA-Z0 - 9]{0,}@[a - zA-Z]{0,}.[a-zA-Z]{2,4}$/"); 
                //If the match fails, throw the Exception
                if (chkid == false)
                {
                    throw new ExceptionDTH("Invalid Email");
                }
                // If the regex match is successful, store the Email(aid) into the Entity object
                else
                {
                    objApplicant.Email = aid;
                }
                Console.WriteLine("Enter Mobile No:");
                string MNo  = Console.ReadLine();
                //Use Regex.IsMatch to chk if the entered value is valid
                bool chkname = Regex.IsMatch(MNo, @"[0-9]{10}");
                if (chkname == false)
                {
                    throw new ExceptionDTH("Enter Valid Mobile No");
                }
                // If the regex match is successful, store the mobile number into the Entity object
                else
                {
                    objApplicant.MobileNo = MNo;
                }

                Console.WriteLine("Enter the Channel Name:");
                string Name = Console.ReadLine();
                //Use Regex.IsMatch to chk if the entered value is valid
                bool chname = Regex.IsMatch(Name, @"[a-zA-Z]+");
                //If the match fails, throw the Exception
                if (chname == false)
                {
                    throw new ExceptionDTH("Invalid Entry, Enter Valid Name");
                }
                // If the regex match is successful, store the channel name into the Entity object
                else
                {
                    objApplicant.ChannelName = Name;
                }

                Console.WriteLine("Enter the Channel Category:");
                Channel_Category Ccat;
                //Use TryParse to see if the category entered is valid.
                bool chkVtype = Enum.TryParse<Channel_Category>(Console.ReadLine(), out Ccat);
                if (chkVtype == false)
                {
                    throw new ExceptionDTH("Invalid Entry, Enter Valid Category Type");
                }
                // If the Parsing is successful, store the category into the Entity object
                else
                {
                    objApplicant.ChannelCategory = Ccat;
                }
                
             ;

                DateTime StartDate;
                StartDate = DateTime.Now;
                objApplicant.subscription_date = StartDate.AddDays(2);

                objApplicant.SubscriptionId = DTHMain.ID;
                DTHMain.ID += 1;
                
                DTHBLL bllobj = new DTHBLL();
                if (bllobj.AddBL(objApplicant) == false)
                {
                    throw new ExceptionDTH(" Record could not be added");

                }
                else
                {
                    Console.WriteLine(" Details Added Successfully\n");
                    Console.WriteLine("Unique ID is :{0}", DTHMain.ID - 1);
                }
            }

            catch (ExceptionDTH Exception)
            {
                Console.WriteLine("Error occurred " + Exception.Message);
            }
        }


        public static void UnsubscribePL()
        {
            Console.WriteLine("Enter the  Email :");
            bool chkid;
            string email = Console.ReadLine();
            
            chkid = Regex.IsMatch(email, @"[a-zA-Z0 - 9]{0,}[@]{1}[a-zA-Z]{2,}[.]{1}[a-zA-Z]{2,4}");
           
            if (chkid == false)
            {
                throw new ExceptionDTH("Invalid Email");
            }
           

            Console.WriteLine("Enter the Channel Name:");
            string Name = Console.ReadLine();
          
            bool chname = Regex.IsMatch(Name, @"[a-zA-Z]+");
           
            if (chname == false)
            {
                throw new ExceptionDTH("Invalid Entry, Enter Valid Name");
            }

            DTHBLL bllobj = new DTHBLL();
           bool check= DTHBLL.UnsubscribePL(email,Name);
            if(check==true)
            {
                Console.WriteLine("Successfully Unsubscribed");
            }
            else
            {
                Console.WriteLine("Sorry-----Unable to  Unsubscribe the Channel");
            }

        }


        public static void DisplayPL()
        {
            DTHBLL bllobj = new DTHBLL();
            List<Entity> details = new List<Entity>();
            details = DTHBLL.DisplayPL();
            Console.WriteLine("\nOnly Subscribers with out displaying Unsubscribers\n");
            foreach(var temp in details)
            {
              Console.WriteLine("\nSubscription ID :{0}\nEmail :{1}\n Channel Name :{2} \nChannelCategory :{3} \nSubscription Date  :{4}\nPhone NO:{5}\n Unsubscription:{6}\n", temp.SubscriptionId, temp.Email, temp.ChannelName, temp.ChannelCategory, temp.subscription_date, temp.MobileNo, temp.unsubscription);
                
            }
        }


        static void Main(string[] args)
        {
            byte choice;
           
            do
            {
                PrintMenu();
                Console.WriteLine("Enter Your Choice:");
                bool chkChoice;

                chkChoice = byte.TryParse(Console.ReadLine(), out choice);
                if (!chkChoice) { Console.WriteLine("Invalid Input "); }
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        AddUserPL();
                        break;
                    case 2:
                        Console.Clear();
                        DisplayPL();
                        break;
                        
                    case 3:
                        Console.Clear();
                        SearchPL();
                        break;
                    case 4:
                        Console.Clear();
                        UnsubscribePL();
                        break;

                        


                    //case 4:
                    //    Console.Clear();
                    //    UpdateUserPL();
                    case 0:return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (choice != 0);

        }

        private static void SearchPL()
        {
            Entity searchedApplicant = null;
            try
            {
                Console.WriteLine("Enter Email (in exact spelling and case) to be searched:");
                string Email = Console.ReadLine();
                DTHBLL applicantBLL = new DTHBLL();

                searchedApplicant = applicantBLL.SearchBLL(Email);
                if (searchedApplicant != null)
                {
                    if (searchedApplicant.unsubscription == "true")
                    {
                        Console.WriteLine("\nSubscription ID :{0}\nEmail :{1}\n Channel Name :{2} \nChannelCategory :{3} \nSubscription Date  :{4}\nPhone NO:{5}\n Unsubscription:{6}\n Unsuscription Date:{7}\n", searchedApplicant.SubscriptionId, searchedApplicant.Email, searchedApplicant.ChannelName, searchedApplicant.ChannelCategory, searchedApplicant.subscription_date, searchedApplicant.MobileNo, searchedApplicant.unsubscription, searchedApplicant.unsubscription_date);
                    }
                    else
                    {
                        Console.WriteLine("\nSubscription ID :{0}\nEmail :{1}\n Channel Name :{2} \nChannelCategory :{3} \nSubscription Date  :{4}\nPhone NO:{5}\n Unsubscription:{6}\n", searchedApplicant.SubscriptionId, searchedApplicant.Email, searchedApplicant.ChannelName, searchedApplicant.ChannelCategory, searchedApplicant.subscription_date, searchedApplicant.MobileNo, searchedApplicant.unsubscription);
                    }
                }
                else
                {
                    Console.WriteLine("No such Applicant");
                }
            }
            catch (ExceptionDTH Exception)
            {
                Console.WriteLine(Exception.Message);
            }
            catch (Exception Exception)
            {
                Console.WriteLine(Exception.Message);
            }
        }
        public static void PrintMenu()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("DTH Provider System (DTHPS)");
            Console.WriteLine("Press 1 To Subscribe");
            Console.WriteLine("Press 2 To Display Details");
            Console.WriteLine("Press 3 To Search Details");
            Console.WriteLine("Press 4 To Unsubscribe");
            Console.WriteLine("Press 0 To Exit");
            Console.WriteLine("============================================");

        }
    }
}
