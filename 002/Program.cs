// Console.Clear();

// Console.Write("Введите координату X: ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y: ");
// double y = Convert.ToDouble(Console.ReadLine());

// if (x > 0 && y > 0)
//     Console.WriteLine("I");
// else if (x < 0 && y > 0)
//     Console.WriteLine("II");
// else if (x < 0 && y < 0)
//     Console.WriteLine("III");
// else
//     Console.WriteLine("IV");

Console.Clear();
Console.WriteLine("Vvedite x: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Vvedite y: ");
double y = Convert.ToDouble(Console.ReadLine());
if(x>0&&y>0)
Console.WriteLine("I");
else if (x<0&&y>0)
Console.WriteLine("II");
else if (x<0&&y<0)
Console.WriteLine("III");
else 
Console.WriteLine("IV");
