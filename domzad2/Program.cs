// **Задача 66:** Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120M = 4; N = 8. -> 30


int ReadInt(string prompt)
{
    Console.Write(prompt);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfNumber(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;            // Если M равно нулю
    else if (N == 0) return (M * (M + 1)) / 2;       // Если N равно нулю
    else if (M == N) return M;                       // Если M=N
    else if (M < N) return N + SumOfNumber(M, N - 1); // Если M<N
    else return N + SumOfNumber(M, N + 1);            // Если M>N
}

int m = ReadInt("Введите число m: ");
int n = ReadInt("Введите число n больше m, иначе программа будет суммирвоать числа от n до m: ");
Console.WriteLine($"Cумму натуральных элементов в промежутке от m до n:  {SumOfNumber(m,n)}");