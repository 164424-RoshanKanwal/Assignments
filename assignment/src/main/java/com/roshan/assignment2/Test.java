package com.roshan.assignment2;

import org.springframework.context.support.AbstractApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

public class Test {

	public static void main(String[] args) {
		AbstractApplicationContext context = new ClassPathXmlApplicationContext("spring.xml");
		context.registerShutdownHook();
		IAnswers answers = context.getBean(AnswerList.class);//AnswerSet.class or 
		answers.getAnswers();// AnswerMap.class or AnswerList.class
		context.close();
	}
	
}
