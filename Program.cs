namespace HW4;

class Program
{
    static void Main(string[] args)
    {
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
    }
}