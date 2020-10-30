'''
Conover Oliver
Professor Chapa
COP1000
MidTerm
'''
import random


def areaOfRightTriangle(sideA, sideB):
	area = (sideA * sideB)/2
	return str(area)

def areaOfSquare(length):
	area = length ** 2
	return str(area)
def areaOfCircle(radius):
	area = 3.14 * radius ** 2
	return str(area)
def main():

	i = 0
	randNum = 0
	calculationsList = []

	while i < 10:

		randNum = random.randint(0, 500)
		calculationsList.append("The Triangle Area: " + areaOfRightTriangle(randNum, randNum))
		calculationsList.append("The Square Area: " + areaOfSquare(randNum))
		calculationsList.append("The Circle Area: " + areaOfCircle(randNum))
		print(calculationsList)
		calculationsList = []
		i += 1


if __name__ == "__main__":
	main()