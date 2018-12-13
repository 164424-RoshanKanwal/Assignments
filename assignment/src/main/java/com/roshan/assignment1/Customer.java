package com.roshan.assignment1;

public class Customer {

	//Create an Customer class with the following attributes:- customerId, customerName, customerContact, customerAddress.

	private int customerId;
	private String customerName;
	private long customerContact;
	private Address customerAddress;
	public int getCustomerId() {
		return customerId;
	}
	public void setCustomerId(int customerId) {
		this.customerId = customerId;
	}
	public String getCustomerName() {
		return customerName;
	}
	public void setCustomerName(String customerName) {
		this.customerName = customerName;
	}

	public long getCustomerContact() {
		return customerContact;
	}
	public void setCustomerContact(long customerContact) {
		this.customerContact = customerContact;
	}
	public Address getCustomerAddress() {
		return customerAddress;
	}
	public void setCustomerAddress(Address customerAddress) {
		this.customerAddress = customerAddress;
	}
	
	public void getCustomerData(){
		System.out.println("CustomerId: " + getCustomerId() + " " + "Customer Contact Number: " + " " + getCustomerContact()
				+ " " + "Customer Name: " + " " + getCustomerName() + " " + "Customer Address: " + " " + getCustomerAddress().getCity()
				+ " " + getCustomerAddress().getStreet()+ " " + getCustomerAddress().getZip()+ " " + getCustomerAddress().getZip());
	}
}
