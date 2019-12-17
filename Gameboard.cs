using System;


//https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays
class Gameboard
{
    public char[,] offensiveGrid {get; set;}
    public char[,] defensiveGrid {get; set;}
    


    public class Grid
    {
       
        Grid myGrid = new Grid()
        {
            myGrid.Width = 10,
            myGrid.Height = 10,
            myGrid.HorizontalAlignment = HorizontalAlignment.Left,
            myGrid.VerticalAlignment = VerticalAlignment.Top,
            myGrid.ShowGridLines = true
        };




    }
}

 /*  public void Test(){
        string testString = "5overand5up";
        char[] coordinates;

        coordinates = testString.ToCharArray(0, 11);
        
        Console.Write("Enter a string - ");
        testString = Console.ReadLine();
        Console.Write("The first number in '{0}' is: '", testString);
        Console.Write(coordinates);
        Console.WriteLine("'");
        coordinates = testString.ToCharArray(8, 11);
        Console.Write("The second number in '{0}' is: '", testString);
        foreach (int num in coordinates)
            Console.WriteLine(num);


    }*/
