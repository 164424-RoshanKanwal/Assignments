using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LQ5LibraryProject
{
    public abstract class BankAccount : IBankAccount
    {
        protected double balance=0;

        public Class1.BankAccountTypeEnum AccountType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double Deposit(double amount)
        {
         
            return balance;
            //throw new NotImplementedException();
        }

        public double GetBalance()
        {
            return balance;

            //throw new NotImplementedException();
        }

        public bool Transfer(double amount, IBankAccount toAccount)
        {

            return true;
          //  throw new NotImplementedException();
        }

        public bool Withdraw(double amount)
        {
            return true;
           // throw new NotImplementedException();
        }
    }
       

  public class HSBC : BankAccount {
        public new double Deposit(double amount)
        {
            balance = balance + amount;
            Console.WriteLine("Amount deposited");
            return balance;
            //throw new NotImplementedException();
        }
        private new bool Withdraw(double amount) //Override this method
        {

            // If Balance – amount is >= 5000 then only WithDraw is possible.
            // Write the code to achieve the same.

            if (balance - amount >= 5000)
            {
                balance = balance - amount;
                Console.WriteLine("amount deducted: "+amount);
                return true;
            }
            else {
                Console.WriteLine("amount deducted: " + amount);
                return false;
            }

            
        }
        public new double GetBalance()
        {
            Console.WriteLine("balance is: "+balance);
            return balance;

            //throw new NotImplementedException();
        }

        private new bool Transfer(double amount, IBankAccount toAccount) //Override this method
        {
            // If Balance – Withdraw is >= 5000 then only transfer can take place.
            // Write the code to achieve the same.
            if (balance - amount >= 5000)
            {
                toAccount.Deposit(amount);
                balance = balance - amount;
                return true;
            }
            else {
                return false;
            }

        }
    }
 public class ICICI : BankAccount // Inherit this from BankAccount
    {
        public new double Deposit(double amount)
        {
            balance = balance + amount;
            Console.WriteLine("Amount deposited" +amount);
            return balance;
            //throw new NotImplementedException();
        }
        private new bool Withdraw( double amount) // Override this method
        {
            // If Balance – amount is >= 0 then only WithDraw is possible.
            // Write the code to achieve the same.
            if (balance - amount >= 0)
            {
                balance = balance - amount;

                return true;
            }
            else
            {
                return false;
            }
        }

        private new bool Transfer(double amount, IBankAccount toAccount) //Override this method
        {
            // If Balance – Withdraw is >= 1000 then only transfer can take place.
            // Write the code to achieve the same.
            if (balance - amount >= 1000)
            {
                toAccount.Deposit(amount);
                balance = balance - amount;
                return true;
            }
            else
            {
                return false;
            }

        }
        public new double GetBalance()
        {
            Console.WriteLine("balance is: " + balance);
            return balance;

            //throw new NotImplementedException();
        }

    }



}
