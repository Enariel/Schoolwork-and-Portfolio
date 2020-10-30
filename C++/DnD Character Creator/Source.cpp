/*
Author: Oliver Conover
Date Started: 06/May/2020
About this Program: This program takes inspiration from dungeons and dragons.
This program helps create a character for a future session of DnD. 
This program also creates a roll of stats to allocate for your character, however manual input is still necessary to create a character sheet, but this program aims to minimize that. 

Disclaimer: Any information and text is recieved via official DnD channels and no claims are made that this is original content made by me that is being displayed. This is merely a tool to convey information about the game. 
*/

#include <iostream>
#include <string>
#include <fstream>
#include <iomanip>
#include "PlayerClasses.h"
#include "PlayerRace.h"

using namespace std;

//Global variables
ifstream readFile;
ofstream characterSheet;
string playerName;

char const* classes[12] = { "Barbarian", "Bard", "Cleric", "Druid", "Fighter", "Monk", "Paladin", "Ranger", "Rogue", "Sorcerer", "Warlock", "Wizard" };
char const* races[9] = {"Dragonborn", "Dwarf", "Elf", "Gnome", "Half-Elf", "Half-Orc", "Halfling", "Human", "Tiefling"};

int classChoice, raceChoice, subRaceChoice;

PlayerClasses pc;
PlayerRace pr;

void ChooseRace()
{
	cout << "Choose a race for your character, enter the options using the numbers 0-8" << endl;

	for (int i = 0; i <= 8; i++)
	{
		cout << "[" << i << "]" << races[i] << endl;
	}

	cin >> raceChoice;

	if (raceChoice >= 0 && raceChoice <= 8)
	{
		cout << "You've selected: " << races[raceChoice] << endl;

		//find race information
		pr.GetRace(raceChoice);

		cout << pr.raceName << endl << pr.raceDesc << endl;

	}
	else if (raceChoice < 0 || raceChoice > 8)
	{
		cout << "Please enter a valid option. " << endl;
		ChooseRace();
	}
}

void ChooseClass()
{
	cout << "Choose a class for your characer, enter the options using numbers 0-11" << endl;
	
	for (int i = 0; i <= 11; i++)
	{
		cout << "[" << i << "]" << classes[i] << endl;
	}

	cin >> classChoice;

	if (classChoice >= 0 && classChoice <= 11)
	{
		cout << "You've selected: " << classes[classChoice] << endl;
		pc.GetClass(classChoice);
	}
	else if (classChoice < 0 || classChoice > 11 )
	{
		cout << "Please enter a valid option. " << endl;
		ChooseClass();
	}
}

void FormatSheetOutput(int raceChoice)
{
	//basically the same, but puts it all in a file.
	//Open character sheet file to add to.
	characterSheet.open(playerName + " Character Sheet.txt");

	//Copy paste from above replacing cout with file.
	//Formatting variables
	string sep = "-";
	string hsep = "|";
	//Output Name
	characterSheet << "* Character Name *" << endl;
	characterSheet << setw(10) << " " << playerName << endl;
	//Basic information
	characterSheet << "** Languages **" << endl;
	//Print out all languages
	for (int i = 0; i <= 4; i++)
	{
		characterSheet << setw(10) << " " << pr.language[pr.languages[i]] << endl;
	}
	characterSheet << endl;

	//TODO Create stat row

	//Output Character Race Stats as well as Subrace Stats
	characterSheet << "** Stats ** " << endl << endl;

	characterSheet << setw(10) << " " << "* Race *" << endl << endl
		<< setw(15) << " " << "[" << pr.raceName << "]" << endl << endl
		<< setw(20) << " " << "Description: " << pr.raceDesc << endl << endl;


	if (raceChoice == 1 || raceChoice == 2 || raceChoice == 3 || raceChoice == 6)
		//if-statement for subraces
	{
		characterSheet << setw(10) << " " << "* Sub-Race *" << endl << endl
			<< setw(15) << " " << "[[" << pr.subRaceName << "]]" << endl << endl
			<< setw(20) << " " << "Description: " << pr.subRaceDesc << endl << endl;

		characterSheet << "* Ability Score Increases *" << endl << endl;
		characterSheet << setw(10) << " " << pr.proficiencies[pr.asiType1] << setw(10) << " " << pr.asi << endl;
		characterSheet << setw(10) << " " << pr.proficiencies[pr.asiType2] << setw(10) << " " << pr.asi2 << endl;
		characterSheet << setw(10) << " " << pr.proficiencies[pr.subAsiType1] << setw(10) << " " << pr.subasi << endl << endl;

		characterSheet << "** Special Passives **" << endl << endl;

		for (int i = 0; i <= 4; i++)
		{
			characterSheet << setw(10) << " " << "-" << pr.passiv[i] << endl;
		}

		characterSheet << setw(5) << " " << "* Sub-Race Bonus Passives *" << endl << endl;

		for (int i = 0; i <= 4; i++)
		{
			characterSheet << setw(10) << " " << "-" << pr.subPassiv[i] << endl;
		}
	}
	else
	{
		characterSheet << "** Ability Score Increases **" << endl << endl;
		characterSheet << setw(10) << " " << pr.proficiencies[pr.asiType1] << setw(10) << " " << pr.asi << endl;
		characterSheet << setw(10) << " " << pr.proficiencies[pr.asiType2] << setw(10) << " " << pr.asi2 << endl;

		characterSheet << "** Special Passives **" << endl << endl;

		for (int i = 0; i <= 4; i++)
		{
			characterSheet << setw(10) << " " << "-" << pr.passiv[i] << endl;
		}
	}

	//Output Character Class Stats
	characterSheet << "** Class Information **" << endl << endl;

	characterSheet << setw(10) << " " << "Class: " << pc.className << endl
		<< setw(10) << " " << "Description: " << pc.classDesc << endl;
	characterSheet << setw(5) << " " << "Details: " << endl
		<< setw(10) << " " << "Hitpoint Dice: " << pc.hitDie << endl
		<< setw(10) << " " << "Primary Stat: " << pc.primaryAbility << endl
		<< setw(10) << " " << "Proficiencies: " << endl
		<< setw(15) << " " << pc.prof1 << endl
		<< setw(15) << " " << pc.prof2 << endl
		<< setw(10) << " " << "Equipment Proficiency: " << endl
		<< setw(15) << " " << pc.equipProfs << endl << endl;

	//close the character sheet file.
	characterSheet.close();
}

void FormatSheet(int raceChoice)
{
	//Formatting variables
	string sep = "-";
	string hsep = "|";
	//Output Name
	cout << "* Character Name *" << endl;
	cout << setw(10) << " " << playerName << endl;
	//Basic information
	cout << "** Languages **" << endl;
	//Print out all languages
	for (int i = 0; i <= 4; i++)
	{
		cout << setw(10) << " " << pr.language[pr.languages[i]] << endl;
	}
	cout << endl;

	//TODO Create stat row

	//Output Character Race Stats as well as Subrace Stats
	cout << "** Stats ** " << endl << endl;

	cout << setw(10) << " " << "* Race *" << endl << endl
		<< setw(15) << " " << "[" << pr.raceName << "]" << endl << endl
		<< setw(20) << " " << "Description: " << pr.raceDesc << endl << endl;

	
	if (raceChoice == 1 || raceChoice == 2 || raceChoice == 3 || raceChoice == 6)
		//if-statement for subraces
	{
		cout << setw(10) << " " << "* Sub-Race *" << endl << endl
			<< setw(15) << " " << "[[" << pr.subRaceName << "]]" << endl << endl
			<< setw(20) << " " << "Description: " << pr.subRaceDesc << endl << endl;

		cout << "* Ability Score Increases *" << endl << endl;
		cout << setw(10) << " " << pr.proficiencies[pr.asiType1] << setw(10) << " " << pr.asi << endl;
		cout << setw(10) << " " << pr.proficiencies[pr.asiType2] << setw(10) << " " << pr.asi2 << endl;
		cout << setw(10) << " " << pr.proficiencies[pr.subAsiType1] << setw(10) << " " << pr.subasi << endl << endl;

		cout << "** Special Passives **" << endl << endl;

		for (int i = 0; i <= 4; i++)
		{
			cout << setw(10) << " " << "-" << pr.passiv[i] << endl;
		}

		cout << setw(5) << " " << "* Sub-Race Bonus Passives *" << endl << endl;

		for (int i = 0; i <= 4; i++)
		{
			cout << setw(10) << " " << "-" << pr.subPassiv[i] << endl;
		}
	}
	else
	{
		cout << "** Ability Score Increases **" << endl << endl;
		cout << setw(10) << " " << pr.proficiencies[pr.asiType1] << setw(10) << " " << pr.asi << endl;
		cout << setw(10) << " " << pr.proficiencies[pr.asiType2] << setw(10) << " " << pr.asi2 << endl;

		cout << "** Special Passives **" << endl << endl;

		for (int i = 0; i <= 4; i++)
		{
			cout << setw(10) << " " << "-" << pr.passiv[i] << endl;
		}
	}

	//Output Character Class Stats
	cout << "** Class Information **" << endl << endl;

	cout << setw(10) << " " << "Class: " << pc.className << endl
		<< setw(10) << " " << "Description: " << pc.classDesc << endl;
	cout << setw(5) << " " << "Details: " << endl
		<< setw(10) << " " << "Hitpoint Dice: " << pc.hitDie << endl
		<< setw(10) << " " << "Primary Stat: " << pc.primaryAbility << endl
		<< setw(10) << " " << "Proficiencies: " << endl
		<< setw(15) << " " << pc.prof1 << endl
		<< setw(15) << " " << pc.prof2 << endl
		<< setw(10) << " " << "Equipment Proficiency: " << endl
		<< setw(15) << " " << pc.equipProfs << endl << endl;

	//Make it a file by calling this method.
	FormatSheetOutput(raceChoice);
}

int main()
{
	//Set up character with a name
	cout << "Enter your name: ";
	cin >> playerName;

	//Enter Character Race
	ChooseRace();
	//Enter Character Class
	ChooseClass();

	//Formatting for exporting to .txt file
	FormatSheet(raceChoice);

	return 0;
}