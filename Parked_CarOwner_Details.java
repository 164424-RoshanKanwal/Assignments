package com.roshan.collectionAssignmentQuestion7;

public class Parked_CarOwner_Details {

	//owerName, carModel, carNO, owerMobileNo, owerAddress
	String ownerName;
	String carModel;
	String carNO;
	String ownerMobileNo;
	String ownerAddress;
	int floorNum;
	String location;
	
	
	public Parked_CarOwner_Details(String ownerName, String carModel,
			String carNO, String ownerMobileNo, String ownerAddress,
			int floorNum, String location) {
		super();
		this.ownerName = ownerName;
		this.carModel = carModel;
		this.carNO = carNO;
		this.ownerMobileNo = ownerMobileNo;
		this.ownerAddress = ownerAddress;
		this.floorNum = floorNum;
		this.location = location;
	}

	
	public int getFloorNum() {
		return floorNum;
	}
	public void setFloorNum(int floorNum) {
		this.floorNum = floorNum;
	}
	public String getLocation() {
		return location;
	}
	public void setLocation(String location) {
		this.location = location;
	}
	public String getOwnerName() {
		return ownerName;
	}
	public void setOwnerName(String ownerName) {
		this.ownerName = ownerName;
	}
	public String getCarModel() {
		return carModel;
	}
	public void setCarModel(String carModel) {
		this.carModel = carModel;
	}
	public String getCarNO() {
		return carNO;
	}
	public void setCarNO(String carNO) {
		this.carNO = carNO;
	}
	public String getOwnerMobileNo() {
		return ownerMobileNo;
	}
	public void setOwnerMobileNo(String ownerMobileNo) {
		this.ownerMobileNo = ownerMobileNo;
	}
	public String getOwnerAddress() {
		return ownerAddress;
	}
	public void setOwnerAddress(String ownerAddress) {
		this.ownerAddress = ownerAddress;
	}
	
}
