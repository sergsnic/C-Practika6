// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите разряд числа Фибоначи: ");
int sizeFibonacci = Convert.ToInt32(Console.ReadLine());
int[] arrayFibonacci = new int[sizeFibonacci + 1];
for (int i = 0; i <= sizeFibonacci; i++)
{
    if (i == 0) arrayFibonacci[0] = 0;
    if (i == 1) arrayFibonacci[1] = 1;
    if (i >= 2) arrayFibonacci[i] = arrayFibonacci[i - 1] + arrayFibonacci[i - 2];
}
Console.Write("Числа Фибоначи: ");
Console.Write(String.Join(" ", arrayFibonacci));