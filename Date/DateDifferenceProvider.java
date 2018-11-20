package com.roshan.date;

public class DateDifferenceProvider {
	
	 static int months[]= {31,28,31,30,31,30,31,31,30,31,30,31};
	
	public static int dateDiff(MyDate startDate, MyDate endDate){
		
		if ((startDate.getDd()==endDate.getDd())  &&  (startDate.getMm()==endDate.getMm()) && (startDate.getYyyy() == endDate.getYyyy())){
			return 0;
		}
		else if ((startDate.getMm()==endDate.getMm()) && (startDate.getYyyy() == endDate.getYyyy())){
			return endDate.getDd() - startDate.getDd();
		}
		else if((startDate.getYyyy() == endDate.getYyyy())){
			return remainingDaysOfMonths(startDate) + endDate.getDd() + interveningMonths(startDate, endDate);
		}
		return 0;
	}


	public static int remainingDaysOfMonths(MyDate startDate){
		
	return	months[startDate.getMm()-1] - startDate.getDd();
	
	}
	
	public static int interveningMonths(MyDate startDate, MyDate endDate){
		int totalDays = 0;
		
			for(int index = startDate.getMm(); index < endDate.getMm()-1; index++){
				totalDays += months[index];
			}
			return totalDays;
		
		
	}
	
}