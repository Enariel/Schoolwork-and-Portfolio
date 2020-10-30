/*
    Oliver Conover
    JavaScript Programming 3598
    Prof. Minnick
    Project 1
 */
//Variables
var revealText = document.getElementById("revealText"); 
var revealButton = document.getElementByID("mainButton");//I know this var isn't used. Using a variable in the functions didnt work. Im not entirely sure why...

/*
 * These functions also changes several attributes about the button in order to properly execute.
 The goal is to click the button to reveal a text. Then it changes the style of the button.
 Clicking the button again will hide the text.
 */

//This function reveals a string in the main html element
function ShowText() {
    document.getElementById("mainButton").id = "mainButtonHide";
    document.getElementById("mainButtonHide").innerHTML = "Hide Text";
    document.getElementById("mainButtonHide").setAttribute("onClick", "HideText()");
    revealText.innerHTML = "<p>Programming has allowed me to do things I could not dream of doing.Its crazy to think about everything involving computers, taking several classes and coding for over a year, this stuff still seems like magic to me.Writing it makes me feel like a wizard.You\'re telling me that writing words in an IDE that execute commands in machines with rare metals and a little electricity is anything BUT magic?</p><p>Jokes aside, having side-projects involving code are a great way to train your brain through logic-based problems. I feel a little smarter every day that I tackle a new programming challenge. It is a great sense of fulfillment. I have come far from Console.Print(\'Hello World\') and am currently coding video-games as a side project.</p>";
}
function HideText() {
    document.getElementById("mainButtonHide").id = "mainButton";
    document.getElementById("mainButton").innerHTML = "Reveal!";
    document.getElementById("mainButton").setAttribute("onClick", "ShowText()");
    revealText.innerHTML = "";
}