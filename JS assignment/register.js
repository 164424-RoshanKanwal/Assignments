function userInfo(){
var name = document.getElementById("name");
var email = document.getElementById("email");
var address = document.getElementById("address")
var mobile = document.getElementById("mobile");
var cpassword = document.getElementById("cpassword");
var password = document.getElementById("password");


if(password.value == cpassword.value){
 document.write(" Username: " +
 name.value +"<br>"+ " Email-Id: " + email.value +"<br>"+ " Address: " +
 address.value + "<br>"+" Mobile Number: " + mobile.value);
}
else {
alert("Password did not match. Try again!");
}

}