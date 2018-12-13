package com.roshan.assignment3.again;


import java.util.List;

public class BankAccountRepositoryImpl implements IBankAccountRepository{
	

	List<BankAccount> bankAccountList;

	public List<BankAccount> getBankAccountList() {
		return bankAccountList;
	}

	public void setBankAccountList(List<BankAccount> bankAccountList) {
		this.bankAccountList = bankAccountList;
	}


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
