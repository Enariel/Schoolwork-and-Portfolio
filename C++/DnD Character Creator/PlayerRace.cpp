//PlayerRaces function definitions
//PlayerRaces should get information from files in this order -
/*
Race Name
Race Description
Ability Score Increase Type
	Ability Score Type increase (int)
Age
Alignment
Size
Speed
Passives 1 - 5
Languages

If subrace
	SubRace Name
	SubRace Description
	subASI Type
		subASI int
	Passives 1 - 5
*/
#include "PlayerRace.h"

string dwarfSubs[2];
string elfSubs[3];
string gnomeSubs[2];
string halfSubs[2];

void PlayerRace::GetRace(int choice)
{
	raceChoice = choice;
	cout << raceChoice << endl;

	switch (raceChoice)
	{
	case 0:
		raceFileName = "Dragonborn.txt";
		ChooseDragonColor();
		break;
	case 1:
		raceFileName = "Dwarf.txt";
		ChooseSubRace(raceChoice);
		break;
	case 2:
		raceFileName = "Elf.txt";
		ChooseSubRace(raceChoice);
		break;
	case 3:
		raceFileName = "Gnome.txt";
		ChooseSubRace(raceChoice);
		break;
	case 4:
		raceFileName = "Half-Elf.txt";
		break;
	case 5:
		raceFileName = "Half-Orc.txt";
		break;
	case 6:
		raceFileName = "Halfling.txt";
		ChooseSubRace(raceChoice);
		break;
	case 7:
		raceFileName = "Human.txt";
		break;
	case 8:
		raceFileName = "Tiefling.txt";
		break;
	}

	raceFile.open("Races/" + raceFileName);
	string inputs[20];
	int index = 0;

	if (raceFile.is_open())
	{
		while (index < 20)
		{
			getline(raceFile, inputs[index]);
			index++;
		}
		raceName = inputs[0];
		raceDesc = inputs[1];
		asiType1 = stoi(inputs[2]);
		asi = stoi(inputs[3]);
		asiType2 = stoi(inputs[4]);
		asi2 = stoi(inputs[5]);
		maxAge = stoi(inputs[6]);
		alignment = inputs[7];
		size = inputs[8];
		speed = stoi(inputs[9]);
		passiv[0] = inputs[10];
		passiv[1] = inputs[11];
		passiv[2] = inputs[12];
		passiv[3] = inputs[13];
		passiv[4] = inputs[14];
		languages[0] = stoi(inputs[15]);
		languages[1] = stoi(inputs[16]);
		languages[2] = stoi(inputs[17]);
		languages[3] = stoi(inputs[18]);
		languages[4] = stoi(inputs[19]);
	}
	else
	{
		cout << "File cannot be found.";
	}

	raceFile.close();

	/*cout << className << endl << classDesc << endl << hitDie << endl << primaryAbility << endl << prof1 << endl << prof2 << endl << equipProfs << endl;*/

	//cout << className << endl << classDesc << endl << hitDie << endl << primaryAbility << endl << prof1 << endl << prof2 << endl << equipProfs << endl;

}

void PlayerRace::GetSubRace(int raceChoice, int subRaceChoice)
	//nested switch statements to associate choice and subrace choices
{
	if (raceChoice == 1 || raceChoice == 2 || raceChoice == 3 || raceChoice == 6)
		//Makes sure a proper choice was made. 
	{
		switch (raceChoice)
		{
		case 1:
			if (subRaceChoice == 0 || subRaceChoice == 1)
				//To Make sure a valid subrace was entered
			{
				switch (subRaceChoice)
				{
				case 0:
					subRaceFileName = "Hill Dwarf.txt";
					break;
				case 1:
					subRaceFileName = "Mountain Dwarf.txt";
					break;
				}
			}
			else
			{
				cout << "Enter a valid entry";
				ChooseSubRace(raceChoice);
			}
			break;
		case 2:
			if (subRaceChoice == 0 || subRaceChoice == 1 || subRaceChoice == 2)
			{
				switch (subRaceChoice)
				{
				case 0:
					subRaceFileName = "High Elf.txt";
					break;
				case 1:
					subRaceFileName = "Wood Elf.txt";
					break;
				case 2:
					subRaceFileName = "Drow.txt";
					break;
				}
			}
			else
			{
				cout << "Enter a valid entry";
				ChooseSubRace(raceChoice);
			}
			break;
		case 3:
			if (subRaceChoice == 0 || subRaceChoice == 1)
			{
				switch (subRaceChoice)
				{
				case 0:
					subRaceFileName = "Forest Gnome.txt";
					break;
				case 1:
					subRaceFileName = "Rock Gnome.txt";
					break;
				}
			}
			else
			{
				cout << "Enter a valid entry";
				ChooseSubRace(raceChoice);
			}
			break;
		case 6:
			if (subRaceChoice == 0 || subRaceChoice == 1)
			{
				switch (subRaceChoice)
				{
				case 0:
					subRaceFileName = "Lightfoot.txt";
					break;
				case 1:
					subRaceFileName = "Stout.txt";
					break;
				}
			}
			else
			{
				cout << "Enter a valid entry";
				ChooseSubRace(raceChoice);
			}
			break;
		}
	}
	else
		//Calls to redo the function if an invalid entry was made.
	{
		ChooseSubRace(raceChoice);
	}

	//Now it opens and reads the proper SubRace File.
	subRaceFile.open("Races/SubRaces/" + subRaceFileName);
	string inputs[9];
	int index = 0;

	if (subRaceFile.is_open())
	{
		while (index <= 8)
		{
			getline(subRaceFile, inputs[index]);
			index++;
		}
		subRaceName = inputs[0];
		subRaceDesc = inputs[1];
		subAsiType1 = stoi(inputs[2]);
		subasi = stoi(inputs[3]);
		subPassiv[0] = inputs[4];
		subPassiv[1] = inputs[5];
		subPassiv[2] = inputs[6];
		subPassiv[3] = inputs[7];
		subPassiv[4] = inputs[8];

	}
	else
	{
		cout << "File cannot be found.";
	}
	
}

void PlayerRace::ChooseSubRace(int choice)
{
	cout << "Choose a Sub-Race for your character: " << endl;
	subRaceChoice = 0;

	//get subrace selection

	switch (choice)
	{
	case 1: 
		dwarfSubs[0] = subRace[0];
		dwarfSubs[1] = subRace[1];
		for (int i = 0; i <= 1; i++)
		{
			cout << "[" << i << "]" << dwarfSubs[i] << endl;
		}
		cin >> subRaceChoice;
		GetSubRace(choice, subRaceChoice);
		break;
	case 2:
		elfSubs[0] = subRace[2];
		elfSubs[1] = subRace[3];
		elfSubs[2] = subRace[4];
		for (int i = 0; i <= 2; i++)
		{
			cout << "[" << i << "]" << elfSubs[i] << endl;
		}
		cin >> subRaceChoice;
		GetSubRace(choice, subRaceChoice);
		break;
	case 3:
		gnomeSubs[0] = subRace[5];
		gnomeSubs[1] = subRace[6];
		for (int i = 0; i <= 1; i++)
		{
			cout << "[" << i << "]" << gnomeSubs[i] << endl;
		}
		cin >> subRaceChoice;
		GetSubRace(choice, subRaceChoice);
		break;
	case 6:
		halfSubs[0] = subRace[7];
		halfSubs[1] = subRace[8];
		for (int i = 0; i <= 1; i++)
		{
			cout << "[" << i << "]" << halfSubs[i] << endl;
		}
		cin >> subRaceChoice;
		GetSubRace(choice, subRaceChoice);
		break;
	}
}

void PlayerRace::ChooseDragonColor()
{

}