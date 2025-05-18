namespace HW4;

class Program
{
    static void Main(string[] args)
    {
        // Task 1
        int[] nums = new int[50];

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = i * 2;
        }

        foreach (int numbers in nums)
        {
            Console.WriteLine($"Element: {numbers}");
        }
        // End of Task 1
        
        
        // Task 2
        int[] number = new int[33];
        int evenNumbersCounter = 0;
        List<int> evenNumbers = new List<int>();
        
        Random random_number = new Random();

        for (int i = 0; i < number.Length; i++)
        {
            number[i] = random_number.Next(0, 100);
        }

        for(int i = 0; i < number.Length; i++)
        {
            if (number[i] % 2 == 0)
            {
                evenNumbersCounter++;
                evenNumbers.Add(number[i]);
            }
        }
        
        Console.WriteLine($"Array includes {evenNumbersCounter} even numbers.");
        Console.Write("It's: ");
        
        for(int i = 0; i < evenNumbers.Count; i++)
        {
            Console.Write(evenNumbers[i]);
            if(i != evenNumbers.Count - 1)
                Console.Write(", ");
        }
        // End of Task 2
        
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