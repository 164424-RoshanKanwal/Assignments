package com.roshan.assignment2;

import java.util.Map;

public class AnswerMap  implements IAnswers{

	private Map<Integer, Question> answerMap;
	
	public Map<Integer, Question> getAnswerMap() {
		return answerMap;
	}



	public void setAnswerMap(Map<Integer, Question> answerMap) {
		this.answerMap = answerMap;
	}



	public void getAnswers() {
		System.out.println("Answers in Map");
		for(Map.Entry<Integer, Question> map : answerMap.entrySet()){
			System.out.println(map.getValue().getAnswer());
		}
	}

}
