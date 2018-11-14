package com.roshan.practice;

public class ArmstrongBetween {
  
	public static void main(String[] args) {
		for (double number= 100; number <=999; number++){
			double result = check(number);
			if (result ==1){
				System.out.print((int)number + " ");
				
			}
		}
		}
	
	public static double check(double number){
		
		if (number == 1.0 || number == 0){
			return 1; 
		}
		else if (number>1 && number<8){
			return 0;
		}
		else{
			double a = Math.floor(Math.cbrt(number));
			number = number - a*a*a;
			return 1*check(number);
		}
	}
	
	
	
}
