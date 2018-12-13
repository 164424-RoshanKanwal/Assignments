package com.roshan.assignment3;

public class BankAccountRepositoryImpl extends BankAccountList implements IBankAccountRepository{


	@Override
	public double getBalance(long accountId) {
	double accountBalance =0;
		for(BankAccount acc : bankAccountList){
			if(acc.getAccountId() == accountId){
				accountBalance = acc.getAccountBalance();
				
			}
		}
	return accountBalance;
	}

	
	@Override
	public double updateBalance(long accountId, double newBalance) {
		double amount =0;
		for(BankAccount acc : bankAccountList){
			if(acc.getAccountId() == accountId){
				amount = amount + acc.getAccountBalance();
				acc.setAccountBalance(amount+newBalance);
			}
		}
		
		return amount + newBalance;
	}

	
	

}
