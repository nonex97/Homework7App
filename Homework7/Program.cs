// Add students to a class roster List until there are no more students.
// Then print out the count of the student to the console.

List<String> firstNames = new List<String>();
string firstName;
bool quit = false;

do
{
    Console.Write("Enter the name of a student (or type quit): ");
    firstName = Console.ReadLine();
    if (firstName.ToLower() == "quit")
    {
        Console.WriteLine(firstNames.Count() + 1);
        return;
    }
    else
    {
        firstNames.Add(firstName);
    }
} while (quit == false);