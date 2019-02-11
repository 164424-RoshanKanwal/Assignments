using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LQ5LibraryProject
{
    public class Class1 : IBankAccount
    {
        public BankAccountTypeEnum AccountType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double Deposit(double amount)
        {
            throw new NotImplementedException();
        }

        public double GetBalance()
        {
            throw new NotImplementedException();
        }

        public bool Transfer(double amount, IBankAccount toAccount)
        {
            throw new NotImplementedException();
        }

        public bool Withdraw(double amount)
        {
            throw new NotImplementedException();
        }

        public enum BankAccountTypeEnum
        {
           
            Saving, Current
        }
        

    }
}
