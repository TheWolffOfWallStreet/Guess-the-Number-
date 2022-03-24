Guess the Number is a fun, yet simple number guessing game that I built into a console application. It asks the user if they want to play a game, and 
instructs the potential player to select Y/y or N/n accordingly. If the user selects N/n, the application bids the user farewell and promptly ends the application. 
If the user instead selects Y/y, the application proceeds to invite the player to select a number between zero and fifty, which has been privately and randomly selected 
so that we do not give away the answer. From this point, the application will respond to the user with several different "Pennywise" related remarks based on what input
was entered into the console until our player eventually guesses correctly and ends the game/application.

The three features from the project list that I chose to implement in my project are:
-Implementation of a master loop that allows the player to repeatedly make different selections, including the option to exit the program.

-Implementation of a regular expression (regex) which was created to prevent the user from being able to enter any input to proceed. If the user chose any input other
than an upper or lowercase Y/N, it does not allow them to continue until the regex requirements have been met. 

-Analyze text and display information about it. On several occasions throughout the program, the code will analyze user input text and inform the user if their choice 
is valid, too high, too low, outside number range, or if they have guessed correctly. This feature allows me to effectively communicate with my user/player.

-Use of tryparse (Not on feature list but could be a worthy addition) to clarify with my user/player entered an integer and not some other unexpected variable and 
is does not allow them to proceed without an integer. 
