namespace HW4;

class Program
{
    static void Main(string[] args)
    {
        //Task 3
        string userInput;
        string answer;

        bool lookingForSpecificSymbol = true;
        
        int symbolsCount = 0;
        int specificSymbolCounter = 0;
        
        Console.WriteLine("Please, enter your string: ");
        userInput = Console.ReadLine();

        do
        {
            Console.WriteLine("Do you want to find a specific symbol in text? (type 'yes' if you do)");
            answer = Console.ReadLine();

            if (answer == "yes")
            {
                bool finishedLookingForSpecificSymbol = false;
                do
                {
                    string specificSymbol;
                    Console.WriteLine("What symbol would you like to find?");
                    specificSymbol = (Console.ReadLine());
                    if (specificSymbol.Length > 1)
                        Console.WriteLine("You must enter just one symbol. Try again.");
                    else
                    {
                        char targetSymbol;
                        targetSymbol = char.Parse(specificSymbol);
                        foreach (char c in userInput)
                        {
                            if (c == char.ToLower(targetSymbol) ||
                                c == char.ToUpper(targetSymbol)) specificSymbolCounter++;
                        }

                        finishedLookingForSpecificSymbol = true;
                        lookingForSpecificSymbol = false;
                    }
                } while (finishedLookingForSpecificSymbol == false);
            }
            else lookingForSpecificSymbol = false;
        } while (lookingForSpecificSymbol);
        
        symbolsCount = userInput.Length;
        
        Console.WriteLine($"This string contains {symbolsCount} symbols.");
        
        if(specificSymbolCounter != 0)
            Console.WriteLine($"Number of specific symbols found: {specificSymbolCounter}");
        else Console.WriteLine($"No specific symbols found.");
    }
}