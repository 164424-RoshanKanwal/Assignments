package com.roshan.assignment3;

public class BankAccountServiceImpl extends BankAccountList implements IBankAccountService {
/*	Create a class BankAccountServiceImpl that implements 
 * BankAccountService interface.
*/	
	@Override
	public double withdraw(long accountId, double balance) {
		double amount =0;
		for(BankAccount acc : bankAccountList){
			if(acc.getAccountId() == accountId){
				amount = amount + acc.getAccountBalance();
				acc.setAccountBalance(amount-balance);
			}
		}
		
		return amount - balance;
	}

	@Override
	public double deposit(long accountId, double balance) {
		double amount =0;
		for(BankAccount acc : bankAccountList){
			if(acc.getAccountId() == accountId){
				amount = amount + acc.getAccountBalance();
				acc.setAccountBalance(amount+balance);
			}
		}
		
		return amount + balance;
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
	public boolean fundTransfer(long fromAccount, long toAccount, double amount) {
	
		boolean status = false;
		boolean status1 = false;
		boolean status2 = false;
		
		
		for(BankAccount acc : bankAccountList){
			double fromAccountBalance =0;
			if(acc.getAccountId() == fromAccount){
				fromAccountBalance =  acc.getAccountBalance() - amount;
				acc.setAccountBalance(fromAccountBalance);
				status1 = true;
				break;
				}
			}
		
		for(BankAccount acc : bankAccountList){
			double toAccountBalance =0;
			if(acc.getAccountId() == toAccount){
				toAccountBalance = acc.getAccountBalance() + amount;
				acc.setAccountBalance(toAccountBalance);
				status2 = true;
				break;
				}
			}
		
		if(status1==true && status2==true){
			status = true;
		}
		else{
			status= false;
		}
		
		return status;
	}

}
