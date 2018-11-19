package com.roshan.assignment3;



public class MyArrayList implements MyList{
	
	int arrayLen;
	int array[];
	
	public MyArrayList(int[] array) {
		this.array = array;
		this.arrayLen = array.length;
	}
	
	@Override
	public void add() {
		int sum = 0;
		for (int index = 0; index< arrayLen; index++) {
			sum += array[index];	 
		}
		System.out.println(sum);
		
	}

	@Override
	public void get(int arrayLen) {
		System.out.println(array[arrayLen-1]);
		
	}

	@Override
	public void getAll() {
		for (int index = 0; index < arrayLen; index++){

			System.out.print(array[index] + " ");

		}
		
	}

	@Override
	public void update() {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void remove(int newIndex) {
		int temp=0;
		int index = 0;
		for(index =newIndex-1; index<arrayLen-1; index++ ){
			temp = array[index+1];
			array[index] = array[index+1];
			array[index+1] = temp;
		}
		array[arrayLen-1]=0;
		System.out.println(array[index]);
	}
	
	public static void main(String[] args) {
		
		MyArrayList mList = new MyArrayList(new int[] {23,56,74,95,26,88});
		mList.add();
		mList.get(4);
		mList.getAll();
		mList.remove(3);
	}

	
	
}
