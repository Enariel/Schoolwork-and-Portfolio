'''

This is to encrypt by adding 1 to each characters ASCII value
and convert it to a bit string
then shift the bits of the string one place to the left

'''

bitString = input("Enter a string: ")
newString = ""
for letter in bitString:
    
    ordValue = ord(letter)
    cipher = ordValue + 1

    decimal = cipher

    if decimal == 0:
        print(0)
    else:
        bitString = ""
        while decimal > 0:
            remainder = decimal % 2
            decimal = decimal // 2
            bitString = str(remainder) + bitString
    newBinary = bitString
    #print(newBinary)

    for index in range(len(newBinary)):
        s1 = newBinary[0]
        s2 = newBinary[1:]
    newBinary = s2 + s1
    newString += newBinary + " "
print(newString)

