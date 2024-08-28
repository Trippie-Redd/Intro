//Två tal
int GetNumberFromConsole(string prompt) {
    Console.Write(prompt);
    string numberText = Console.ReadLine();

    try {
        return int.Parse(numberText);
    } catch {
        Console.WriteLine("Tweaking");
        return GetNumberFromConsole(prompt);
    }
}

 int FirstNum = GetNumberFromConsole("Tal 1? ");
 int LastNum = GetNumberFromConsole("Tal 2? ");

string Number = "Summan: " + (FirstNum + LastNum).ToString();
string Number2 = "Differensen: " + (FirstNum - LastNum).ToString();
Console.WriteLine(Number);
Console.WriteLine(Number2);

// Fullt Namn
Console.Write("Förnamn? ");
 string FirstName = Console.ReadLine();

Console.Write("Efternamn? ");
 string LastName = Console.ReadLine();

string Name = FirstName + " " + LastName;
Console.Write(Name);