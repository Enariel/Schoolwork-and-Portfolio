/*
 	Student Name: Oliver Conover
	File Name: quiz2 index.html
	Date: 29/10/2020
 */

/**
 * ==================================
 *				Objects
 * ==================================
 */

//Ticket object
class Ticket
{
    constructor(aName, aDept, aLoc, aMail, aPhone, aIssue)
	{
		this.name = aName;
		this.dept = aDept;
		this.loc = aLoc;
		this.mail = aMail;
		this.phone = aPhone;
		this.issue = aIssue;
    }
}

/**
 * ==================================
 *		References and Variables
 * ==================================
 */

//References
var subBtn = document.getElementById('submitBtn');
//Put all input fields in an array.
var inputFields = [
	document.getElementById('nameinput'),
	document.getElementById('deptinput'),
	document.getElementById('locationinput'),
	document.getElementById('emailinput'),
	document.getElementById('phoneinput'),
	document.getElementById('issue')];
var hidden = document.querySelector('section');
var ticketSections = hidden.getElementsByTagName('div');
var ticketFor = ticketSections[0];
var ticketDesc = ticketSections[1];
var errorElem = document.getElementById('errorMessage');
//Variables
var pElem = document.createElement('p');

/**
 * ==================================
 *				Functions
 * ==================================
 */
function CreateNewTicket()
{
	//Create new ticket object with inputField indexes. Pass it as a parameter in the display function
	let newtik = new Ticket(
		inputFields[0].value,
		inputFields[1].value,
		inputFields[2].value,
		inputFields[3].value,
		inputFields[4].value,
		inputFields[5].value);

	DisplayTicket(newtik);
}

function RejectTicket()
{
	//Clears out all the input fields by replacing contents with an empty string
	for (var i = 0; i <= inputFields.length - 1; i++)
	{
		inputFields[i].value = '';
    }
}

function DisplayTicket(ticket)
{
	//Show the tickey summary
	hidden.style.display = 'block';
	ticketFor.style.display = 'block';
	ticketDesc.style.display = 'block';

	//Append and fill out information with the parameter.

	let contents = [ticket.name, ticket.dept, ticket.loc, ticket.mail, ticket.phone, ticket.issue];

	//To clear the contents before every for loop, I had to delete ALL of the inner html. This isnt the best solution, but after nearly 200+ lines of code in one sitting this is what I'm doing. 
	ticketFor.innerHTML = "<h3>Ticket Submitted by</h3>";
	ticketDesc.innerHTML = "<h3>Summary of the Issue</h3>";

	//cycle through contents, add appropriate elements to html at each index instead of making a billion variables.
    for (var i = 0; i <= contents.length - 1; i++)
	{
        if (i < contents.length - 1)
		{
			//Clear information first just in case

			let p = document.createElement("p");
			let pNode = document.createTextNode(contents[i]);

			p.appendChild(pNode);
			ticketFor.appendChild(p);
		}
        if (i == contents.length - 1)
		{

			let p = document.createElement("p");
			let pNode = document.createTextNode(contents[i]);

			p.appendChild(pNode);
			ticketDesc.appendChild(p);
        }
    }
}

function OnValidate()
{
	//Cycles through the list and checks each index.value if it is an empty string or null value.
	//Returns false if its empty, therefore Validate() will execute an alert and reset the form.
    for (var i = 0; i <= inputFields.length - 1; i++)
	{
		if (inputFields[i].value == '' || inputFields[i].value == null)
		{
			return false;
        }
	}
	return true;
}

function Validate()
{
	if (OnValidate() == true) //Form is validated, create new ticket with this information
	{
		errorElem.style.display = 'none';
		errorElem.innerHTML = '';
		CreateNewTicket();
	}
	else if (OnValidate() == false)
	{
		//Clear fields and resets form
		alert('One or more fields are empty, please restart the ticketing process.');

		errorElem.style.display = 'block';
		errorElem.innerHTML = 'Please properly fill out ticket.';

		RejectTicket();
		//Also hide the ticket box
		hidden.style.display = 'none';
		ticketFor.style.display = 'none';
		ticketDesc.style.display = 'none';
    }
}

/**
 * ==================================
 *			Event Handlers
 * ==================================
 */

subBtn.addEventListener('click', Validate); //We check validation, and THEN call for a new ticket be created after validation returns TRUE