// We first ask for the users name using the method below
// This particular method writes the prompt in the parenthesis
// and lets the user write their input on the next line hence "WriteLine"
// and press enter
Console.WriteLine("Please Enter Your First Name and Press Enter: ");

// We then create a string variable, take the input by reading the line using the method below
// Then assign the value to the variable
string usersFirstName = Console.ReadLine();

Console.WriteLine($"Hey there! {usersFirstName} ");