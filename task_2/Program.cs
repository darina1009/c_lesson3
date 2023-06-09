using System.Linq.Expressions;

Console.WriteLine("vvedite koordinaty A(x)");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("vvedite koordinaty A(y)");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("vvedite koordinaty A(z)");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("vvedite koordinaty B(x)");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("vvedite koordinaty B(y)");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("vvedite koordinaty b(z)");
int z2 = Convert.ToInt32(Console.ReadLine());
double res = Math.Round(Math.Sqrt((Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2))));
Console.WriteLine(res);
