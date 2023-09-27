//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int AboveZeroNumsCount(int[] Array)
{
    int Length = Array.Length;
    int Count = 0;
    for(int i = 0; i < Length; i++)
    {
        if (Array[i] > 0)
        {
            Count++;
        }
    }
    return Count;
}

int[] GetNum(string M)
{
    Console.Write($"Введите количество элементов {M} / ");
    int ArrayLength = int.Parse(Console.ReadLine()!);
    Console.WriteLine("");
    int[] Array = new int[ArrayLength];
    for(int i = 0; i < ArrayLength; i++)
    {
        Console.Write($"Введите элемент #{i+1}: ");
        Array[i] = int.Parse(Console.ReadLine()!);
        Console.WriteLine("");
    }
    return Array;
}
int[] array = GetNum("M");
int result = AboveZeroNumsCount(array);
Console.WriteLine($"Кол-во чисел больше нуля = {result}");