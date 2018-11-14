package com.roshan.practice;

import java.util.Scanner;

public class AllEmployee {
 


		public static void main(String[] args) {
			Scanner scan = new Scanner(System.in);
			System.out.println("ENTER EMPLOYEE ID");
			int empid = scan.nextInt();
			System.out.println("ENTER EMPLOYEE NAME");
			String empname = scan.next();
			System.out.println("ENTER EMPLOYEE AGE");
			int empage = scan.nextInt();
			
			
			EmployeeDetails emp1 = new EmployeeDetails(empid, empname, empage);
			emp1.details();
			
			
			
			scan.close();
		}
		
}
