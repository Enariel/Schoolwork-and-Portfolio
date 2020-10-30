"""
This is the file for checking if the database exists
and if there is anything to query from.
The data is extracted via text files (I know theres
a better way to do this, but this is what I'm doing for now).
With all the .txt files I fill the tables according to the code.
"""
import sqlite3
import os
from GemType import GemType
from Gem import Gem
from DangerLevels import DangerLevel

DATABASE_PATH = ('Information\Database\Alchemie.db')  

#Creating the connection to the database in a function to be used elsewhere in code, passing the path to the database as a parameter. 
def ConnectToDatabase(path = DATABASE_PATH):
    connection = sqlite3.connect(path, timeout = 30)
    return connection


#Connecting to the database, and creating tables if they arent there. 
def CreateTables(conn = ConnectToDatabase()):
    c = conn.cursor()
                                                                
    c.execute("""CREATE TABLE if not exists Gems (
        GemID INTEGER PRIMARY KEY NOT NULL,
        TypeID INTEGER FORIEGN KEY,
        GemName TEXT,
        GemDesc TEXT)"""
        )
    c.execute("""CREATE TABLE if not exists DangerLevels (
        DangerID INTEGER PRIMARY KEY, 
        DangerName TEXT,
        DangerDesc TEXT)""")
    c.execute("""CREATE TABLE if not exists GemGroups (
        TypeID INTEGER PRIMARY KEY,
        TypeName TEXT NOT NULL,
        TypeDesc TEXT,
        TypeLocation TEXT
        )""")
    c.execute("""CREATE TABLE if not exists GemDanger (
        GemID INTEGER FORIEGN KEY,
        DangerID INTEGER,
        GemName TEXT,
        DangerDesc TEXT
        )""")

    conn.commit()

#A gem type, or gem group is sort of like a family for species of gems. Like how all house cats are felines, but not all felines are housecats.
def GemTypes():
    #A function to return a list of Gem Groupings. 
    gemNameFile = open('Information\GemGroupNames.txt', 'rt')
    gemDescFile = open('Information\GemGroupDescriptions.txt', 'rt')
    gemGroupList = []
    ID = 100

    #Read each line of the gem group text files and add them to the list of GemType Classes.
    for line in gemNameFile:
        name = gemNameFile.readline()
        desc = gemDescFile.readline()

        gemGroupList.append(GemType(ID, name, desc))
        ID += 1
    return gemGroupList 

#A gem belongs to a group, a group can have many gems, but a gem can only have one group. These are the 'housecats' in the previous analogy.
def Gems():

    #Open all the files which contain each gem type. They are all in a different .txt file for easy classification and future editing.
    berylFile = open('Information\Beryl.txt')
    chrysoberylFile = open('Information\Chrysoberyl.txt')
    corundrumFile = open('Information\Corundum.txt')
    diamondFile = open('Information\Diamond.txt')
    feldsparFile = open('Information\Feldspar.txt')
    garnetFile = open('Information\Garnet.txt')
    jadeFile = open('Information\Jade.txt')
    opalFile = open('Information\Opal.txt')
    quartzFile = open('Information\Quartz.txt')
    spinelFile = open('Information\Spinel.txt')
    spodumeneFile = open('Information\Spodumene.txt')
    topazFile = open('Information\Topaz.txt')
    tourmalineFile = open('Information\Tourmaline.txt')
    zirconFile = open('Information\Zircon.txt')
    zoisiteFile = open('Information\Zoisite.txt')

    #Instantiate the list they will all be stored in.
    Gems = []
    ID = 1
    GemTypeID = 0

    #This is awful and I apologize. Anyways this just reads the lines in all the files and adds them to the Class list of gems.
    for line in berylFile:
        GemTypeID = 1
        name = berylFile.readline()
        Gems.append(Gem(GemTypeID, ID, name))
        ID += 1
    for line in chrysoberylFile:
        GemTypeID = 2
        name = chrysoberylFile.readline()
        Gems.append(Gem(GemTypeID, ID, name))
        ID += 1
    for line in corundrumFile:
        GemTypeID = 3
        name = corundrumFile.readline()
        Gems.append(Gem(GemTypeID, ID, name))
        ID += 1
    for line in diamondFile:
        GemTypeID = 4
        name = diamondFile.readline()
        Gems.append(Gem(GemTypeID, ID, name))
        ID += 1
    for line in feldsparFile:
        GemTypeID = 5
        name = feldsparFile.readline()
        Gems.append(Gem(GemTypeID, ID, name))
        ID += 1
    for line in garnetFile:
        GemTypeID = 6
        name = garnetFile.readline()
        Gems.append(Gem(GemTypeID, ID, name))
        ID += 1
    for line in jadeFile:
        GemTypeID = 7
        name = jadeFile.readline()
        Gems.append(Gem(GemTypeID, ID, name))
        ID += 1
    for line in opalFile:
        GemTypeID = 8
        name = opalFile.readline()
        Gems.append(Gem(GemTypeID, ID, name))
        ID += 1
    for line in quartzFile:
        GemTypeID = 9
        name = quartzFile.readline()
        Gems.append(Gem(GemTypeID, ID, name))
        ID += 1
    for line in spinelFile:
        GemTypeID = 10
        name = spinelFile.readline()
        Gems.append(Gem(GemTypeID, ID, name))
        ID += 1
    for line in spodumeneFile:
        GemTypeID = 11
        name = spodumeneFile.readline()
        Gems.append(Gem(GemTypeID, ID, name))
        ID += 1
    for line in topazFile:
        GemTypeID = 12
        name = topazFile.readline()
        Gems.append(Gem(GemTypeID, ID, name))
        ID += 1
    for line in tourmalineFile:
        GemTypeID = 13
        name = tourmalineFile.readline()
        Gems.append(Gem(GemTypeID, ID, name))
        ID += 1
    for line in zirconFile:
        GemTypeID = 14
        name = zirconFile.readline()
        Gems.append(Gem(GemTypeID, ID, name))
        ID += 1
    for line in zoisiteFile:
        GemTypeID = 15
        name = zoisiteFile.readline()
        Gems.append(Gem(GemTypeID, ID, name))
        ID += 1
    return Gems

#Each gem has an inherent risk factor with it, these risk factors are created here.
def DangerLevels():

    #Files with the information
    levelName = open("Information\DangerLevelName.txt")
    levelDesc = open("Information\DangerLevelDesc.txt")

    levelList = []
    level = 1
    for line in levelName:
        name = levelName.readline()
        desc = levelDesc.readline()

        levelList.append(DangerLevel(level, name, desc))
        level += 1
    return levelList

def InsertData(conn = ConnectToDatabase()):
    c = conn.cursor()

    #The class lists
    GemTypeData = GemTypes()
    GemsData = Gems()
    DangerData = DangerLevels()
    #SQL commands for each tables data insertion
    sqlGG = "INSERT INTO GemGroups (TypeID, TypeName, TypeDesc) VALUES (?, ?, ?)"
    sqlGem = "INSERT INTO Gems (GemID, TypeID, GemName) VALUES (?, ?, ?)"
    sqlLvl = "INSERT INTO DangerLevels (DangerID, DangerName, DangerDesc) VALUES (?, ?, ?)"
    sqlGDL = "INSERT INTO GemDanger (GemID, GemName) SELECT GemID, GemName FROM Gems"

    for GemType in GemTypeData:
        c.execute(sqlGG, (GemType.ID, GemType.Name, GemType.Desc))
    for species in GemsData:
        c.execute(sqlGem, (species.ID, species.GemTypeID, species.Name))
    for Dangers in DangerData:
        c.execute(sqlLvl, (Dangers.Level, Dangers.Name, Dangers.Desc))

    #Putting Gems in DangerGems Table
    c.execute(sqlGDL)

    UpdateDangerTable(conn)
    conn.close()

def UpdateDangerTable(conn):
    c = conn.cursor()

    sql = "UPDATE GemDanger SET DangerID = %d WHERE GemID in {}"
    id = 1

    #The gem ID's by DangerLevel
    lv1 = [27, 145, 38, 43, 44, 72, 50, 30, 166, 97, 123, 102, 23, 141, 89, 73, 133, 9, 117, 167, 19, 144, 90, 149, 109, 47, 147, 148, 1, 130, 151, 14, 15, 74, 7, 5, 24, 136, 54, 138, 161, 76, 77, 142, 152, 101, 118, 139, 153, 8, 48, 128, 119, 143, 112, 20, 121, 28, 114, 115, 111, 137, 59, 62, 6, 25, 124, 154, 155, 18, 113, 116, 156, 16, 21, 162, 10, 164, 165, 49, 63, 157, 158, 17, 159, 22, 26, 67]
    lv2 = [12, 29, 46, 2, 31, 11, 51, 135, 52, 4, 53, 55, 68, 32, 58, 65, 33, 39, 3, 69, 35, 110, 37, 150, 41, 60, 45, 13, 126, 40, 64, 42, 140, 131, 56, 57, 66]
    lv3 = [99, 71, 34, 88, 103, 98, 104, 106, 107, 100, 86, 91, 75, 78, 108, 92, 79, 80, 70, 81, 82, 120, 87, 83, 93, 84, 94, 85, 160]
    lv4 = [96, 61, 105, 146, 134, 36, 122, 125, 127, 132, 163]
    lv5 = [95, 129]

    #Gotta make them touples for some reason
    t1 = tuple(lv1)
    t2 = tuple(lv2)
    t3 = tuple(lv3)
    t4 = tuple(lv4)
    t5 = tuple(lv5)

    #Now its made into a list to iterate
    list = [t1, t2, t3, t4, t5]
    
    for levels in list:
        c.execute(sql.format(levels) % id)
        id += 1
    c.execute("UPDATE GemDanger SET DangerDesc = (Select DangerName FROM DangerLevels WHERE GemDanger.DangerID = DangerLevels.DangerID)")
    conn.commit()

#A check to make sure the database exists.
def CheckAndFillTables(conn = ConnectToDatabase()):

    #Will always be run because of the 'if not exists'
    CreateTables()
    #Cursor object
    c = conn.cursor()

    #If this query returns at least 1 row, that means data already exists and will NOT insert information into tables. 
    #Otherwise it will insert data if it returns 0 rows.
    c.execute("SELECT COUNT(*) FROM GemGroups")
    if c.fetchone()[0] > 0:
        print("Data exists")
        c.execute("SELECT name FROM sqlite_master WHERE type = 'table'")
        print(c.fetchall())
    else:
        InsertData()
        print("Data inserted into tables")
        print(c.fetchall())
        #commit to these changes
        c.execute("UPDATE Gems SET GemName = rtrim(GemName, '\n')")
        c.execute("UPDATE GemDanger SET DangerDesc = rtrim(DangerDesc, '\n')")
        c.execute("UPDATE GemGroups SET TypeName = rtrim(TypeName, '\n')")
        conn.commit()

    #Close the connection
    conn.close()

def MainMenu(conn = ConnectToDatabase()):
    c = conn.cursor()

    
    sql = "SELECT TypeName FROM GemGroups"
    c.execute(sql)
    Groups = []
    for rows in c.fetchall():
        Groups.append(rows)
    return Groups
    conn.close()

def ChooseGroup(x, conn = ConnectToDatabase()):
    c = conn.cursor()
    
    SpeciesDetails = []
    sql = "SELECT Gems.GemName, GemDanger.DangerDesc FROM Gems JOIN GemDanger ON Gems.GemID = GemDanger.GemID WHERE Gems.TypeID = %s"
    
    c.execute(sql % x)

    for rows in c.fetchall():
        SpeciesDetails.append(rows)
    return SpeciesDetails
    conn.close()

CheckAndFillTables()