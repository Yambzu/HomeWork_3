// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void IsPalindrom(string number)
{
    int len = number.Length;     
    if(len == 5)
    {
        if(number[0] == number[4] && number[1] == number[3])
        Console.WriteLine($"{number} - Palindrom");
        else
        Console.WriteLine($"{number} - Not palindrom");
    }
    else
    Console.WriteLine($"{number} - not a five-digit number");
}

Console.Write("Input a five-digit number:");
string number = Console.ReadLine() ?? "";
IsPalindrom(number);
*/

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double getDistance(double numOneX, double numTwoX, double numOneY, double numTwoY, double numOneZ, double numTwoZ)
{
    double distance = Math.Sqrt((numTwoX - numOneX) * (numTwoX - numOneX) + (numTwoY - numOneY) * (numTwoY - numOneY) + (numTwoZ - numOneZ) * (numTwoZ - numOneZ));
    return Math.Round(distance, 2);                                         
}

Console.Write("Input x1-coordinate: ");
double numOneX = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2-coordinate: ");
double numTwoX = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1-coordinate: ");
double numOneY = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2-coordinate: ");
double numTwoY = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z1-coordinate: ");
double numOneZ = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z2-coordinate: ");
double numTwoZ = Convert.ToDouble(Console.ReadLine());


double vDistance = getDistance(numOneX,numTwoX,numOneY,numTwoY,numOneZ,numTwoZ); 

Console.WriteLine($"The distance between them in 3D space {vDistance}"); 
*/

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void showSqrt(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine(i * i * i);
    }
}                                

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
showSqrt(n);
*/