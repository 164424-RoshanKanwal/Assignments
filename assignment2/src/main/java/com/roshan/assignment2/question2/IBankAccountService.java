package com.roshan.assignment2.question2;

import com.roshan.assignment2.question2.exceptions.BankAccountNotFoundException;
import com.roshan.assignment2.question2.exceptions.LowBalanceException;

public interface IBankAccountService {

	/*Create an interface BankAccountService with following methods:
		public double withdraw(long accountId, double balance)
		public double deposit(long accountId, double balance)
		public double getBalance(long accountId)
		public boolean fundTransfer(long fromAccount, long toAccount, double amont)
	*/
	
	public double withdraw(long accountId, double balance) throws LowBalanceException;
	public double deposit(long accountId, double balance);
	public double getBalance(long accountId);
	public boolean fundTransfer(long fromAccount, long toAccount, double amount) throws BankAccountNotFoundException, LowBalanceException;
	
}
