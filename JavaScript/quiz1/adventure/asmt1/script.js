//Oliver Conover
//Quiz 1
//28/09/2020

//Variables
var fishingDesc = "Travel far offshore the Florida coast and arm yourselves with fishing poles in this tropical excursion. The Florida coast is home to many unique species of fish, including but not limited to, the delicious Mahi Mahi.";
var dolphinDesc = "Take a boat tour up and down the Floridian coast for the chance to see live Dolphins in their natural habitats. These fun creatures love human interaction, and the boat captains carry dolphin treats on their vessels so you can get the chance for an aquatic one on one with these iconic mammals.";
var beachDesc = "Florida beaches are home to the United States whitest sands, tallest palms, and the sunniest days of the year. If fishing or making friends with dolphins isn't your cup of tea, we still offer relaxing waves and warm sands as a getaway option.";

var fishingDiv = document.getElementById("fishingInfo");
var dolphinDiv = document.getElementById("dolphinInfo");
var beachDiv = document.getElementById("beachInfo");

var fishBox = document.createElement("div");
fishBox.id = "fishResultBox";
fishBox.className = "resultBox";

var dolphinBox = document.createElement("div");
dolphinBox.id = "dolphinResultBox";
dolphinBox.className = "resultBox";

var beachBox = document.createElement("div");
beachBox.id = "beachResultBox";
beachBox.className = "resultBox";

var estimatedCost = "<p>Estimated Cost:</p>"

//Functions
function RevealInformation(columnNum) {

    //Column number is defined in HTML
    switch (columnNum) {
        case 1:
            //Each case reveals the new HTML and hides the unselected stuff
            fishingDiv.innerHTML = "<p>" + fishingDesc + "</p>" + RevealButton(columnNum);
            dolphinDiv.innerHTML = "";
            beachDiv.innerHTML = "";
            //Append result box
            fishingDiv.appendChild(fishBox);
            //Reveal button and hide other divs/buttons
            break;
        case 2:
            dolphinDiv.innerHTML = "<p>" + dolphinDesc + "</p>" + RevealButton(columnNum);
            beachDiv.innerHTML = "";
            fishingDiv.innerHTML = "";
            //Append result box
            dolphinDiv.appendChild(dolphinBox);
            break;
        case 3:
            dolphinDiv.innerHTML = "";
            fishingDiv.innerHTML = "";
            beachDiv.innerHTML = "<p>" + beachDesc + "</p>" + RevealButton(columnNum);
            //Append result box
            beachDiv.appendChild(beachBox);
            break;
    }
}

function RevealButton(columnNum) {

    //This adds a button based on the column number from the previous function
    let button;

    switch (columnNum) {
        case 1:
            //Add button the long way with a string because I didn't feel like changing it and its easier to clear information from a string anyways.
            button = "<button class=\"buttonStyle\" onclick=\"CalculateFishCost()\">Estimate Cost</button>";
            break;
        case 2:
            button = "<button class=\"buttonStyle\" onclick=\"CalculateDolphinCost()\">Estimate Cost</button>";
            break;
        case 3:
            button = "<button class=\"buttonStyle\" onclick=\"CalculateBeachCost()\">Estimate Cost</button>";
            break;
    }
    return button;
}

//Calculates the cost for fishing trip
function CalculateFishCost() {
    let numPeople = parseInt(prompt("Enter total number of vacationers"));

    let poleRental = 100 * numPeople;
    let captainRental = 50 * numPeople;
    let maxBoaters = 4;
    let boatRental = 45 * (numPeople / maxBoaters); //Only a certain number of people fit on a boat at any given time
    //Output results in created result box
    fishBox.innerHTML = "<p>Estimated Cost:</p>" + "<p>" + "$" + (poleRental + captainRental + boatRental) + "</p>";
}
//Calculates cost for the beach
function CalculateBeachCost() {
    let numPeople = parseInt(prompt("How many beachgoers?"));

    let umbrellaRental = 15 * numPeople;
    let towelsRental = 7 * numPeople;
    let hotelRoomCapacity = 5;
    let hotelRental = 150 * (numPeople / hotelRoomCapacity);

    beachBox.innerHTML = estimatedCost + "<p>" + "$" + (umbrellaRental + towelsRental + hotelRental) + "</p>";
}
//Calculates cost for dolphin excursion
function CalculateDolphinCost() {
    let numPeople = parseInt(prompt("How many adventurists?"));

    let dolphinFood = 15 * numPeople;
    let insurance = 35 * numPeople;
    let tourCost = 65 * numPeople;

    dolphinBox.innerHTML = estimatedCost + "<p>" + "$" + (dolphinFood + insurance + tourCost) + "</p>";
}