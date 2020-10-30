//Chapter 5 practice
//Oliver Conover

//Math Variables
var num1 = parseFloat(prompt("Number 1:"));
var num2 = parseFloat(prompt("Number 2:"));
var value;
//Get result <p> elements
var resultBox = document.getElementById("displayResult");

//event listener
var btnAdd = document.getElementById("add");

function Add() {
    value = num1 + num2;
    resultBox.textContent = value;
}
function Subtract() {
    value = num1 - num2;
    resultBox.textContent = value;
}
function Divide() {
    value = num1 / num2;
    resultBox.textContent = value;
}
function Multiply() {
    value = num1 * num2;
    resultBox.textContent = value;
}
function Modulus() {
    value = num1 % num2;
    resultBox.textContent = value;
}
function Increment() {
    value = num1++;
    resultBox.textContent = value;
}
function Decrement() {
    value = num1--;
    resultBox.textContent = value;
}

function DoAverage() {
    let num1 = parseFloat(prompt("Num1: "));
    let num2 = parseFloat(prompt("Num2: "));
    let num3 = parseFloat(prompt("Num3: "));
}

//Event Listener
btnAdd.addEventListener("click", Add);