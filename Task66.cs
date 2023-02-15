/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15-> 120
M = 4; N = 8. -> 30*/

int M = 1;
int N = 15;

void PrintNums(int start, int end, int sum)
{
    if (start > end)
    {
        Console.WriteLine(sum);
        return;
    }
    sum += start++;
    PrintNums(start, end, sum);
}

PrintNums(M, N, 0);
Console.ReadLine();