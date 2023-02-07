/*
//=============================================================================================================
//Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int Polindrom(int number)
{
  int resultNumber = number, revNumber= 0;                
  while (resultNumber > 0)                               
  {
      revNumber = revNumber*10 + resultNumber%10;      
      resultNumber /= 10;                           
  }
  return revNumber;
}
Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
    if (number == Polindrom(number))
    {
    Console.WriteLine($"Number {number} is "  + " a polindrom ");
    }
    else
    {
      Console.WriteLine($"Number {number} is "  + " not a polindrom ");
    }
*/
//=================================================================================================================================
// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double LengthSegment(double x1, double y1, double z1, double x2, double y2, double z2)
{
  double result = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2)); 
  return result;
}
Console.WriteLine(" Input x1:  ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input x2:");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Length of the segment:" + Math.Round(LengthSegment(x1,y1,z1,x2,y2,z2),3));
*/
//=========================================================================================================

// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void NumberCub(int  N)
{
    int i = 1;
    while (i<=N)
    {
     Console.Write(i*i*i + " ");
     i++;
    }
}
Console.WriteLine("Input a number:  ");
int N = Convert.ToInt32(Console.ReadLine());
NumberCub(N);
*/