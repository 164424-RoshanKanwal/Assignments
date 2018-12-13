package com.roshan.assignment2.multiple;

import java.util.List;
import java.util.Map;
import java.util.Set;

public class Question {

	private int questionId;
	private String question;
	private List<String> answerList;
	private Set<String> answerSet;
	private Map<Integer,String> answerMap;
	
	public int getQuestionId() {
		return questionId;
	}
	public void setQuestionId(int questionId) {
		this.questionId = questionId;
	}
	public String getQuestion() {
		return question;
	}
	public void setQuestion(String question) {
		this.question = question;
	}
	public List<String> getAnswerList() {
		return answerList;
	}
	public void setAnswerList(List<String> answerList) {
		this.answerList = answerList;
	}
	public Set<String> getAnswerSet() {
		return answerSet;
	}
	public void setAnswerSet(Set<String> answerSet) {
		this.answerSet = answerSet;
	}
	public Map<Integer, String> getAnswerMap() {
		return answerMap;
	}
	public void setAnswerMap(Map<Integer, String> answerMap) {
		this.answerMap = answerMap;
	}
	
	public void getAnswersList(){
		System.out.println("Hello");
	}
	
}
