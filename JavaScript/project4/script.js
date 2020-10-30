/*
 Oliver Conover
 25/10/2020
 Project 4
 Prof Minnick
 JavaScript
 */

/*
==============================================
                   Objects
----------------------------------------------
- Objects must be declared before anything
else in order to use them.
- Skill class is just a name and a desc.
- The character class lists more details 
with information about a character you can 
create.
==============================================
*/
class Skill
{
    constructor(aName, aDesc, aCost)
    {
        this.sName = aName;
        this.sDesc = aDesc;
        this.sCost = aCost;
    }
}
class Character
{
    constructor(aName, aDesc, aHP, aMana, aSkill1, aSkill2)
    {
        this.cName = aName;
        this.cDesc = aDesc;
        this.cHP = aHP;
        this.cMana = aMana;
        this.cSkill1 = aSkill1;
        this.cSkill2 = aSkill2;
    }
}
/*
==============================================
            Variables and References
----------------------------------------------
- References are variab;es that reference
HTML elements in the existing document.
- Variables are objects that are used and 
modified in the script only.
==============================================
*/

//References
var headers = document.getElementsByTagName('header'); //get the header elements
var objContainer = document.getElementById('objectContainer');
var objHeader = objContainer.querySelector('h2');
var objElements = objContainer.querySelectorAll('p');
var charBtn = document.getElementById('createCharacter');
//Variables
var mainHeader = headers[0]; //Since the references above return arrays/lists, i have to access the elements i want with indexes.
var desc = objElements[1];
var hp = objElements[2];
var mana = objElements[3];
var skill1 = objElements[4];
var skill2 = objElements[5];

//Skills were generated, then copy-pasted from: https://5emagic.shop/spellbook/generic-spell-book-c01cf7e3b
var skills =
    [
    new Skill('Chromatic Orb', 'You hurl a 4-inch-diameter sphere of energy at a creature that you can see within range.', 10),
    new Skill('Burning Hands', 'As you hold your hands with thumbs touching and fingers spread, a thin sheet of flames shoots forth from your outstretched fingertips.', 15),
    new Skill('Comprehend Languages', 'You understand the literal meaning of any spoken language that you hear.', 3),
    new Skill('Cloud of Daggers', 'You fill the air with spinning daggers in a cube 5 feet on each side, centered on a point you choose within range.', 17),
    new Skill('Darkness', 'Magical darkness spreads from a point you choose within range to fill a 15-foot-radius sphere for the duration.', 7),
    new Skill('Continual Flame', 'A flame, equivalent in brightness to a torch, springs forth from an object that you touch. ', 2),
    new Skill('Fear', 'You project a phantasmal image of a creature\'s worst fears.', 6),
    new Skill('Control Water', 'Until the spell ends, you control any freestanding water inside an area you choose that is a cube up to 100 feet on a side. ', 25),
    new Skill('Control Earth', 'Until the spell ends, you control any earth inside an area you choose that is a cube up to 100 feet on a side. ', 25),
    new Skill('Control Fire', 'Until the spell ends, you control fire from your fingertips', 25),
    new Skill('Control Air', 'Until the spell ends, you control air inside an area you choose that is a cube up to 100 feet on a side. ', 25),
    new Skill('Conjure Elemental', 'You call forth an elemental servant', 15),
    new Skill('Meteor Swarm', 'Blazing orbs of fire plummet to the ground at four different points you can see within range.', 30)
    ];
var characters = [];
/*
==============================================
    Functions, Calls, and Event Listeners
----------------------------------------------
- This section is just function definitions
and declarations. At the bottom is necessary
event listeners.
==============================================
*/

//Functions
function AddHeader()
{
    //creating temp variables to add new elements
    let hElem = document.createElement('h2');
    let hInfo = document.createTextNode('Project 4 - Working with Objects');
    let hElem2 = document.createElement('h3');
    let hInfo2 = document.createTextNode('Author: Oliver Conover')
    //appending children with new elements.
    hElem.appendChild(hInfo);
    hElem2.appendChild(hInfo2);
    mainHeader.appendChild(hElem);
    mainHeader.appendChild(hElem2);
}
function CreateCharacter()
{
    //Create character
    objHeader.innerText = 'New Character';
    let tempName = prompt('Give your character a new name: ');
    let tempDesc = prompt('Give your character a new backstory: ');
    let randHP = Math.floor(Math.random() * 50) + 25; //Returns random HP amount from 25 to 50;
    let randMana = Math.floor(Math.random() * 75) + 25;
    let randSkill1 = skills[Math.floor(Math.random() * skills.length)];
    let randSkill2 = skills[Math.floor(Math.random() * skills.length)];
    let player = new Character(tempName, tempDesc, randHP, randMana, randSkill1, randSkill2);

    //Add to characters list in the event we wanna mess with this later
    characters.push(player);

    //Send to html
    objHeader.innerText = player.cName;
    desc.innerText = 'Description: ' + player.cDesc;
    hp.innerText = "Max Hit Points: " + player.cHP;
    mana.innerText = "Max Mana: " + player.cMana;
    skill1.innerText = player.cSkill1.sName + ' - ' + player.cSkill1.sDesc;
    skill2.innerText = player.cSkill2.sName + ' - ' + player.cSkill2.sDesc;
}

function DefaultCharacter()
{
    //Default player object
    let player = new Character('Professor Minnick', 'Prof Minnick is knowledgeable in the arcane magicks of JavaScript.', 'Infinite', 'Too much for our mortal brains to comprehend', skills[12], skills[2]);

    //Send to html
    objHeader.innerText = player.cName;
    desc.innerText = 'Description: ' + player.cDesc;
    hp.innerText = "Max Hit Points: " + player.cHP;
    mana.innerText = "Max Mana: " + player.cMana;
    skill1.innerText = player.cSkill1.sName + ' - ' + player.cSkill1.sDesc;
    skill2.innerText = player.cSkill2.sName + ' - ' + player.cSkill2.sDesc;
}

//Calls
AddHeader();
DefaultCharacter();

//Event listeners
charBtn.addEventListener('click', CreateCharacter);