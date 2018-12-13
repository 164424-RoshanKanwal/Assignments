package com.roshan.assignment3;

import java.util.List;

import org.springframework.context.support.AbstractApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

public class Test {

	public static void main(String[] args) {
		
		AbstractApplicationContext context = new ClassPathXmlApplicationContext("spring.xml");
		context.registerShutdownHook();
		BankAccountController bac = context.getBean(BankAccountController.class);
		List<BankAccount> list = bac.getBankAccountList();
		
		
		System.out.println("Before Transaction..");
		for(BankAccount b : list){
			System.out.println(b.getAccountBalance() + " " +b.getAccountHolderName() + " " + b.getAccountId());
		}
		
		System.out.println();
		System.out.println("First Transaction: Id-100 transfer 3000 to Id-102");
		bac.fundTransfer(100, 102, 3000);
		for(BankAccount b : list){
			System.out.println(b.getAccountBalance() + " " +b.getAccountHolderName() + " " + b.getAccountId());
		}
	
		bac.deposit(100, 30000);
		System.out.println();
		System.out.println("Second Transaction :30000 deposited in Id-100");
		for(BankAccount b : list){
			System.out.println(b.getAccountBalance() + " " +b.getAccountHolderName() + " " + b.getAccountId());
		}
		
		bac.withdraw(102, 2300);
		System.out.println();
		System.out.println("Third Transaction: 2300 withdrawn from Id-102");
		for(BankAccount b : list){
			System.out.println(b.getAccountBalance() + " " +b.getAccountHolderName() + " " + b.getAccountId());
		}
		
		bac.withdraw(101, 2000);
		System.out.println();
		System.out.println("Fourth Transaction: 2000 withdrawn from Id-101");
		for(BankAccount b : list){
			System.out.println(b.getAccountBalance() + " " +b.getAccountHolderName() + " " + b.getAccountId());
		}
		
		context.close();
	}
	
}
