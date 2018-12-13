package com.roshan.assignment2.question2;

public interface IBankAccountRepository {

	/*Create an interface BankAccountRepository with following methods:
		public double getBalance(long accountId)
		public double updateBalance(long accountId, double newBalance):
		Note: Above method returns updated balance.
	*/
	
	public double getBalance(long accountId);
	public double updateBalance(long accountId, double newBalance);
	
}
