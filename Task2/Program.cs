// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void PositiveNumbersArray(int arraySize)
{
    int count = 0;
    int[] arrayNumbers = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        System.Console.Write($"Введите {i}е число: ");
        arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
        if (arrayNumbers[i] > 0) count++;
    }
    Console.Write($"В массиве: [{String.Join(" ", arrayNumbers)}] положительных чисел {count}");
}
System.Console.Write("Введите число М: ");
int size = Convert.ToInt32(Console.ReadLine());
PositiveNumbersArray(size);