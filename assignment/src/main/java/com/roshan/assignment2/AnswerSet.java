package com.roshan.assignment2;

import java.util.Set;

public class AnswerSet  implements IAnswers{

	private Set<Question> answerSet;

	public Set<Question> getAnswerSet() {
		return answerSet;
	}

	public void setAnswerSet(Set<Question> answerSet) {
		this.answerSet = answerSet;
	}
	
	public void getAnswers(){
		System.out.println("Answers in Set");
		for(Question q : answerSet){
			System.out.println(q.getAnswer());
		}
	}
}
