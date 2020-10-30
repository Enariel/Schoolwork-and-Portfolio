'''
The purpose of this script is to compare gems to their families as 
well as their toxicity.
This is by far, the LEAST comprehensive program and will only serve
to be a baseline understanding. The descriptions of the gem families
are not my own words, they are directly from here: 

https://www.gemsociety.org/gemstone-encyclopedia/

Apologies, I am unsure how to properly 'source' in a python app.
=================================================================
Oliver Conover
Professor Chapa
    PHSC
Intro to Programming
Final Project
'''

import os

#Directory and history variable for accessing database, storing search histories, etc.
textDir = "Information\Output"                              
dataDir = "Information\Database"
historyFile = ("history.txt", "w+", "r+")

#function to check if directory exists. If it doesent, then create it. 
def CreateAndCheckDirectory(dir):                           
    if os.path.isdir(dir):
        print("The path at %s already exists." % dir)
    else:
        os.makedirs(dir)
        print("A directory has been made at %s" % dir)

def main():

    #Creating directories for use.
    CreateAndCheckDirectory(textDir)
    CreateAndCheckDirectory(dataDir)

    #This is here, because it will try to access a database that doesnt exist, blowing up the program, lest the directories not exist.
    import Alchemie_Database_Manager as alchTab             
    alchTab.ConnectToDatabase()
    print("Welcome to Alchemie! The database has been set up, below are the families of gems. \n")
    print("The information here was found at https://www.gemsociety.org/gemstone-encyclopedia/")

    MainMenu()

def MainMenu():
    import Alchemie_Database_Manager as alchTab

    print("Enter a corresponding number to see more about these gems, or press ENTER to quit")
    num = 1
    for line in alchTab.MainMenu():
        line = str(line)
        print('{:>20} {:>20}'.format(line, num))
        num += 1

    x = input("Enter the group you'd like to search: ")
    Input(int(x))
    while True:
        if x == "":
            break
    

def Input(x):
    import Alchemie_Database_Manager as alchTab

    if x <= 15:
        species = alchTab.ChooseGroup(x)

        for line in species:
            line = str(line)
            print('{:>20}'.format(line))
        con = input("Continue? y/n: ")
        if con == "y":
            MainMenu()
        else:
            print("Goodbye!")
            while True:
                break
    else:
        print("Please enter a valid number 1 - 15.")
        Input(int(input()))

if __name__ == "__main__":
    main()