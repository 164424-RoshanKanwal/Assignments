package com.roshan.date;

public class TestDateDifferenceProjectVersion2 {
	
	static MyDate startDate;
	static MyDate endDate;
	static int actualDiff;
	
	public static void main(String[] args) {
		
		startDate = new MyDate(4, 6, 2011);
		endDate = new MyDate(4, 6, 2011);
		actualDiff = 0;
		getStatus();
		
		startDate = new MyDate(4, 6, 2011);
		endDate = new MyDate(18, 6, 2011);
		actualDiff = 14;
		getStatus();
		
		startDate = new MyDate(6, 4, 2011);
		endDate = new MyDate(18, 5, 2011);
		actualDiff = 42;
		getStatus();
		
		startDate = new MyDate(6, 4, 2011);
		endDate = new MyDate(18, 6, 2011);
		actualDiff = 73;
		getStatus();
		
		startDate = new MyDate(6, 4, 2011);
		endDate = new MyDate(18, 12, 2011);
		actualDiff = 256;
		getStatus();
		
		
	}
	
	public static void getStatus(){
		if (actualDiff == DateDifferenceProvider.dateDiff(startDate, endDate)){
			System.out.println("Passed");
		}
		else {
			System.out.println(DateDifferenceProvider.dateDiff(startDate, endDate));
			System.out.println("Failed");
		}
		
	}

}
