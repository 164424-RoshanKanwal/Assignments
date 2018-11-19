package com.roshan.assignment3;

public class MyArray {
	private static int[] array = {12,5,18,78,69,75,36,78,36,55,31,33,13};
	private static int arrayLen = array.length;
	public static void main(String[] args) {

		MyArray ma = new MyArray();
		ma.add(array,arrayLen);
		ma.get(3);
		ma.update();
		ma.getAll();
		ma.remove(4);
		System.out.println();
		ma.getAll();
	}

	public void add(int[] array , int arrayLen){
		int sum = 0;
		for (int index = 0; index< arrayLen; index++) {
			sum += array[index];	 
		}
		System.out.println(sum);
	}
	public void get(int arrayLen){
		System.out.println(array[arrayLen-1]);
	}

	public void getAll(){

		for (int index = 0; index < arrayLen; index++){

			System.out.print(array[index] + " ");

		}
		//System.out.println(array);
	}
	
	public void update(){
		array[7] = 56;
	}
	
	public void remove(int newIndex){
		int temp=0;
		for(int index =newIndex-1; index<arrayLen-1; index++ ){
			temp = array[index+1];
			array[index] = array[index+1];
			array[index+1] = temp;
		}
		array[arrayLen-1]=0;
	}
}
