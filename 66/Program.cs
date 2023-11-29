// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

//Функция чтения введенного числа с консоли
int ReadInt(string message) 
{ 
    Console.WriteLine(message); 
    int result = Convert.ToInt32(Console.ReadLine()); 
    return result; 
} 

//Функция нахождения суммы всех натуральных чисел от M до N включительно
int PrintNaturalNum(int M, int N) 
{ 
    int sum = 0;
    if (N < M) 
    { 
        return 0; 
    } 
    return sum=M+PrintNaturalNum(M + 1, N);
} 


int M = ReadInt("Введите первое число M"); 
int N = ReadInt("Введите второе число N"); 
System.Console.Write(PrintNaturalNum(M, N));