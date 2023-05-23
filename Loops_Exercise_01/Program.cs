// CALL YOUR METHODS HERE

//Console.WriteLine(Reverse("Hello, World!"));
//PrintOddsBelow1000();
//Console.WriteLine(NumberOfDigits(1111111111));
//Console.WriteLine(NumberOfOccurences("ababababaabaaaaaaa", 'a'));
//Console.WriteLine(SumOfDigits(199999999));
CreatePattern();


// TODO: Create a method that takes a string as input and prints the string in reverse order using a loop.
static string Reverse(string s)
{
    var reversed = "";
    for (int i = s.Length - 1; i >= 0; i--)
	{
        reversed += s[i];
    }
    return reversed;
}


// TODO: Create a method that print all of the odd numbers below 1000
static void PrintOddsBelow1000()
{
    for (int i = 0; i < 1000; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(i);
        }
    }
}


// TODO: Create a method that takes a number from the user and returns the number of digits in that number
static int NumberOfDigits(int num)
{
    var count = 0;
    foreach (var digit in num.ToString())
    {
        count++;
    }
    return count;
}


// TODO: Create a method that takes a string and a character and returns the number of times that character appears in the string
static int NumberOfOccurences(string str, char letter)
{
    var count = 0;
    foreach (var l in str)
    {
        if (l == letter)
        {
            count++;
        }
    }
    return count;
}


// TODO: Create a method that takes a number and calculates the sum of it's digits
static int SumOfDigits(int num)
{
    var sum = 0;
    foreach (var digit in $"{num}")
    {
        sum += int.Parse($"{digit}");
    }
    return sum;
}


// Bonus:  Create a method that prints a patern.
// Use a loop and a nested loop to print the following pattern:
// (ignore the mult-line comment symbols /* */ )
/*

 *
 **
 ***
 ****
 *****

 */
static void CreatePattern()
{
    for (int i = 0; i <= 5; i++)
    {
        for (int j = 0; j < i; j++)
        {
            Console.Write('*');
        }
        Console.WriteLine();
    }
}