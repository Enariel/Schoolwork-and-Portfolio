'''
Oliver Conover
Professor Chapa
UNIT 5 DOK FINAL
COP1000
'''

f = open(r"D:/PythonClassDocs/Unit4DoK.txt")

def toList(intString):

    bits = []                               #new list of bits
    newString = ""

    for ints in intString:                  #break up string into its bit components
        if ints != " ":                     #break up the spaces
            newString += ints
        else:                               #if theres a space, start a new string of bits
            bits.append(newString)
            newString = ""
    MoveBackBinary(bits)                    #starting new method/function with list of bits as parameter

def MoveBackBinary(list):
    for listIndex in range(len(list)):      #accessing each index in the list
        bit = str(list[listIndex])
        for num in bit:                     #moving back to the right
            s1 = bit[-1:]
            s2 = bit[0:-1]
        bit = s1 + s2
        
        DeCipher(bit)
def DeCipher(newBit):
    exponent = len(newBit) - 1
    decimal = 0
    letter = ""
    word = []                               #this is unecessary but looked cool so i kept it
    for digit in newBit:
        decimal = decimal + int(digit) * 2 ** exponent
        exponent = exponent - 1
        letter = chr(decimal - 1)
    word.append(letter)
    print(word)

def main():
	intString = f.read()
	toList(intString)

if __name__ == "__main__":
	main()
