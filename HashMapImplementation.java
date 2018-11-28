package com.roshan.collectionAssignmentQuestion4;

import java.util.HashMap;

public class HashMapImplementation extends MyDate {
	


	public HashMapImplementation(int dd, int mm, int yyyy) {
		super(dd, mm, yyyy);
		
	}

	public static void main(String[] args) {
		//If the initial capacity is greater than the maximum number of entries divided
		//by the load factor, no rehash operations will ever occur.


		HashMap<MyDate, String> employeeDOB = new HashMap<>();
		
		MyDate first = new MyDate(16, 12, 1996);
		MyDate first1 = new MyDate(6, 2, 1995);
		MyDate first2 = new MyDate(16, 3, 1994);
		MyDate first3 = new MyDate(6, 12, 1996);
		MyDate first4 = new MyDate(6, 12, 1995);
		
		employeeDOB.put(first, "Rahul");
		employeeDOB.put(first1, "Rahu");
		employeeDOB.put(first2, "Rahula");
		employeeDOB.put(first3, "Rahuli");
		employeeDOB.put(first4, "Roshan");
		
		System.out.println(employeeDOB);
		
		
	}
	
}
