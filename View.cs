using System;


public class View

{
    static void Welcome()
    {
        Console.WriteLine("Welcome to battleship!!!");
        View.PauseForUserInput("Press any key to continue");
        

    }
    static void PauseForUserInput(string prompt)
    {
        Console.WriteLine(prompt);
        Console.ReadKey();
        //User presses Enter to call createPlayer() 

    }

    static void createPlayer()
    {
        Console.WriteLine("Player 1 press any key");
        View.PauseForUserInput("You are Player 1");
        Player player1 = new Player(1, "player1", 10, 1);
        Console.WriteLine("Player 2 press any key");
        View.PauseForUserInput("You are Player 2");
        Player player2 = new Player(2, "player2", 10, 2);
        bool playerCount = true;
        if(numberOfPlayers != 2)
        {
            
        }
    }

    /* static void validatePlayers()
    {
        if(numberOfPlayers != 2)
        {
            Console.WriteLine("There has been an error restart game");

        }


    }*/ 
}