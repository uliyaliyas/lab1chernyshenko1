высокий уровень
Console.Write("Введите a:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите b:");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Введите x:");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите z:");
double z = double.Parse(Console.ReadLine());
double f = (Math.Cos(7) * b * Math.Pow(x, 5) - (Math.Sin(a * a) + Math.Cos((x * x * x) + Math.Pow(z, 5) - (a * a)))) / (Math.Asin(a * a) + Math.Acos(Math.Pow(x, 7) - (a * a)));
Console.WriteLine($"f={f:F2}");