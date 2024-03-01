// script.js

function checkEvenOrOdd() {
    var userInput = prompt("Enter a number:");
    var number = parseInt(userInput);

    if (isNaN(number)) {
        alert("Please enter a valid number.");
        return;
    }

    var result = number % 2 === 0 ? "Even" : "Odd";

    document.getElementById("resultParagraph").innerHTML = "The number is " + result + ".";
}
