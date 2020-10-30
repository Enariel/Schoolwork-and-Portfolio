# Modify the code below:
"""
Program: generator.py
Author: Ken
Generates and displays sentences using a simple grammar
and vocabulary.  Words are chosen at random.
"""

import random

articles = ("A", "THE")

nouns = ("BOY", "GIRL", "BAT", "BALL")

verbs = ("HIT", "SAW", "LIKED")

prepositions = ("WITH", "BY")

conjunctions = ("AND", "WITH", "BUT")

adjectives = ("RED", "BIG", "SMALL", "BLUE")

    
def sentence():
    """Builds and returns a sentence."""
    return nounPhrase() + " " + verbPhrase()

def Conjunction():
    return random.choice(conjunctions)

def nounPhrase():
    """Builds and returns a noun phrase."""
    if random.randint(0, 100) % 2 == 0:
        return random.choice(articles) + " " + random.choice(articles) + " " + random.choice(nouns)
    else:
        return random.choice(articles) + " " + random.choice(nouns)

def verbPhrase():
    """Builds and returns a verb phrase."""
    if random.randint(0, 100) % 2 == 0:
            return random.choice(verbs) + " " + nounPhrase() + " " + prepositionalPhrase()
    else:
        return random.choice(verbs) + " " + nounPhrase() + " "
def prepositionalPhrase():
    """Builds and returns a prepositional phrase.""" 
    return random.choice(prepositions) + " " + nounPhrase()

def main():
    """Allows the user to input the number of sentences
    to generate."""
    number = int(input("Enter the number of sentences: "))
    for count in range(number):
        if random.randint(0, 100) % 2 == 0:
            print(sentence() + " " + Conjunction() + " " + sentence() + ".")
        else:
            print(sentence()+".")

# The entry point for program execution
if __name__ == "__main__":
    main()
