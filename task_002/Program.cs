// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string messege)
{
    System.Console.Write(messege);
    return Convert.ToInt32(Console.ReadLine());
}

int SumElement(int m, int n)
{
    if (m == n) return n;
    else return m + SumElement(m + 1, n);
}


int leftRange = ReadInt("Enter left number: ");
int rightRange = ReadInt("Enter right number: ");



System.Console.WriteLine(SumElement(leftRange, rightRange));