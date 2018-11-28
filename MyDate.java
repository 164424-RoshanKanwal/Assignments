package com.roshan.collectionAssignmentQuestion4;

public class MyDate {

	public int dd;
	public int mm;
	public int yyyy;
	
	public MyDate(int dd, int mm, int yyyy) {
		super();
		this.dd = dd;
		this.mm = mm;
		this.yyyy = yyyy;
	}

	@Override
	public boolean equals(Object o) {
		MyDate dob = (MyDate) o;
		return this.getDd() == dob.getDd() && this.getMm()==dob.getMm();
	}
	
	@Override
	public int hashCode() {
		
		return this.getDd()+ this.getMm();
	}
	
	public int getDd() {
		return dd;
	}

	public void setDd(int dd) {
		this.dd = dd;
	}

	public int getMm() {
		return mm;
	}

	public void setMm(int mm) {
		this.mm = mm;
	}

	public int getYyyy() {
		return yyyy;
	}

	public void setYyyy(int yyyy) {
		this.yyyy = yyyy;
	}

	@Override
	public String toString() {
		return "MyDate [dd=" + dd + ", mm=" + mm + ", yyyy=" + yyyy + "]";
	}
	
	
}
