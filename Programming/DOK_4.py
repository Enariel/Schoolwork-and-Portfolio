'''
Oliver Conover
Spencer Trenpe
Jacob Yont
Merritt Cogdill

Bobby Chapa
COP1000
10/3/2019
'''

#f = open(r"C:/Python/Unit4DoK.txt", 'w+')

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
            print(cipher)
            #print(bitString)
            MoveBinary(bitString)
        main()
    else:
        print("We are done here")
       # f.close

def MoveBinary(newString):
	s1 = newString[1:]
	s2 = newString[0]
	newString = s1 + s2
	print(newString)
	#f.write(newString + " ")

def main():
    bitString = input("Enter a string: ")
    DecCipher(bitString)

if __name__ == "__main__":
	main()
