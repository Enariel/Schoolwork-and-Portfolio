"""
File: doctor.py
Project 5.9
Conducts an interactive session of nondirective psychotherapy.
Fixes problem of responding to sentences that address the doctor
using second-person pronouns. 
"""

import random

hedges = ("Please tell me more.",
          "Many of my patients tell me the same thing.",
          "Please continue.")

qualifiers = ("Why do you say that ",
              "You seem to think that ",
              "Can you explain why ")

# The fix is in this dictionary, third line of data
replacements = {"I":"you", "me":"you", "my":"your",
                "we":"you", "us":"you", "mine":"yours",
                "you":"I", "your":"my", "yours":"mine"} 

history = []

def reply(sentence):
    """Implements two different reply strategies."""
    probability = random.randint(1, 4)
    if probability == 1:
        return random.choice(hedges)
    elif probability == 2 and len(history) >= 5:
        return "Earlier you said that " + changePerson(random.choice(history))
    else:
        return random.choice(qualifiers) + changePerson(sentence)

def changePerson(sentence):
    """Replaces first person pronouns with second person
    pronouns."""
    words = sentence.split()
    replyWords = []
    for word in words:
        replyWords.append(replacements.get(word, word))
    return " ".join(replyWords) 

def main():
    """Handles the interaction between patient and doctor."""
    print("Good morning, I hope you are well today.")
    print("What can I do for you?")
    while True:
        sentence = input("\n>> ")
        history.append(sentence)
        if sentence.upper() == "QUIT":
            print("Have a nice day!")
            print("History: ", history)
            break
        print(reply(sentence))

# The entry point for program execution
if __name__ == "__main__":
    main()
