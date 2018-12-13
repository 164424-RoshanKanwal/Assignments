package com.roshan.assignment1;

import org.springframework.context.ApplicationContext;
import org.springframework.context.support.AbstractApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;


public class Test {

	public static void main(String[] args) {
		
		ApplicationContext context = new ClassPathXmlApplicationContext("spring.xml");
		Customer customer = context.getBean(Customer.class);
		
		customer.getCustomerData();
		
		((AbstractApplicationContext) context).close();
	}
	
}
