#include <iostream>
#include <string>
#include <fstream>

using namespace std;

#ifndef PlayerRace_H
#define PlayerRace_H

class PlayerRace
{
public:
	//Public variables because I'm a secure-less heathen.
	//Most character details is in strings, some determined by integers from a file.
	string raceName, raceDesc, subRaceName, subRaceDesc, alignment, size, raceFileName, subRaceFileName;

	int languages[5];
	string passiv[5];
	string subPassiv[5];
	
	int raceChoice = 0, subRaceChoice = 0, asi = 0, asi2 = 0, subasi=0, maxAge = 0, speed = 0, asiType1, subAsiType1, asiType2;
	
	//Race details, ints are processed with these.
	const char* proficiencies[7] = { "Strength", "Constitution", "Dexterity", "Charisma", "Wisdom", "Intelligence", "" };
	const char* language[18] = { "Abyssal", "Celestial", "Common", "Deep Speech", "Draconic", "Dwarvish", "Elvish", "Giant", "Gnomish", "Goblin", "Halfling", "Infernal", "Orc", "Primordial", "Sylvan", "Undercommon", "-", "CHOICE" };
	char const* subRace[9] = { "Hill Dwarf", "Mountain Dwarf", "High Elf", "Wood Elf", "Drow", "Forest Gnome", "Rock Gnome", "Lightfoot", "Stout" };
	//Files for accessing the data.
	ifstream raceFile;
	ifstream subRaceFile;

	//Public functions
	//Finds the correct Race file
	void GetRace(int);
	//Finds the correct subrace corresponding to the players race choice.
	void ChooseSubRace(int);
	//Further details about the SubRace
	void GetSubRace(int, int);
	//Dragonborns don't have a subrace, instead they get to choose a color-type.
	void ChooseDragonColor();

};
#endif

