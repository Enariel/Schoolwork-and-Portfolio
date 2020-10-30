f = open(r"C:/Python/Unit4DOK.txt")

def toList(intString):
	bits = list
	newString = ""
	for ints in intString:
		if ints != " ":
			newString += str(ints)
		bits.append(newString)
		print(bits)
def main():
	intString = f.read()
	toList(intString)

if __name__ == "__main__":
	main()