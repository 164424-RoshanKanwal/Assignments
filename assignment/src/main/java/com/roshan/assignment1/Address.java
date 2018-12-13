package com.roshan.assignment1;

public class Address {

	/*Create an Address class with the following attributes:- street, city, state, zip, country
	Create an Customer class with the following attributes:- customerId, customerName, customerContact, customerAddress.
	Inject the Address bean into Customer bean using setter injection
	Create a Test class with main() method, get Customer bean from ApplicationContext object and print details of Customer.
	Also write the JUnit Test cases for above program.
	- Modify the above application and inject the bean using constructor injection
	- Use XML based Configuraion.*/
	
	private String street;
	private String city;
	private String state;
	private String zip;
	private String country;
	
	public String getStreet() {
		return street;
	}
	public void setStreet(String street) {
		this.street = street;
	}
	public String getCity() {
		return city;
	}
	public void setCity(String city) {
		this.city = city;
	}
	public String getState() {
		return state;
	}
	public void setState(String state) {
		this.state = state;
	}
	public String getZip() {
		return zip;
	}
	public void setZip(String zip) {
		this.zip = zip;
	}
	public String getCountry() {
		return country;
	}
	public void setCountry(String country) {
		this.country = country;
	}
	
	
	
}
