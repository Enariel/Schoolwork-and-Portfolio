copyFrom = open(input("Enter the input file name: "), "r")
copyTo = open(input("Enter the output file name: "),"w+")
textFrom = copyFrom.read()
copyTo.write(textFrom)
