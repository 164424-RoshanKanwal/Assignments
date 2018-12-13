package com.roshan.assignment3.withDatabase;


import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.util.List;

public class BankAccountRepositoryImpl implements IBankAccountRepository{
	
	Connection connection = ConnectionFactory.getConnection();
	
	List<BankAccount> bankAccountList;

	public List<BankAccount> getBankAccountList() {
		return bankAccountList;
	}

	public void setBankAccountList(List<BankAccount> bankAccountList) {
		
		try {
			for(BankAccount bankAccount : bankAccountList){
			PreparedStatement ps = connection.prepareStatement("insert into bankAccount values (?,?,?,?)");
			ps.setInt(1, (int) bankAccount.getAccountId());
			ps.setString(2, bankAccount.getAccountHolderName());
			ps.setString(3, bankAccount.getAccountType());
			ps.setInt(4, (int) bankAccount.getAccountBalance());
			ps.executeUpdate();
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
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
