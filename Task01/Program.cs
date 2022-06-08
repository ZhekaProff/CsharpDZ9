// Показать натуральные числа от M до N, N и M заданы
// Найти сумму элементов от M до N, N и M заданы
void PrintNumbera(int m, int n)  
{
    
    if (n < m) return;
    Console.Write(n + " ");
    PrintNumbera(m, n - 1);
}

int Sum(int m, int n)
{
    if (n == m) return n;
    return m + Sum(m + 1, n);
}

Console.Write("Введите число N: ");
int M = int.Parse(Console.ReadLine() ?? "0"); 
Console.Write("Введите число M: ");
int N = int.Parse(Console.ReadLine() ?? "0"); 

PrintNumbera(M, N);
Console.WriteLine();
Console.WriteLine($"Сумма элементов от {N} до {M} = {Sum(M, N)}");