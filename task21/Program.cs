// Program calculates the distance between two point in space

double[] x = new double[2];
double[] y = new double[2];
double[] z = new double[2];
double dist = 0.0;

for (int i = 1; i < 3; i++)
{
    Console.Write($"Enter X{i}: ");
    x[i - 1] = double.Parse(Console.ReadLine());
    Console.Write($"Enter Y{i}: ");
    y[i - 1] = double.Parse(Console.ReadLine());
    Console.Write($"Enter Z{i}: ");
    z[i - 1] = double.Parse(Console.ReadLine());
}

dist = Math.Sqrt((x[1] - x[0]) * (x[1] - x[0])
                + (y[1] - y[0]) * (y[1] - y[0])
                + (z[1] - z[0]) * (z[1] - z[0]));

Console.WriteLine($"Distance between points ({x[0]},{y[0]},{z[0]}) and ({x[1]},{y[1]},{z[1]}) is {dist}.");