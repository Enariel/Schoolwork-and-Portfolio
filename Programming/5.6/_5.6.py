numRep = {0:"0", 1:"1", 2:"2", 3:"3", 4:"4", 5:"5", 6:"6", 7:"7", 8:"8", 9:"9", 10:"A", 11:"B", 12:"C", 13:"D", 14:"E", 15:"F"}

def decimalToRep(decimal, base):
    if decimal == 0:
        print(0)
    else:
        print("Things happening")
        bstring = ""
        newString = ""
        while decimal > 0:
            remainder = decimal % base
            decimal = decimal // base
            bstring = str(numRep[remainder]) + bstring
        return bstring
def main():
    print(decimalToRep(10, 10))
    print(decimalToRep(10, 8))
    print(decimalToRep(10, 2))
    print(decimalToRep(10, 16))

if __name__ == "__main__":
    main()
