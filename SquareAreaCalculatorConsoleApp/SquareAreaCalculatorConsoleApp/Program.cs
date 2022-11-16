Console.WriteLine();
Console.WriteLine("Welcome to this app which helps you calculate the area of a square.");
Console.WriteLine("*******************************************************************");
Console.WriteLine();
Console.WriteLine("Enter the length of a side of a square and press Enter.");

string LengthOfSideOfSquareText = Console.ReadLine();

// double.TryParse aattemps the conversion of the input
// and returns a bool if it's a success. 
// The result of the conversion is stored
// in the variable after the out keyword in the parenthesis
bool isSuccess = double.TryParse(LengthOfSideOfSquareText, out double LengthOfSideOfSquare);

// We use an if statement to check if the proccess was a success
// before running the calculation.
if (isSuccess)
{
    double areaOfSquare = Math.Pow(LengthOfSideOfSquare, 2);
    Console.WriteLine($"The area of the square is: {areaOfSquare}");
}
else
{
    Console.WriteLine($"Your input: {LengthOfSideOfSquareText} is not a valid number ");
}

Console.ReadLine();
