using System;


public class View

{
    public static void Welcome()
    {
        Console.WriteLine("Welcome to battleship!!!");
        View.PauseForUserInput("Press any key to continue");
    }

    static void PauseForUserInput(string prompt)
    {
        Console.WriteLine(prompt);
        Console.ReadKey();

        int x  = View.CaptureNumber("enter some test strings here");
        Console.WriteLine("the value entered is {0}", x);
        //User presses Enter to call createPlayer() 

    }

    public static void playersStartGame()
    {
        Console.WriteLine("Player 1 press any key");
        View.PauseForUserInput("You are Player 1");     
        Console.WriteLine("Player 2 press any key");
        View.PauseForUserInput("You are Player 2");
        if(correctNumOfPlayers = true)
        {
            Console.WriteLine("There are two ready players in the game");
        }
        else
        {
            Console.WriteLine("There has been an error, restarting game");
        }
        Welcome();
    }







    static int CaptureNumber(string prompt){
        Console.WriteLine(prompt);
        int output;
        while(!Int32.TryParse(Console.ReadLine(), out output)){
            Console.WriteLine("you blew it, and I don't mean a hit on their battle ship. Try again. :)");
        }
        return output;
    }


}