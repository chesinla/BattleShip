using System;

class Gameboard
{
	//https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays
	//public char[,] grid {get; set;}
	
    public Gameboard (){} 


    public char[,] grid {get; set;}

    public void Test(){
        string testString = "5overand5up";
        char[] coordinates;

        coordinates = testString.ToCharArray(0, 11);


            // Validate();

        //try{}

        //if testString.Console.Readline(someInteger) < 1 || > 10 

        // Catch 

        // return Console.WriteLine("Please select coordinates 1 through 10");
        
        Console.Write("Enter a string - ");
        testString = Console.ReadLine();
        Console.Write("The first number in '{0}' is: '", testString);
        Console.Write(coordinates);
        Console.WriteLine("'");
        coordinates = testString.ToCharArray(8, 11);
        Console.Write("The second number in '{0}' is: '", testString);
        foreach (int num in coordinates)
            Console.WriteLine(num);


    }
}

/* class Sample {
    public static void Main() {
    string str = "012wxyz789";
    char[] arr;

    arr = str.ToCharArray(3, 4);
    Console.Write("The letters in '{0}' are: '", str);
    Console.Write(arr);
    Console.WriteLine("'");
    Console.WriteLine("Each letter in '{0}' is:", str);
    foreach (char c in arr)
        Console.WriteLine(c);
    }
}

This example produces the following results:
The letters in '012wxyz789' are: 'wxyz'
Each letter in '012wxyz789' is:
w
x
y
z

loop through GRID
*/