void Zadacha_31()
// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива

{
    int size = 12;
    int[] array = new int[size];
    FillArray(array, -9, 9);
    PrintArray(array);

    int SumPositiv = 0;
    int SumNegativ = 0;

    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0) SumPositiv += array[i];
        else SumNegativ += array[i];
    }
    Console.WriteLine("Сумма положительных элементов равна " + SumPositiv);
    Console.WriteLine("Сумма отрицательных элементов равна " + SumNegativ);
}

void Zadacha_32()
// Задача 32: Напишите программу замены элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот
{
    Random random = new Random();
    int size = random.Next(5, 15);
    int[] array = new int[size];
    FillArray(array, -15, 15);
    Console.WriteLine("Исходный массив ");
    PrintArray(array);
    Reverse(array);    
    Console.WriteLine("Инвертированный массив ");
    PrintArray(array);
}

void Zadacha_33()
// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве
{
    Random random = new Random();
    int size = random.Next(5, 15);
    int[] array = new int[size];
    FillArray(array, -15, 15);
    Console.WriteLine("Исходный массив ");
    PrintArray(array);
    int Number = random.Next(-15, 1);
    Console.WriteLine("Заданное число равно " + Number);
    bool flag = false;
    for (int i = 0; i < size && !flag; i++) //! - отрицание утверждения, инверитирование
    {
        flag = Number == array[i]; 
    }
        if (flag) Console.WriteLine("Заданное число есть в массиве ");
        else Console.WriteLine("Заданного числа нет в массиве ");
}

void Zadacha_35()
// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]
{
    int size = 10;
    int[] array = new int[size];
    FillArray(array, -99, 99);
    Console.WriteLine("Заданный массив " );
    PrintArray(array);
    int count = 0;

    for (int i = 0; i < size; i++)
    {
        if (array[i] >= 10 && array[i] <= 99) count ++;  
    }
    Console.WriteLine("Количество элементов массива из заданного промежутка равно " + count);
}

void Zadacha_37()
// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве
{
    int size = 11;
    int[] array = new int[size];
    int maxIndex = size - 1;
    FillArray(array, 0, 10);
    Console.WriteLine("Заданный массив " );
    PrintArray(array);
    int halfSize = size/2;
    Console.WriteLine("Полученный массив ");    

    for (int i = 0; i < halfSize; i++)
    {       
        Console.Write((array[i] * array[maxIndex - i]) + "\t");  //вывод табуляции
    }
    if (size % 2 == 1) Console.WriteLine(array[halfSize]);

}

void FillArray(int[] array, int startNumber, int finishNumber)
{
    finishNumber++; //чтобы учитывалась цифра 9 [9, 9[
    Random random = new Random();
    for (int i = 0; i < array.Length; i ++)
    {
        array[i] = random.Next(startNumber, finishNumber);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void Reverse(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;       
    }
}

// Zadacha_31();
// Zadacha_32();
// Zadacha_33();
// Zadacha_35();
Zadacha_37();