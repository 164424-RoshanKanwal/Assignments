package com.roshan.assignment3.withDatabase;

public class BankAccountServiceImpl implements IBankAccountService {
	
	BankAccountRepositoryImpl bankAccountRepo;
	
	public BankAccountRepositoryImpl getBankAccountRepo() {
		return bankAccountRepo;
	}

	public void setBankAccountRepo(BankAccountRepositoryImpl bankAccountRepo) {
		this.bankAccountRepo = bankAccountRepo;
	}

	@Override
	public double withdraw(long accountId, double balance) {
		double amount =0;
		
		for(BankAccount acc : bankAccountRepo.getBankAccountList()){
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
		for(BankAccount acc : bankAccountRepo.getBankAccountList()){
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
		for(BankAccount acc : bankAccountRepo.getBankAccountList()){
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
		
		
		for(BankAccount acc : bankAccountRepo.getBankAccountList()){
			double fromAccountBalance =0;
			if(acc.getAccountId() == fromAccount){
				fromAccountBalance =  acc.getAccountBalance() - amount;
				acc.setAccountBalance(fromAccountBalance);
				status1 = true;
				break;
				}
			}
		
		for(BankAccount acc : bankAccountRepo.getBankAccountList()){
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
