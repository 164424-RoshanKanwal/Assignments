package com.roshan.practice;

public class LC {

	private int id;
	private String name;
	
	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	
	public void intialize(){
		System.out.println("Init");}
	
	public void destroyIt(){
		System.out.println("Destroy");
	}
	//should i write custom-init method in every class
	
}
