package com.roshan.practice;

import java.util.Scanner;

public class SIAndCI {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		System.out.println("Get the Simple Interest and Compound Interest");

		System.out.println("Enter the Amount");
		int amount = scan.nextInt();

		System.out.println("Enter number of years");
		int nOfYears = scan.nextInt();

		System.out.println("Enter the rate of interest");
		int rate = scan.nextInt();

		int sI = (amount * nOfYears * rate) / 100;
		System.out.println("The Simple Interest for " + amount + " is " + sI);

		double cI = compoundInterest(nOfYears, rate);
		System.out.println("The Compound Interest for " + amount + " is " + cI);
		scan.close();
	}

	public static double compoundInterest(int nOfYears, int rate) {
		double result=0.0;
		if (nOfYears == 1) {
			System.out.println(result);
			System.out.println("NOfyears==1");
			result= (1 + rate / 100);
		} else if (nOfYears == 0) {
			System.out.println("NOfyears==0");
			result= 1;
		} else {
			System.out.println("NOfyears==final");
			result= (1 + rate / 100) * compoundInterest(nOfYears - 1, rate);
		}
		return result;
	}

}
