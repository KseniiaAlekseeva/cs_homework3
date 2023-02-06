// Program takes a 5-digit number as input and checks if it is a palindrome.

int num = 0, absNum = 0;

while ((absNum / 10000 < 1) || (absNum / 10000 > 9))
{
    Console.Write("Enter a 5-digit number: ");
    num = int.Parse(Console.ReadLine());
    absNum = Math.Abs(num);
}

if ((absNum / 10000 == absNum % 10) && (absNum / 1000 % 10 == absNum % 100 / 10))
    Console.WriteLine($"Number {num} is a palindrome.");
else
    Console.WriteLine($"Number {num} is not a palindrome.");