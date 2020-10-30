'''
Oliver Conover
Spencer Trenpe
Jacob Yont
Merritt Cogdill

Bobby Chapa
COP1000
10/3/2019
'''

f = open(r"D:/PythonClassDocs/Unit4DoK.txt", 'w+')

def DecCipher(string):
    
    if string != "close" :
    
        for letter in string:
            ordValue = ord(letter)
            cipher = ordValue + 1

            decimal = cipher

            if decimal == 0:
                print(0)
            else:
                bitString = ""
                while decimal > 0:
                    remainder = decimal % 2
                    decimal = decimal //2
                    bitString = str(remainder) + bitString
            #print(cipher)
            #print(bitString)
            MoveBinary(bitString)
        Main()
    else:
        print("We are done here")
        f.close

def MoveBinary(newString):
    
    for numbers in newString:
        newString = newString[-1] + newString[:-1]
    print(newString)
    f.write(newString)
    f.write("\n")

def Main():
    bitString = input("Enter a string: ")
    f.write(bitString)
    f.write("\n")
    DecCipher(bitString)

Main()