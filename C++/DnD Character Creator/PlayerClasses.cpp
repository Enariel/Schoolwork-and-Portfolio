//PlayerClasses function definitions

#include "PlayerClasses.h"

void PlayerClasses::GetClass(int choice)
{
	classChoice = choice;
	cout << classChoice << endl;

	switch (classChoice)
	{
	case 0:
		fileName = "Barbarian.txt";
		break;
	case 1:
		fileName = "Bard.txt";
		break;
	case 2:
		fileName = "Cleric.txt";
		break;
	case 3:
		fileName = "Druid.txt";
		break;
	case 4:
		fileName = "Fighter.txt";
		break;
	case 5:
		fileName = "Monk.txt";
		break;
	case 6:
		fileName = "Paladin.txt";
		break;
	case 7:
		fileName = "Ranger.txt";
		break;
	case 8:
		fileName = "Rogue.txt";
		break;
	case 9:
		fileName = "Sorcerer.txt";
		break;
	case 10:
		fileName = "Warlock.txt";
		break;
	case 11:
		fileName = "Wizard.txt";
		break;
	}
	


	classFile.open("Classes/" + fileName);
	string inputs[7];
	int index = 0;

	if (classFile.is_open())
	{
		while (index <= 6)
		{
			getline(classFile, inputs[index]);
			index++;
		}
		className = inputs[0];
		classDesc = inputs[1];
		hitDie = stoi(inputs[2]);
		primaryAbility = proficiencies[stoi(inputs[3])];
		prof1 = proficiencies[stoi(inputs[4])];
		prof2 = proficiencies[stoi(inputs[5])];
		equipProfs = inputs[6];
	}
	else
	{
		cout << "File cannot be found.";
	}

	classFile.close();

	/*cout << className << endl << classDesc << endl << hitDie << endl << primaryAbility << endl << prof1 << endl << prof2 << endl << equipProfs << endl;*/

	//cout << className << endl << classDesc << endl << hitDie << endl << primaryAbility << endl << prof1 << endl << prof2 << endl << equipProfs << endl;
	
}