// Console.Clear();
// Console.Write("Введите ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// double x2 = Convert.ToDouble(Console.ReadLine());
// double y1 = Convert.ToDouble(Console.ReadLine());
// double y2 = Convert.ToDouble(Console.ReadLine());

// double c=0;
// c=Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
// Console.Write(c);

// // task 21

// Console.Clear();
// Console.WriteLine("Введите координату точки A: ");
// double xa = Convert.ToDouble(Console.ReadLine());
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату точки B: ");
// double xb = Convert.ToDouble(Console.ReadLine());
// double yb = Convert.ToDouble(Console.ReadLine());

// double result = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2));
// Console.WriteLine($"Расстояние между точками: {Math.Round(result, 3)}");

Console.Clear();
Console.WriteLine("Vvedite koordinatu a: ");
double x1=Convert.ToDouble(Console.ReadLine());
double y1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Vvedite koordinatu b: ");
double x2=Convert.ToDouble(Console.ReadLine());
double y2=Convert.ToDouble(Console.ReadLine());

double result= Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
Console.WriteLine($"Rasstoanie mezhdu tochkami: {Math.Round(result,3)}");