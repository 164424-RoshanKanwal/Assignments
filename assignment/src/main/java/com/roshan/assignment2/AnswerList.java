package com.roshan.assignment2;

import java.util.List;

public class AnswerList implements IAnswers{

	private List<Question> answerList;

	public List<Question> getAnswerList() {
		return answerList;
	}

	public void setAnswerList(List<Question> answerList) {
		this.answerList = answerList;
	}
	
	public void getAnswers(){
		System.out.println("Answers in List");
		for(Question q:answerList){
			System.out.println(q.getAnswer());
		}
	}
}
