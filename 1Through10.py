import random


number = random.randint(0, 10)
didgamestart = None
guessedit = None
doyou = input("We are going to play a little game. Press enter")

guess = int(input("Choose a number that is 1 through 10. You will have 4 tries"))
if guess < number:
    print("A little more")
    guessedit = False
if guess > number:
    print("A little less")
    guessedit = False
if guess == number:
    print("Good job you guessed it")
    guessedit = True
if guessedit == False:
    tryagain = int(input("Try again"))
    if tryagain == number:
        print("Good job you guessed it")
        guessedit = True
    if tryagain < number:
        print("A little more")
        guessedit = False
    if tryagain > number:
        print("A little less")
        guessedit = False
if guessedit == False:
    tryagainagain = int(input("Try again"))
    if tryagainagain < number:
        print("A little more")
        guessedit = False
    if tryagainagain > number:
        print("A little less")
        guessedit = False
    if tryagainagain == number:
        guessedit = True
        print("Good job you guessed it")
if guessedit == False:
    tryagainagainagain = int(input("Try again"))
    if tryagainagainagain < number:
        print("A little more")
        guessedit = False
    if tryagainagainagain > number:
        print("A little less")
        guessedit = False
    if tryagainagainagain == number:
        guessedit = True
if guessedit == True:
    print("Good job you guessed it")
    exit()

