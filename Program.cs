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
    }
}