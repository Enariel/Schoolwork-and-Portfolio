#include <iostream>
#include <string>
#include <fstream>

using namespace std;

#ifndef PlayerClasses_H
#define PlayerClasses_H

class PlayerClasses
{
public:
	//Public variables because I'm a secure-less heathen.
	string className, classDesc, primaryAbility, prof1, prof2, equipProfs, fileName;
	int classChoice = 0, hitDie = 0;
	const char* proficiencies[6] = { "Strength", "Constitution", "Dexterity", "Charisma", "Wisdom", "Intelligence" };
	ifstream classFile;

	//Public functions
	void GetClass(int);
};
#endif

