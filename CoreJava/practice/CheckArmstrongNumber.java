package com.roshan.practice;

import java.util.Scanner;

public class CheckArmstrongNumber {

	public static void main(String[] args) {
		
	Scanner scan = new Scanner(System.in);
	System.out.println("Check the Armstrong Number Here!!");
	System.out.println("Enter a number!!");
	
	int number = scan.nextInt();
	double result = check(number);
	
	if(result == 0){
		System.out.println("The number entered is not Armstrong Number");
	}
	else{
		System.out.println("The number entered is a Armstrong Number");
	}
	
	scan.close();
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
