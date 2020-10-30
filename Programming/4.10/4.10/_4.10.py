firstFile = open(input("Enter the first file name: "), "r")
secondFile = open(input("Enter the second file name: "), "r")
firstFileText = firstFile.read()
secondFileText = secondFile.read()

if firstFileText == secondFileText:
    print("yes")
else:
    newString = ""
    print("No")
    for strings in firstFileText:
        if strings != secondFileText:
            newString += strings
        print(newString + " ")

    for strings in secondFileText:
        if strings != firstFileText:
            newString += strings
        print(newString + " ")