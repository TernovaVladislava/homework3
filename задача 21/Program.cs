Console.WriteLine ("Введите координаты 1 точки:");
int ax = int.Parse(Console.ReadLine()!);
int ay = int.Parse(Console.ReadLine()!);
int az = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите координаты 2 точки:");
int bx = int.Parse(Console.ReadLine()!);
int by = int.Parse(Console.ReadLine()!);
int bz = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Растояние равно {Math.Sqrt(Math.Pow(aх-bх,2)+Math.Pow(ay-by,2)+Math.Pow(az-bz,2)):f2}"); 

