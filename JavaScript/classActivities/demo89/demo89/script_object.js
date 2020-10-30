//Chapter 8, Objects
	
//Object constructor
let house = new Object();
//New obj properties
house.bedrooms = 3;
house.bathrooms = 2;
house.customer = "Anderson";
//object methods
house.build = function () {
	alert("The " + house.customer + " house has" + house.bedrooms + " bedrooms and " + house.bathrooms + " bathrooms.");
};

house.build();


//Object literal
var order = {
	customerName: "Jack Wilson",
	productName: "Xbox-One",
	productQty: 2
};

alert(order.customerName + " ordered " + order.productQty + " " + order.productName);

//object constructor function
function Customer(fName, lName, eMail) {
	this.first = fName;
	this.last = lName;
	this.mail = eMail;
}

//Function to use above object
function CustomerInfo() {

	var firstName = document.getElementById("fname").value;
	var lastName = document.getElementById("lname").value;
	var email = document.getElementById("email").value;

	var customer1 = new Customer(firstName, lastName, email);

	document.getElementById("objConst").textContent = customer1.first + " " + customer1.last + "'s email address is: " + customer1.mail;
}
//runPage
/*
function runPage() {
	myObject();
}
*/

//Event Listeners
//window.addEventListener("load", runPage);
submit.addEventListener("click", CustomerInfo);