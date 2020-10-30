import math

TOLERANCE = 0.000001

def newton(x, estimate = 1):
	if difference <= TOLERANCE:
		difference = abs(x - estimate ** 2)
	else:
		estimate = (estimate + x / estimate) / 2
	return newton(x, estimate)

def main():
    """Allows the user to obtain square roots."""
    while True:
        # Receive the input number from the user
        x = input("Enter a positive number or enter/return to quit: ")
        if x == "":
             break
        x = float(x)
        # Output the result
        print("The program's estimate is", newton(x))
        print("Python's estimate is     ", math.sqrt(x))

if __name__ == "__main__":
    main()