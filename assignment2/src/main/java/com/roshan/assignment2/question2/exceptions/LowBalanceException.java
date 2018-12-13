package com.roshan.assignment2.question2.exceptions;

public class LowBalanceException extends RuntimeException{

	private static final long serialVersionUID = 1L;

	public LowBalanceException(String message) {
		super(message);
	}
	
}
