using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LQ5LibraryProject;
using static LQ5LibraryProject.Class1;

namespace LQ5ConsoleAppBankAccount
{
    class Program
    {
        enum bank { ICICI, HSBC }
        enum methodcall { deposit,transfer,withdraw,getbalance }
      
 
        static void Main(string[] args)
        {
            List<object> arrayList = new List<object>();
            int i,j, bankk, acctype;
            void fucntionss() { 
            Console.WriteLine(methodcall.deposit + " " + (int)methodcall.deposit);
            Console.WriteLine(methodcall.transfer + " " + (int)methodcall.transfer);
                Console.WriteLine(methodcall.withdraw + " " + (int)methodcall.withdraw);
                Console.WriteLine(methodcall.getbalance + " " + (int)methodcall.getbalance);
            }
            do
            {
                Console.WriteLine("Enter the bank:");
                Console.WriteLine(bank.ICICI + " " + (int)bank.ICICI);
                Console.WriteLine(bank.HSBC + " " + (int)bank.HSBC);
                bankk = int.Parse(Console.ReadLine());
                switch (bankk)
                {
                    case 0:
                        break;
                    case 1:
                        break;
                    case 2:
                        Console.Write("Exit from bankk");
                        break;
                }
                if (bankk !=2) {
                    do
                    {
                        Console.WriteLine("Enter the account type:");
                        Console.WriteLine(BankAccountTypeEnum.Saving + " " + (int)BankAccountTypeEnum.Saving);
                        Console.WriteLine(BankAccountTypeEnum.Current + " " + (int)BankAccountTypeEnum.Current);
                        acctype = int.Parse(Console.ReadLine());
                        //i = int.Parse(Console.ReadLine());
                        switch (acctype)
                        {
                            case 0:
                                ICICI icicisave = new ICICI();
                               
                                var hsbcsave = new LQ5LibraryProject.HSBC();
                                
                                IBankAccount bankAccountinterfaceicici = new ICICI();
                                IBankAccount bankAccountinterfacehsbc = new HSBC();
                                arrayList.Add(bankAccountinterfaceicici);
                                arrayList.Add(bankAccountinterfacehsbc);
                                do {
                                    Console.WriteLine("select function:");
                                    fucntionss();
                                     j = int.Parse(Console.ReadLine());
                                    switch (j)
                                    {
                                        case 0:
                                           
                                            if (acctype == 0 && bankk == 0)
                                            {
                                                
                                                //    var icsave = new LQ5LibraryProject.ICICI();
                                                Console.WriteLine("Enter the deposit amount:");
                                                double amount = double.Parse(Console.ReadLine());
                                                double result=icicisave.Deposit(amount);
                                                Console.WriteLine("balance is:"+result);
                                            }
                                            else if (acctype == 0 && bankk == 1)
                                            {
                                                
                                                Console.WriteLine("Enter the deposit amount:");
                                                double amount = double.Parse(Console.ReadLine());
                                                double result = hsbcsave.Deposit(amount);
                                                Console.WriteLine("balance is:" + result);
                                            }

                                            break;
                                        case 1:
                                            if (acctype == 0 && bankk == 0)
                                            {
                                                
                                                Console.WriteLine("Enter the transfer amount:");
                                                double amount = double.Parse(Console.ReadLine());
                                                Console.WriteLine("Enter the transfer account:");
                                                icicisave.Transfer(amount,);

                                            }
                                            else if (acctype == 0 && bankk == 1)
                                            {
                                                
                                                Console.WriteLine("Enter the deposit amount:");
                                                double amount = double.Parse(Console.ReadLine());
                                                hsbcsave.Deposit(amount);
                                            }

                                            break;
                                        case 2:
                                            if (acctype == 0 && bankk == 0)
                                            {

                                                //    var icsave = new LQ5LibraryProject.ICICI();
                                                Console.WriteLine("Enter the withdraw amount:");
                                                double amount = double.Parse(Console.ReadLine());
                                                bool result = icicisave.Withdraw(amount);
                                                Console.WriteLine("balance is:" + result);
                                            }
                                            else if (acctype == 0 && bankk == 1)
                                            {
                                                
                                                Console.WriteLine("Enter the deposit amount:");
                                                double amount = double.Parse(Console.ReadLine());
                                                bool result = hsbcsave.Withdraw(amount);
                                                Console.WriteLine("balance is:" + result);
                                            }
                                            break;

                                        case 3:
                                            if (acctype == 0 && bankk == 0)
                                            {
                                                
                                                icicisave.GetBalance();
                                               
                                            }
                                            if (acctype == 0 && bankk == 1)
                                            {

                                                hsbcsave.GetBalance();

                                            }

                                            break;

                                    }

                                } while (j!=4);
           
                                break;
                            case 1:
                                var icicicurr = new LQ5LibraryProject.ICICI();
                               var hsbccurr = new LQ5LibraryProject.HSBC();
                                IBankAccount bankAccountinterfaceicicicurr = new ICICI();
                                IBankAccount bankAccountinterfacehsbccurr = new HSBC();
                                arrayList.Add(bankAccountinterfaceicicicurr);
                                arrayList.Add(bankAccountinterfacehsbccurr);
                                
                                do
                                {
                                    Console.WriteLine("select function:");
                                    fucntionss();
                                    j = int.Parse(Console.ReadLine());
                                    switch (j)
                                    {
                                        case 0:

                                            if (acctype == 0 && bankk == 0)
                                            {

                                                //    var icsave = new LQ5LibraryProject.ICICI();
                                                Console.WriteLine("Enter the deposit amount:");
                                                double amount = double.Parse(Console.ReadLine());
                                                double result = icicicurr.Deposit(amount);
                                                Console.WriteLine("balance is:" + result);
                                            }
                                            else if (acctype == 0 && bankk == 1)
                                            {

                                                Console.WriteLine("Enter the deposit amount:");
                                                double amount = double.Parse(Console.ReadLine());
                                                double result = hsbccurr.Deposit(amount);
                                                Console.WriteLine("balance is:" + result);
                                            }

                                            break;
                                        case 1:
                                            if (acctype == 0 && bankk == 0)
                                            {

                                                Console.WriteLine("Enter the deposit amount:");
                                                double amount = double.Parse(Console.ReadLine());
                                                icicicurr.Deposit(amount);

                                            }
                                            else if (acctype == 0 && bankk == 1)
                                            {

                                                Console.WriteLine("Enter the deposit amount:");
                                                double amount = double.Parse(Console.ReadLine());
                                                foreach (var item in arrayList)
                                                {
                                                    Console.WriteLine("select account:"+ item);
                                                }
                                                int varr = int.Parse(Console.ReadLine());
                                                
                                             //   hsbccurr.Transfer(amount,IBankAccount.);
                                            }

                                            break;
                                        case 2:
                                            if (acctype == 0 && bankk == 0)
                                            {
                                                Console.WriteLine("Enter the withdraw amount:");
                                                double amount = double.Parse(Console.ReadLine());
                                                bool result = icicicurr.Withdraw(amount);
                                                Console.WriteLine("balance is:" + result);
                                            }
                                            else if (acctype == 0 && bankk == 1)
                                            {

                                                Console.WriteLine("Enter the deposit amount:");
                                                double amount = double.Parse(Console.ReadLine());
                                                bool result = hsbccurr.Withdraw(amount);
                                                Console.WriteLine("balance is:" + result);
                                            }
                                            break;

                                        case 3:
                                            if (acctype == 0 && bankk == 0)
                                            {

                                                icicicurr.GetBalance();

                                            }
                                            if (acctype == 0 && bankk == 1)
                                            {

                                                hsbccurr.GetBalance();

                                            }

                                            break;

                                    }

                                } while (j != 4);



                                //if (acctype == 1 && bankk == 0) { 
                                //    Console.WriteLine("Enter the deposit amount:");
                                //    double amount = double.Parse(Console.ReadLine());
                                //    icicicurr.Deposit(amount);

                                //}
                                //if (acctype == 1 && bankk == 1) { var hsbccurr = new LQ5LibraryProject.HSBC();


                                //}
                                break;
                            case 2:
                                Console.Write("Exit from acctype");
                                break;
                        } 
                    } while (acctype != 2);

                }
            } while (bankk != 2);
            
              
        }
    }
}
