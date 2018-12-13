package com.roshan.assignment2.question2;

import com.roshan.assignment2.question2.exceptions.BankAccountNotFoundException;
import com.roshan.assignment2.question2.exceptions.LowBalanceException;

public class BankAccountServiceImpl implements IBankAccountService {

	BankAccountRepositoryImpl bankAccountRepo;
	
	public BankAccountRepositoryImpl getBankAccountRepo() {
		return bankAccountRepo;
	}

	public void setBankAccountRepo(BankAccountRepositoryImpl bankAccountRepo) {
		this.bankAccountRepo = bankAccountRepo;
	}

	
	
	@Override
	public double withdraw(long accountId, double withdrawalAmount) {
		double bankBalance =0;
		for(BankAccount acc : bankAccountRepo.getBankAccountList()){
			if(acc.getAccountId() == accountId){
				bankBalance = bankBalance + acc.getAccountBalance();
				
				if(bankBalance-1000>withdrawalAmount){
					acc.setAccountBalance(bankBalance-withdrawalAmount);
				}
				else{
					throw new LowBalanceException("Your Bank Account Balance is Low!!!");
				}
			}
			
		}
		
		return bankBalance - withdrawalAmount;
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
		
		try{
		for(BankAccount acc : bankAccountRepo.getBankAccountList()){
			double fromAccountBalance =0;
			if(acc.getAccountId() == fromAccount){
				fromAccountBalance =  acc.getAccountBalance() - amount;
				acc.setAccountBalance(fromAccountBalance);
				status1 = true;
				break;
				}
			}}
			catch(LowBalanceException | BankAccountNotFoundException e){
				System.out.println(e.getMessage());
				
			}
			
		try{
		for(BankAccount acc : bankAccountRepo.getBankAccountList()){
			double toAccountBalance =0;
			if(acc.getAccountId() == toAccount){
				toAccountBalance = acc.getAccountBalance() + amount;
				acc.setAccountBalance(toAccountBalance);
				status2 = true;
				break;
				}
			}}
		catch(LowBalanceException | BankAccountNotFoundException e){
			System.out.println(e.getMessage());
		}
		
		
		if(status1==true && status2==true){
			status = true;
		}
		else{
			throw new BankAccountNotFoundException();
		}
		
		return status;
	}

}
