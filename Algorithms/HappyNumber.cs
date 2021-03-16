using System;

public static class HappyNumber
{

    public static bool find(int num)
    {
        int slow = num, fast = num;
        do
        {
            slow = findSquareSum(slow); // move one step
            fast = findSquareSum(findSquareSum(fast)); // move two steps
            Console.WriteLine($"Slow: {slow} Fast:{fast}");
        } while (slow != fast); // found the cycle

        return slow == 1; // see if the cycle is stuck on the number '1'
    }

    private static int findSquareSum(int num)
    {
        int sum = 0, digit;
        while (num > 0)
        {
            digit = num % 10;
            sum += digit * digit;
            num /= 10;
        }
        return sum;
    }

    public static void Execute()
    {
        Console.WriteLine(HappyNumber.find(23));
        Console.WriteLine(HappyNumber.find(12));
    }
}