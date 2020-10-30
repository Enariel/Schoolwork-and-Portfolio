file = open(input("Enter the input file name: "), "r")
fileLines = file.readlines()                            #puts lines into a list
lineCount = len(fileLines)

def lineReader(lineNumber):
    indexNumber = lineNumber - 1
    print(fileLines[indexNumber])
    main()

def main():
    print("The file has", lineCount, "lines")
    inputNum = int(input("Enter a line number [0 to quit]: "))
    if inputNum > 0:
        lineReader(inputNum)
    elif inputNum == 0:
        file.close()
    
if __name__ == "__main__":
    main()
