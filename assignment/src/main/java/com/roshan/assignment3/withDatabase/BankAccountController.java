package com.roshan.assignment3.withDatabase;

public class BankAccountController {


	BankAccountServiceImpl bankAccountServiceImpl;
	

	public BankAccountServiceImpl getBankAccountServiceImpl() {
		return bankAccountServiceImpl;
	}


	public void setBankAccountServiceImpl(
			BankAccountServiceImpl bankAccountServiceImpl) {
		this.bankAccountServiceImpl = bankAccountServiceImpl;
	}


	public double withdraw(long accountId, double balance) {
		double amount =0;
		
		for(BankAccount acc : bankAccountServiceImpl.getBankAccountRepo().getBankAccountList()){
			if(acc.getAccountId() == accountId){
				amount = amount + acc.getAccountBalance();
				acc.setAccountBalance(amount-balance);
			}
		}

		return amount - balance;
	}


	public double deposit(long accountId, double balance) {
		double amount =0;
		for(BankAccount acc :  bankAccountServiceImpl.getBankAccountRepo().getBankAccountList()){
			if(acc.getAccountId() == accountId){
				amount = amount + acc.getAccountBalance();
				acc.setAccountBalance(amount + balance);
			}
		}

		return amount + balance;
	}

	public double getBalance(long accountId) {
		double accountBalance =0;
		for(BankAccount acc :  bankAccountServiceImpl.getBankAccountRepo().getBankAccountList()){
			if(acc.getAccountId() == accountId){
				accountBalance = acc.getAccountBalance();
			}
		}
		return accountBalance;
	}


	public boolean fundTransfer(long fromAccount, long toAccount, double amount) {

		boolean status = false;
		boolean status1 = false;
		boolean status2 = false;


		for(BankAccount acc :  bankAccountServiceImpl.getBankAccountRepo().getBankAccountList()){
			int fromAccountBalance =0;
			if(acc.getAccountId() == fromAccount){
				fromAccountBalance = (int) (acc.getAccountBalance() - amount);
				acc.setAccountBalance(fromAccountBalance); 
				status1 = true;
				break;
			}
		}

		for(BankAccount acc :  bankAccountServiceImpl.getBankAccountRepo().getBankAccountList()){
			int toAccountBalance =0;
			if(acc.getAccountId() == toAccount){
				toAccountBalance = (int) (acc.getAccountBalance() + amount);
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
