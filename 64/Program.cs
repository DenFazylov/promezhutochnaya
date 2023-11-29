// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

//Функция чтения введенного числа с консоли
int ReadInt(string message) 
{ 
    System.Console.WriteLine(message); 
    int result = System.Convert.ToInt32(Console.ReadLine()); 
    return result; 
} 

//Функция нахождения всех натуральных четных чисел от M до N включительно
void PrintEvenNaturalNum(int M, int N) 
{ 
    if (N < M)
    { 
        return; 
    }
    if (M%2==0)
    {
        System.Console.Write($"{M}\t"); 
    }
    PrintEvenNaturalNum(M + 1, N); 
    
} 

int M = ReadInt("Введите первое число"); 
int N = ReadInt("Введите второе число"); 
PrintEvenNaturalNum(M, N);