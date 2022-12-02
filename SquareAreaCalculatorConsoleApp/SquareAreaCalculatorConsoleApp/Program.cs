Console.WriteLine();
Console.WriteLine("Welcome to this app which helps you calculate the area of a square.");
Console.WriteLine("*******************************************************************");
Console.WriteLine();
Console.WriteLine("Enter the length of a side of a square and press Enter.");

string LengthOfSideOfSquareText = Console.ReadLine();


// Using the built in LINQ library we can create 2 strings as shown below for the number part and the unit part
string numberPart = new String(LengthOfSideOfSquareText.Where(Char.IsDigit).ToArray());
string unitPart = new String(LengthOfSideOfSquareText.Where(Char.IsLetter).ToArray());


// We TryParse the number part
bool isSuccess = double.TryParse(numberPart, out double LengthOfSideOfSquare);


// To make sure the user enters a unit we would check if unitPart.Count() > 0
if (isSuccess && unitPart.Count() > 0)
{
    double areaOfSquare = Math.Pow(LengthOfSideOfSquare, 2);

    // Finally we add the {unitPart}² to the output string
    // I do not have the (²) on my keyboard so I just copied from google.(Searched: character for squared)
    Console.WriteLine($"The area of the square is: {areaOfSquare}{unitPart}²");
}
// Check if there is no unit and return a message.
else if (unitPart.Count() == 0)
{
    Console.WriteLine($"Your input: {LengthOfSideOfSquareText} Does not have a unit. Please enter a unit next time");
}
else
{ 
    Console.WriteLine($"Your input: {LengthOfSideOfSquareText} is not a valid number ");
}

Console.ReadLine();
