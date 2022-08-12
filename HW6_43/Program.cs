/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
 y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5) */

Console.WriteLine("Введите первую точку(b1): ");
double pointOne = double.Parse(Console.ReadLine());

Console.WriteLine("Введите вторую точку(b2): ");
double pointTwo = double.Parse(Console.ReadLine());

Console.WriteLine("Введите третью точку(k1): ");
double pointThree = double.Parse(Console.ReadLine());

Console.WriteLine("Введите четвертую точку(k2): ");
double pointFour = double.Parse(Console.ReadLine());

double resX = -(pointTwo - pointOne) / (pointFour - pointThree);
double resY = pointThree * resX + pointOne;

resX = Math.Round(resX, 3);
resY = Math.Round(resY, 3);

Console.WriteLine($"Intersection of points: ({resX};{resY})");


