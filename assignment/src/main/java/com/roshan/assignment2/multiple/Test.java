package com.roshan.assignment2.multiple;

import java.util.List;
import java.util.Map;
import java.util.Set;

import org.springframework.context.support.AbstractApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

public class Test {

	public static void main(String[] args) {
		AbstractApplicationContext context = new ClassPathXmlApplicationContext("spring.xml");
		context.registerShutdownHook();
		Question question = context.getBean(Question.class);
		
		System.out.println("Answers in List");
		List<String> list = question.getAnswerList();
		for(String answers : list){
			System.out.println(answers);
		}
		System.out.println();
		System.out.println("Answers in Set");
		Set<String> set = question.getAnswerSet();
		for(String answers : set){
			System.out.println(answers);
		}
		
		System.out.println();

		System.out.println("Answers in Map");
		Map<Integer,String> map = question.getAnswerMap();
		for(Map.Entry<Integer, String> mapAns : map.entrySet()){
			System.out.println(mapAns.getValue());
		}
		context.close();
	}
	
	
}
