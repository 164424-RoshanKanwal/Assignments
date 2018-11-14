package com.roshan.practice;

public class EmployeeDetails {
		int eid; 
		String ename;
		int eage;
		
		EmployeeDetails(int eid,String ename,int eage){
			this.eid = eid;
			this.ename = ename;
			this.eage =eage;
		}
		
		public void details(){
			System.out.println(eid);
			System.out.println(ename);
			System.out.println(eage);
		}
}
