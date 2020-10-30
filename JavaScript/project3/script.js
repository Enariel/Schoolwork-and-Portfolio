/*
 Oliver Conover
 18/10/2020
 Prof Minnick
 JavaScript
 Project 3
 */

/*
 * ========================================
 *              Class Section
 * ========================================
 */
//classes (I know this wasnt covered, but I felt like I could do the requirements better)
//Animal is a base class which other classes will derive
class Animal {

    //Every animal shares these traits
    title = ""; //Its name.
    type = ['Mammal', 'Bird', 'Arthropod', 'Reptile', 'Amphibian', 'Fish']; //Each animal will only have one type with this specified list
    diet = ['Vegetarian', 'Omnivore', 'Carnivore']; //What is its primary diet
    size = ['really small', 'small', 'medium', 'large', 'really large'];

    //The indexes specifed for the arrays above
    typetype = 0;
    dietype = 0;
    sizetype = 0;

    constructor(atitle, atype, adiet, asize) {
        this.title = atitle;
        this.typetype = atype;
        this.dietype = adiet;
        this.sizetype = asize;
    }

    //Class functions to return specific values from arrays
    GetSize(sizetype) {
        return this.size[sizetype].toString();
    }
    GetDiet(dietype) {
        return this.diet[dietype].toString();
    }
    GetType(typetype) {
        return this.type[typetype].toString(); //lol
    }

    //This function will return information as a description. Currently broken.
    ShowDetails(typetype, dietype, sizetype) {
        let desc = `This is ${this.name} and they are a ${this.GetType(typetype)}. This creature has a ${this.GetDiet(dietype)}. ${this.name} is a ${this.GetSize(sizetype)} organism.`;
    }
}

//Classes below inherit from Animal
class Dog extends Animal {

    //We want these values to be inherited, so super() is used
    constructor(atitle, atype, adiet, asize) {
        super(atitle, atype, adiet, asize);
    }
}
class Lizard extends Animal {
    constructor(atitle, atype, adiet, asize) {
        super(atitle, atype, adiet, asize);
    }
}
class Cat extends Animal {
    constructor(atitle, atype, adiet, asize) {
        super(atitle, atype, adiet, asize);
    }
}
class Bug extends Animal {
    constructor(atitle, atype, adiet, asize) {
        super(atitle, atype, adiet, asize);
    }
}
class Fish extends Animal {
    constructor(atitle, atype, adiet, asize) {
        super(atitle, atype, adiet, asize);
    }
}

/*
 * ========================================
 *              Assignment Section
 * ========================================
 */

//Variables
var arrayIndex = 0;
var displayElement = document.getElementById('displayAnimals');
var displayDogs = document.getElementById('displayDogs');
var displayCats = document.getElementById('displayCats');
var displayLizards = document.getElementById('displayLizards');
var displayLizards = document.getElementById('displayFish');
var displayLizards = document.getElementById('displayBugs');
var buttonDisplay = document.getElementById('buttonDisplay');
//These are lists of classes created below
var animals = [];
var dogs = [new Dog('Jeremy the Dog', 0, 2, 3), new Dog('Roxy the Dog', 0, 2, 3), new Dog('Josie the Dog', 0, 2, 3)];
//These are all my actual pets below dogs
var cats = [new Cat('Thunder the Cat', 0, 2, 3), new Cat('Stormie the Cat', 0, 2, 3), new Cat('Nami the Cat', 0, 2, 3), new Cat('Persephone the Cat', 0, 2, 3)]
var lizards = [new Lizard('Dusty the Diamondback', 3, 1, 1), new Lizard('Aurora the Leopard Gecko', 3, 1, 1), new Lizard('Typhoon the Leopard Gecko', 3, 1, 1), new Lizard('Sandy the Snake', 3, 1, 1)]
//Functions

function AddToArray(animalArray) {
    //This function adds each array into one array animals[]
    animalArray.forEach(animal => animals.push(animal));
}

function ShowAllAnimals() {

    displayElement.innerHTML = ""; //Make sure the text doesnt get stacked by clearing it
    //Iterate through list and display information based on the animal at index i in the loop.
    for (i = 0; i < animals.length; i++) {
        displayElement.innerText += animals[i].title + " " + animals[i].GetType(animals[i].typetype) + " " + animals[i].GetDiet(animals[i].dietype) + " " + animals[i].GetSize(animals[i].sizetype) + "\n";
    }
}

function ShowPartialAnimals() {

    displayDogs.innerText = "";
    displayCats.innerText = "";
    displayFish.innerText = "";
    displayBugs.innerText = "";
    displayLizards.innerText = "";

    for (i = 0; i < animals.length; i++) {

        //Check to see what type of 'Animal' class it is
        //If [Class] : Animal then display in proper section
        if (animals[i] instanceof Dog) {
            displayDogs.innerText += animals[i].title + " " + animals[i].GetType(animals[i].typetype) + " " + animals[i].GetDiet(animals[i].dietype) + " " + animals[i].GetSize(animals[i].sizetype) + "\n";
        }
        else if (animals[i] instanceof Cat) {
            displayCats.innerText += animals[i].title + " " + animals[i].GetType(animals[i].typetype) + " " + animals[i].GetDiet(animals[i].dietype) + " " + animals[i].GetSize(animals[i].sizetype) + "\n";
        }
        else if (animals[i] instanceof Bug) {
            displayBugs.innerText += animals[i].title + " " + animals[i].GetType(animals[i].typetype) + " " + animals[i].GetDiet(animals[i].dietype) + " " + animals[i].GetSize(animals[i].sizetype) + "\n";
        }
        else if (animals[i] instanceof Lizard) {
            displayLizards.innerText += animals[i].title + " " + animals[i].GetType(animals[i].typetype) + " " + animals[i].GetDiet(animals[i].dietype) + " " + animals[i].GetSize(animals[i].sizetype) + "\n";
        }
        else if (animals[i] instanceof Fish) {
            displayFish.innerText += animals[i].title + " " + animals[i].GetType(animals[i].typetype) + " " + animals[i].GetDiet(animals[i].dietype) + " " + animals[i].GetSize(animals[i].sizetype) + "\n";
        }
        else {
            console.log("This animal isnt real")
        }
    }
}

//Add each different animal to animals[]
AddToArray(dogs);
AddToArray(cats);
AddToArray(lizards);

//TODO
function CreateAnimal() {

    console.log("Hello General Kenobi");

    let newAnimal = new Animal();

    let choice = parseInt(prompt("Choose an animal type: \n 1 - Dog, 2 - Lizard, 3 - Cat, 4 - Bug, 5 - Fish"));

    //If statement to make sure a number is between 1 and 5
    if (choice <= 0 || choice > 5) {
        choice = parseInt(prompt("Choose an animal type: \n 1 - Dog, 2 - Lizard, 3 - Cat, 4 - Bug, 5 - Fish"));
    }

    //Case switch for better handling of a simple choice. 
    switch (choice) {
        case 1:
            newAnimal = new Dog();
            newAnimal.typetype = 0;
            newAnimal.title = prompt("Name your new dog!");
            newAnimal.dietype = parseInt(prompt("What is its new diet? 0 - Vegetarian, 1 - Omnivore, or 2 - Carnivore"));
            if (newAnimal.dietype < 0 || newAnimal.dietype > 2) {
                newAnimal.dietype = parseInt(prompt("What is its new diet? 0 - Vegetarian, 1 - Omnivore, or 2 - Carnivore"));
            }
            newAnimal.sizetype = parseInt(prompt("How big is it? 0 - Really Small, 1 - Small, 2 - Medium, 3 - Large, 4 - Really Big."));
            if (newAnimal.sizetype < 0 || newAnimal.sizetype > 4) {
                newAnimal.sizetype = parseInt(prompt("How big is it? 0 - Really Small, 1 - Small, 2 - Medium, 3 - Large, 4 - Really Big."));
            }
            //Add your new creature to the list
            animals.push(newAnimal);
            break;
        case 2:
            newAnimal = new Lizard();
            newAnimal.typetype = 3;
            newAnimal.title = prompt("Name your new Lizard!");
            newAnimal.dietype = parseInt(prompt("What is its new diet? 0 - Vegetarian, 1 - Omnivore, or 2 - Carnivore"));
            if (newAnimal.dietype < 0 || newAnimal.dietype > 2) {
                newAnimal.dietype = parseInt(prompt("What is its new diet? 0 - Vegetarian, 1 - Omnivore, or 2 - Carnivore"));
            }
            newAnimal.sizetype = parseInt(prompt("How big is it? 0 - Really Small, 1 - Small, 2 - Medium, 3 - Large, 4 - Really Big."));
            if (newAnimal.sizetype < 0 || newAnimal.sizetype > 4) {
                newAnimal.sizetype = parseInt(prompt("How big is it? 0 - Really Small, 1 - Small, 2 - Medium, 3 - Large, 4 - Really Big."));
            }
            //Add your new creature to the list
            animals.push(newAnimal);
            break;
        case 3:
            newAnimal = new Cat();
            newAnimal.typetype = 0;
            newAnimal.title = prompt("Name your new cat!");
            newAnimal.dietype = parseInt(prompt("What is its new diet? 0 - Vegetarian, 1 - Omnivore, or 2 - Carnivore"));
            if (newAnimal.dietype < 0 || newAnimal.dietype > 2) {
                newAnimal.dietype = parseInt(prompt("What is its new diet? 0 - Vegetarian, 1 - Omnivore, or 2 - Carnivore"));
            }
            newAnimal.sizetype = parseInt(prompt("How big is it? 0 - Really Small, 1 - Small, 2 - Medium, 3 - Large, 4 - Really Big."));
            if (newAnimal.sizetype < 0 || newAnimal.sizetype > 4) {
                newAnimal.sizetype = parseInt(prompt("How big is it? 0 - Really Small, 1 - Small, 2 - Medium, 3 - Large, 4 - Really Big."));
            }
            //Add your new creature to the list
            animals.push(newAnimal);
            break;
        case 4:
            newAnimal = new Bug();
            newAnimal.typetype = 2;
            newAnimal.title = prompt("Name your new Bug!");
            newAnimal.dietype = parseInt(prompt("What is its new diet? 0 - Vegetarian, 1 - Omnivore, or 2 - Carnivore"));
            if (newAnimal.dietype < 0 || newAnimal.dietype > 2) {
                newAnimal.dietype = parseInt(prompt("What is its new diet? 0 - Vegetarian, 1 - Omnivore, or 2 - Carnivore"));
            }
            newAnimal.sizetype = parseInt(prompt("How big is it? 0 - Really Small, 1 - Small, 2 - Medium, 3 - Large, 4 - Really Big."));
            if (newAnimal.sizetype < 0 || newAnimal.sizetype > 4) {
                newAnimal.sizetype = parseInt(prompt("How big is it? 0 - Really Small, 1 - Small, 2 - Medium, 3 - Large, 4 - Really Big."));
            }
            //Add your new creature to the list
            animals.push(newAnimal);
            break;
        case 5:
            newAnimal = new Fish();
            newAnimal.typetype = 5;
            newAnimal.title = prompt("Name your new Fish!");
            newAnimal.dietype = parseInt(prompt("What is its new diet? 0 - Vegetarian, 1 - Omnivore, or 2 - Carnivore"));
            if (newAnimal.dietype < 0 || newAnimal.dietype > 2) {
                newAnimal.dietype = parseInt(prompt("What is its new diet? 0 - Vegetarian, 1 - Omnivore, or 2 - Carnivore"));
            }
            newAnimal.sizetype = parseInt(prompt("How big is it? 0 - Really Small, 1 - Small, 2 - Medium, 3 - Large, 4 - Really Big."));
            if (newAnimal.sizetype < 0 || newAnimal.sizetype > 4) {
                newAnimal.sizetype = parseInt(prompt("How big is it? 0 - Really Small, 1 - Small, 2 - Medium, 3 - Large, 4 - Really Big."));
            }
            //Add your new creature to the list
            animals.push(newAnimal);
            break;
    }

    //Refresh list
    ShowAllAnimals();
    ShowPartialAnimals();
}

//Event handlers
buttonDisplay.addEventListener('click', CreateAnimal);
displayElement.onload = ShowAllAnimals(), ShowPartialAnimals(); //OnLoad