//Variables
var homeAirport = "", destinationAirport = "" //The airports chosen from the label elements
var airlines = ["Aer Azeroth", "Alduin Airlines", "Air Andraste", "Tamriel Airlines", "Fly! You fools! Air", "Flight 9 3/4"]; //Array of airlines
var ticketPrices = [1050.05, 1075.50, 2015.10, 2000.75, 1000.65, 950.30, 870.00, 920.90, 755.00, 840.00, 650.85, 345.00, 965.40, 265.00, 195.95, 375.00, 540.35, 650.00, 675.00, 725.00];
var output = document.getElementById("output");
//This isnt mine, this is for number formatting via https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Text_formatting
const priceFormat = new Intl.NumberFormat('en-US',
    {
        style: 'currency', currency: 'USD',
        minimumFractionDigits: 2 //I changed this tho
    });

//Functions

//This function is called when a change is made to the selection "onChange"
function GetHomeAirport(selection) {
    //Its a bit redundant but this lets me set a default value to homeAirport unless a change is made
    let home = selection.options[selection.selectedIndex];
    homeAirport = home;
}

//This function works like the one above, except it gets the destination
function GetDestinationAirport(selection) {
    let destination = selection.options[selection.selectedIndex];
    destinationAirport = destination;
}

//Creates a list of paragraph elements comparing each airline
function FindFlights() {
    //Make sure the output div is empty each time this is called 
    output.innerHTML = "";
    //Create a list for each airline and generate prices for the destinations selected
    for (i = 0; i < airlines.length; i++) {
        //This generates the proper html elements so the CSS can style properly
        let randomPrice = Math.floor(Math.random() * ticketPrices.length); //This gets a random index for ticket prices
        //This part is messy, if you have an idea on how to clean it up let me know
        output.innerHTML += "<div class = \"list\">" + "<p class = \"airlines\">" + airlines[i] + "</p>" + " " + "<p class = \"homeAirport\">" + homeAirport.innerText + "</p>" + "<p class = \"to\">" + " ---> " + "</p>" + "<p class = \"destination\">" + destinationAirport.innerText + "</p>" + " " + "<p class = \"price\">" + priceFormat.format(ticketPrices[randomPrice]) + "</p>" + "</div>";
    }
    
}

//Event listeners