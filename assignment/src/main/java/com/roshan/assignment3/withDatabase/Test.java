package com.roshan.assignment3.withDatabase;

import java.util.List;

import org.springframework.context.support.AbstractApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

public class Test {

	public static void main(String[] args) {
		
		AbstractApplicationContext context = new ClassPathXmlApplicationContext("spring4.xml");
		context.registerShutdownHook();
		
		BankAccountController bankAccountController = context.getBean(BankAccountController.class);
		List<BankAccount> bankAccountList = bankAccountController.getBankAccountServiceImpl().getBankAccountRepo().getBankAccountList();
		
		System.out.println("Before Transaction..");
		for(BankAccount b : bankAccountList){
			System.out.println(b.getAccountBalance() + " " +b.getAccountHolderName() + " " + b.getAccountId());
		}
		
        bankAccountController.fundTransfer(101, 102, 3000);
        
		System.out.println();
		System.out.println("After First Transaction: Id-101 transfered 3000 to Id-102");
		for(BankAccount b : bankAccountList){
			System.out.println(b.getAccountBalance() + " " +b.getAccountHolderName() + " " + b.getAccountId());
		}
		
		bankAccountController.deposit(100, 23000);
		System.out.println();
		System.out.println("After Second Transaction: Id-100 added 23000");
		for(BankAccount b : bankAccountList){
			System.out.println(b.getAccountBalance() + " " +b.getAccountHolderName() + " " + b.getAccountId());
		}
		
		
		bankAccountController.withdraw(101, 1000);
		System.out.println();
		System.out.println("After Third Transaction: Id-101 withdrawn 1000");
		for(BankAccount b : bankAccountList){
			System.out.println(b.getAccountBalance() + " " +b.getAccountHolderName() + " " + b.getAccountId());
		}
		System.out.println();
		System.out.println("The Balance of Id-100 is " +bankAccountController.getBalance(100));

		context.close();
	}
	
}
