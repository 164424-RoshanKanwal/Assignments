package com.roshan.assignment2.question2.exceptions;

public class BankAccountNotFoundException extends RuntimeException{

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;

	public BankAccountNotFoundException() {
		super("Invalid Bank Account");
	}
	
}
