int[] a = new int[3];
int[] b = new int[3];

void readPointCoordinates(string pointName, int[] arr)
{
    Console.WriteLine("Введите координаты точки " + pointName);
    Console.Write("X:");
    arr[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Y:");
    arr[1] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Z:");
    arr[2] = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("");
}

readPointCoordinates("A", a);
readPointCoordinates("B", b);

double xx = Math.Pow(b[0] - a[0], 2);
double yy = Math.Pow(b[1] - a[1], 2);
double zz = Math.Pow(b[2] - a[2], 2);

double distance = Math.Sqrt(xx + yy + zz);

Console.Write("Расстояние между точками: ");
Console.WriteLine(Math.Round(distance, 2));