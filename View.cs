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
        Player.PlayerN


    }
}