// We'll use Console.WriteLine() and Console.ReadLine() 
// to ask for and take the users input.

// I want to first introduce the user to the application
// by writting the lines below
Console.WriteLine();
Console.WriteLine("Welcome to this app which helps you calculate the area of a square.");
Console.WriteLine("*******************************************************************");
Console.WriteLine();
Console.WriteLine("Enter the length of a side of a square and press Enter.");

string LengthOfSideOfSquareText = Console.ReadLine();

// Console.ReadLine() returns a string which
// we need to Convert to a double for calculation.
// We use a double because the calculation
// may return an answer with a decimal value

double LengthOfSideOfSquare = double.Parse(LengthOfSideOfSquareText);

// Formular for calculating the area of a square is side(squared)
// We'll be using the built in Math class to get the square of the side.

double areaOfSquare = Math.Pow(LengthOfSideOfSquare, 2);

Console.WriteLine($"The area of the square is: {areaOfSquare}");

// Finally To prevent the console from closing quickly
// We use Console.ReadLine() which would wait for a prompt before closing

Console.ReadLine();
