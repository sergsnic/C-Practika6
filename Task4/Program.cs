// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int decimalToBinary(int decimalNumber)
{
    string invertedResult = string.Empty;
    while (decimalNumber > 0)
    {
        invertedResult += Convert.ToString(decimalNumber % 2);
        decimalNumber = decimalNumber / 2;
    }
    string result = string.Empty;
    int sizeString = invertedResult.Length;
    for (int i = 0; i < sizeString; i++) result += invertedResult[sizeString - 1 - i];
    return Convert.ToInt32(result);
}

System.Console.Write("Введите десятичное число: ");
Console.Write($"Двоичное число: {decimalToBinary(Convert.ToInt32(Console.ReadLine()))}");