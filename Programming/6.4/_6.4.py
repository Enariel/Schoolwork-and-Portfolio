# Modify the code below
"""
Program: newton.py
Author: Ken
Compute the square root of a number.
1. The input is a number.
2. The outputs are the program's estimate of the square root
   using Newton's method of successive approximations, and
   Python's own estimate using math.sqrt.
"""

"""
Oliver Conover
Professor Robert Chapa
6.4
"""

import math

# Receive the input number from the user
x = float(input("Enter a positive number: "))

# Initialize the tolerance and estimate
TOLERANCE = 0.000001
estimate = 1.0

# Perform the successive approximations
def newton(x, estimate = 1):

    while True:

        difference = abs(x - estimate ** 2)
        estimate = (estimate + x / estimate) / 2

        return limitReached(difference, estimate)

def limitReached(difference, estimate):
    if difference <= TOLERANCE:
        return estimate
    else:
        return improveEstimate(x, estimate)

def improveEstimate(x, estimate):
    return newton(x, estimate)

# Output the result
print("The program's estimate is", newton(x))
print("Python's estimate is     ", math.sqrt(x))
