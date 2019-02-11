using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LQ5LibraryProject.Class1;

namespace LQ5LibraryProject
{
   public interface IBankAccount
    {
        double GetBalance();
        double Deposit(double amount);
        bool Withdraw(double amount);
         bool Transfer(double amount, IBankAccount toAccount);
        BankAccountTypeEnum AccountType { get; set; }
    }
}
