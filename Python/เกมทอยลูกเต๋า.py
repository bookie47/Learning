from random import randint

play = ["Rock","Paper","Scissors"]
dice = [1,2,3,4,5,6]
score = 0
gameover = False
play_dice = False

while not gameover:
    computer = play[randint(0,2)]
    print("Rock, Paper, Scissors?")
    player = input().strip()
    
    if player == computer:
        print("Tie")
    elif player == "Rock":
        if computer == "Paper":
            print("You lose!", computer ,"coners", player)
            play_dice = True
        else:
            print("You win!", player, "smashes", computer)
            score += 1
    elif  player == "Paper":
        if computer == "Scissors":
            print("You lose!", computer , "cut", computer)
            play_dice = True
            
        else:
            print("You win!", player , "covers", computer)
            score += 1 
    elif player == "Scissors":
        if computer == "Rock":
            print("You lose!", computer ,"smashes", player)
            play_dice = True
        else:
            print("You win!" , player ,"cut", computer)
            score += 1
    else:
            print("Invalid play. Please type Rock/Paper/Scissors")
 
    if play_dice:
        print("Let's guess the number on the dice face")
        number = dice[randint(0,5)]
        print("Type 1 if you think it's 1, 2 or 3")
        print("Type 2 if you think it's 4, 5 or 6")
        guess = int(input().strip())
        
    while guess != 1 and guess != 2:
        print("Invalid guess. Please type 1  or 2")       
        guess = int(input().strip())
        
    if guess == 1:
        if number <= 3:
            print("You're right!")
            play_dice = False
        else:
            print("Wronmg answer! Game Over")
            gameover = True
    else:
        if number >= 4:
            print("You're right!")
            gameover = False
        else:
            print("Wrong answer! Game Over")
            gameover = True
        
print("Game Over. Your score is",score)

              