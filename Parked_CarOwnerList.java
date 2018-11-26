package com.roshan.collectionAssignmentQuestion7;

import java.util.HashMap;

public class Parked_CarOwnerList {

	//int add_new_car(Parked_CarOwner_Details obj), remove_car(), get_parked_car_location(token)
	
	static HashMap<String, Parked_CarOwner_Details> hashMap = new HashMap();
	
	public void add_new_car(Parked_CarOwner_Details obj){
		
		hashMap.put(obj.getCarNO(), obj);
		
	}
	
	public void remove_car(String carNo){
		
		hashMap.remove(carNo);
		
	}
	
	public void get_parked_car_location(String carNo){
		
		System.out.println(hashMap.get(carNo).getOwnerName() + " " + hashMap.get(carNo).getCarModel()+" "+
				hashMap.get(carNo).getLocation() +" "+ hashMap.get(carNo).getOwnerMobileNo()+ " " + hashMap.get(carNo).getFloorNum());
		
	}
	
	
	public static void main(String[] args) {
		Parked_CarOwnerList carlist = new Parked_CarOwnerList();
		carlist.add_new_car(new Parked_CarOwner_Details("Roshan", "Audi", "3", "1232", "Ban", 1, "front"));
		carlist.add_new_car(new Parked_CarOwner_Details("Roshand", "Audi", "33", "1232", "Ban", 1, "front"));
		carlist.add_new_car(new Parked_CarOwner_Details("Roshans", "Audi", "35", "1232", "Ban", 1, "front"));
		
		/*carlist.remove_car("33");
		System.out.println(hashMap.get("3").location);*/
		
		carlist.get_parked_car_location("33");
		
		//HashMap<Parked_CarOwner_Details , Parked_CarOwner_Details> hashMap = new HashMap();
		
		//hashMap("","");
		
		
	}
}
