package com.roshan.assignment3.again;

public interface IBankAccountService {

	/*Create an interface BankAccountService with following methods:
		public double withdraw(long accountId, double balance)
		public double deposit(long accountId, double balance)
		public double getBalance(long accountId)
		public boolean fundTransfer(long fromAccount, long toAccount, double amont)
	*/
	
	public double withdraw(long accountId, double balance);
	public double deposit(long accountId, double balance);
	public double getBalance(long accountId);
	public boolean fundTransfer(long fromAccount, long toAccount, double amount);
	
}
