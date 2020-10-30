/* 
   Murfreesboro Regional Soccer League
   Filename: script.js

   Author:   Oliver Conover
   Date:     20/04/2020
   HTML5 and CSS3 Illustrated Unit M, Independent Challenge 2
 */

/* Variables */

var redButton = document.getElementById(".red-team-button");
var blueButton = document.getElementById(".blue-team-button");
var greenButton = document.getElementById(".green-team-button");
var yellowButton = document.getElementById(".yellow-team-button");
var redSchedule = document.getElementsByClassName(".red-team-schedule");
var blueSchedule = document.getElementsByClassName(".blue-team-schedule");
var greenSchedule = document.getElementsByClassName(".green-team-schedule");
var yellowSchedule = document.getElementsByClassName(".yellow-team-schedule");

/* Functions */

function showRed() {
    redSchedule.className = "red-team-schedule show";
    blueSchedule.className = "blue-team-schedule";
    greenSchedule.className = "green-team-schedule";
    yellowSchedule.className = "yellow-team-schedule";
}
function showBlue() {
    redSchedule.className = "red-team-schedule";
    blueSchedule.className = "blue-team-schedule show";
    greenSchedule.className = "green-team-schedule";
    yellowSchedule.className = "yellow-team-schedule";
}
function showGreen() {
    redSchedule.className = "red-team-schedule";
    blueSchedule.className = "blue-team-schedule";
    greenSchedule.className = "green-team-schedule show";
    yellowSchedule.className = "yellow-team-schedule";
}
function showYellow() {
    redSchedule.className = "red-team-schedule";
    blueSchedule.className = "blue-team-schedule";
    greenSchedule.className = "green-team-schedule";
    yellowSchedule.className = "yellow-team-schedule show";
}

/* Event Listeners */

redButton.addEventListener("click", showRed);