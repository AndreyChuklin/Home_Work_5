void Zadacha34()
{
    // Задача 34: Задайте массив заполненный случайными 
    // положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


    Random random = new Random();
    int size = random.Next(7, 15);
    int[] array = new int[size];
    FillArray(array, 100, 999);
    PrintArray(array);

    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    Console.WriteLine($"В массиве {count} четных чисел ");
}



void Zadacha36()
{
    //Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

    Random random = new Random();
    int size = random.Next(8, 15);
    int[] array = new int[size];
    FillArray(array, 0, 10);
    PrintArray(array);

    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    Console.WriteLine($"Сумма элементов на нечетных позициях равна {sum} ");
}

void Zadacha38()
{
    //Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


    Random random = new Random();
    int size = random.Next(5, 15);
    double[] array = new double[size];
    FillArrayDouble(array, 1000, 10000);
    PrintArrayDouble(array);

    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i += 2)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"Разница между максимальным {max} и минимальным {min} элементами равна {max - min} ");
}




void FillArray(int[] array, int startNumber = -10, int finishNumber = 10)
{
    finishNumber++;
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startNumber, finishNumber);
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}

void FillArrayDouble(double[] array, int startNumber = -10, int finishNumber = 10)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(random.NextDouble() * 100 - 50, 2);
    }
}

void PrintArrayDouble(double[] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}


//Zadacha34();
//Zadacha36();
Zadacha38();




