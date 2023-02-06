// Program takes the positive integer number N as input and gives a table of cubes of numbers in range [1,N]


int num = 0, cube = 0;
int count = 1;

while (num < 1)
{
    Console.Write("Enter the positive integer number: ");
    num = int.Parse(Console.ReadLine());
}

while (count <= num)
{
    cube = count * count * count;
    Console.Write($"{cube}, ");
    count++;
}