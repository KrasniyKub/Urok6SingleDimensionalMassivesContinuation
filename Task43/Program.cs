//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
double[] GetFourNums(string Text, string Text2)
{
    Console.Write($"Введите k{Text} прямой {Text} : ");
    double k = double.Parse(Console.ReadLine()!);
    Console.Write($"Введите b{Text} прямой {Text} : ");
    double b = double.Parse(Console.ReadLine()!);
    Console.WriteLine();
    Console.Write($"Введите k{Text2} прямой {Text2} : ");
    double k2 = double.Parse(Console.ReadLine()!);
    Console.Write($"Введите b{Text2} прямой {Text2} : ");
    double b2 = double.Parse(Console.ReadLine()!);
    Console.WriteLine();
    double[] Array = {k, k2, b, b2};
    return Array;
}

void GetIntersectionPoint()
{
    double[] K2B2 = GetFourNums("1", "2");
    double x = (K2B2[2]-K2B2[3])/(K2B2[1]-K2B2[0]);
    double y = K2B2[0]*x+K2B2[2];
    Console.WriteLine("Точка пересечения прямых x = " + x + " ; y = " + y);
}
GetIntersectionPoint();
