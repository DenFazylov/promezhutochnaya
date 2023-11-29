// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


//Функция чтения введенного числа с консоли
int ReadInt(string message) 
{ 
    Console.WriteLine(message); 
    int result = Convert.ToInt32(Console.ReadLine()); 
    return result; 
} 

//Функция вычисления функции Аккермана двух неотрицательных натуральных чисел  N и M.
int Akkerman(int N, int M) 
{ 
   if (N == 0)
    return M + 1;
  else
    if ((N != 0) && (M == 0))
      return Akkerman(N - 1, 1);
    else
      return Akkerman(N - 1, Akkerman(N, M - 1));
} 


int N = ReadInt("Введите первое число N"); 
int M = ReadInt("Введите второе число M"); 
System.Console.Write($"A({N},{M}) = {Akkerman(N, M)}");