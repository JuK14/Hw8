// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


int[,] FillArray(int row, int column, int min, int max)
{
    int[,] fill = new int[row, column];
    for (int i = 0; i < fill.GetLength(0); i++)
    {
        for (int j = 0; j < fill.GetLength(1); j++)
        {
            fill[i, j] = new Random().Next(min, max);
        }
    }
    return fill;
}

void PrintArray(int[,] print)
{
    for (int i = 0; i < print.GetLength(0); i++)
    {
        for (int j = 0; j < print.GetLength(1); j++)
        {
            Console.Write(print[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Задайте количество строк в массиве: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Задайте количество столбцов в массиве: ");
int column = int.Parse(Console.ReadLine());

while (row < 0 || column < 0)
{
    if (row < 0)
    {
        Console.Write("Вы ввели отрицательное количество строк. Задайте еще раз количество строк в массиве: ");
        row = int.Parse(Console.ReadLine());
    }
    if (column < 0)
    {
        Console.Write("Вы ввели отрицательное количество столбцов. Задайте еще раз количество столбцов в массиве: ");
        column = int.Parse(Console.ReadLine());
    }
}

Console.Write("Задайте минимальное значение диапазона генерации случайных чисел: ");
int minMeaning = int.Parse(Console.ReadLine());
Console.Write("Задайте максимальное значение диапазона генерации случайных чисел: ");
int maxMeaning = int.Parse(Console.ReadLine());

while (minMeaning > maxMeaning)
{
    Console.Write("Вы задали минимальное значение диапазона генерации случайных чисел больше чем максимальное. ");
    Console.WriteLine("Сформировать такой диапазон генерации случайных чисел невозможно.");
    Console.Write("Задайте минимальное значение диапазона генерации случайных чисел меньше чем максимальное: ");
    minMeaning = int.Parse(Console.ReadLine());
    Console.Write("Задайте максимальное значение диапазона генерации случайных чисел: ");
    maxMeaning = int.Parse(Console.ReadLine());
}

int[,] array = FillArray(row, column, minMeaning, maxMeaning);
Console.WriteLine("Двумерный массив, заполненный случайными числами: ");
PrintArray(array);
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = j + 1; k < array.GetLength(1); k++)
        {
            if (array[i, j] < array[i, k])
            {
                int temp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = temp;
            }
        }
    }
}

Console.WriteLine("Двумерный массив, упорядоченный по убыванию элементов в каждой строке: ");
PrintArray(array);





// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] FillArray(int row, int column, int min, int max)
{
    int[,] fill = new int[row, column];
    for (int i = 0; i < fill.GetLength(0); i++)
    {
        for (int j = 0; j < fill.GetLength(1); j++)
        {
            fill[i, j] = new Random().Next(min, max);
        }
    }
    return fill;
}

void PrintArray(int[,] print)
{
    for (int i = 0; i < print.GetLength(0); i++)
    {
        for (int j = 0; j < print.GetLength(1); j++)
        {
            Console.Write(print[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Задайте количество строк в массиве: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Задайте количество столбцов в массиве: ");
int column = int.Parse(Console.ReadLine());

while (row < 0 || column < 0)
{
    if (row < 0)
    {
        Console.Write("Вы задали отрицательное количество строк. Введите заново количество строк в массиве: ");
        row = int.Parse(Console.ReadLine());
    }
    if (column < 0)
    {
        Console.Write("Вы задали отрицательное количество столбцов. Введите заново количество столбцов в массиве: ");
        column = int.Parse(Console.ReadLine());
    }
}

Console.Write("Задайте минимальное значение диапазона генерации случайных чисел: ");
int minMeaning = int.Parse(Console.ReadLine());
Console.Write("Задайте максимальное значение диапазона генерации случайных чисел: ");
int maxMeaning = int.Parse(Console.ReadLine());

while (minMeaning > maxMeaning)
{
    Console.Write("Вы задали минимальное значение диапазона генерации случайных чисел больше чем максимальное. ");
    Console.WriteLine("Сформировать такой диапазон генерации случайных чисел невозможно.");
    Console.Write("Задайте минимальное значение диапазона генерации случайных чисел меньше чем максимальное: ");
    minMeaning = int.Parse(Console.ReadLine());
    Console.Write("Задайте максимальное значение диапазона генерации случайных чисел: ");
    maxMeaning = int.Parse(Console.ReadLine());
}

int[,] array = FillArray(row, column, minMeaning, maxMeaning);
Console.WriteLine("Двумерный массив, заполненный случайными числами: ");
PrintArray(array);
Console.WriteLine();

int[] array2 = new int[row];

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    array2[i] = sum;
}

Console.WriteLine($"Сумма элементов в каждой строке {string.Join(",", array2)}.");

int imin = 0;
int min = array2[0];

for (int i = 0; i < array2.Length; i++)
{
    if (array2[i] < min)
    {
        min = array2[i];
        imin = i;
    }
}

Console.Write($"Ответ: Cтрока с наименьшей суммой элементов: {imin + 1} строка.");

for (int i = 0; i < array2.Length; i++)
{
    if (imin == i)
    {
        continue;
    }
    if (array2[imin] == array2[i])
    {
        Console.Write($" Cумма элементов {i + 1} строки равна сумме элементов в {imin + 1} строке.");
    }
}











// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] FillArray(int row, int column, int min, int max)
{
    int[,] fill = new int[row, column];
    for (int i = 0; i < fill.GetLength(0); i++)
    {
        for (int j = 0; j < fill.GetLength(1); j++)
        {
            fill[i, j] = new Random().Next(min, max);
        }
    }
    return fill;
}

void PrintArray(int[,] print)
{
    for (int i = 0; i < print.GetLength(0); i++)
    {
        for (int j = 0; j < print.GetLength(1); j++)
        {
            Console.Write(print[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int MinMax(int min, int max)
{
    while (min > max)
    {
        Console.Write("Вы ввели минимальное значение диапазона генерации случайных чисел больше чем максимальное. ");
        Console.WriteLine("Сформировать такой диапазон генерации случайных чисел невозможно.");
        Console.Write("Введите минимальное значение диапазона генерации случайных чисел меньше чем максимальное: ");
        min = int.Parse(Console.ReadLine());        
    }
    return min;
}

Console.Write("Введите количество строк в первой матрице: ");
int rowArray1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в первой матрице: ");
int columnArray1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк во второй матрице: ");
int rowArray2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов во второй матрице: ");
int columnArray2 = int.Parse(Console.ReadLine());

while (rowArray1 < 0 || columnArray1 < 0 || rowArray2 < 0 || columnArray2 < 0 || columnArray1 != rowArray2)
{
    if (rowArray1 < 0)
    {
        Console.Write("Вы ввели отрицательное количество строк в первой матрице. Введите заново количество строк: ");
        rowArray1 = int.Parse(Console.ReadLine());
    }
    if (columnArray1 < 0)
    {
        Console.Write("Вы ввели отрицательное количество столбцов в первой матрице. Введите заново количество столбцов: ");
        columnArray1 = int.Parse(Console.ReadLine());
    }
    if (rowArray2 < 0)
    {
        Console.Write("Вы ввели отрицательное количество строк во второй матрице. Введите заново количество строк: ");
        rowArray2 = int.Parse(Console.ReadLine());
    }
    if (columnArray2 < 0)
    {
        Console.Write("Вы ввели отрицательное количество столбцов во второй матрице. Введите заново количество столбцов: ");
        columnArray2 = int.Parse(Console.ReadLine());
    }
    if (columnArray1 != rowArray2)
    {
        Console.WriteLine("Умножить две матрицы можно только в том случае, если число столбцов первой равняется числу строк второй.");
        Console.Write("Введите количество столбцов в первой матрице: ");
        columnArray1 = int.Parse(Console.ReadLine());
        Console.Write("Введите количество строк во второй матрице: ");
        rowArray2 = int.Parse(Console.ReadLine());
    }
}

Console.Write("Введите минимальное значение диапазона генерации случайных чисел в первой матрице: ");
int minMeaningArray1 = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение диапазона генерации случайных чисел в первой матрице: ");
int maxMeaningArray1 = int.Parse(Console.ReadLine());

minMeaningArray1 = MinMax(minMeaningArray1, maxMeaningArray1);

Console.Write("Введите минимальное значение диапазона генерации случайных чисел во второй матрице: ");
int minMeaningArray2 = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение диапазона генерации случайных чисел во второй матрице: ");
int maxMeaningArray2 = int.Parse(Console.ReadLine());

minMeaningArray2 = MinMax(minMeaningArray2, maxMeaningArray2);

int[,] array1 = FillArray(rowArray1, columnArray1, minMeaningArray1, maxMeaningArray1);
int[,] array2 = FillArray(rowArray2, columnArray2, minMeaningArray2, maxMeaningArray2);

Console.WriteLine("Первая матрица, заполненная случайными числами: ");
PrintArray(array1);
Console.WriteLine();

Console.WriteLine("Вторая матрица, заполненная случайными числами: ");
PrintArray(array2);
Console.WriteLine();

int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];

for (int i = 0; i < array3.GetLength(0); i++)
{
    for (int j = 0; j < array3.GetLength(1); j++)
    {
        for (int k = 0; k < array1.GetLength(1); k++)
        {
            array3[i, j] += array1[i, k] * array2[k, j];
        }
    }
}

Console.WriteLine("ответ: Произведение двух матриц: ");
PrintArray(array3);










// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int RepeatNumber(int arg1, int arg2, int arg3, int[,,] repeat)
{
    int resul = 0;
    for (int k = 0; k < repeat.GetLength(2); k++)
    {
        for (int i = 0; i < repeat.GetLength(0); i++)
        {
            for (int j = 0; j < repeat.GetLength(1); j++)
            {
                if (i == arg1 && j == arg2 && k == arg3)
                {
                    continue;
                }
                if (repeat[arg1, arg2, arg3] == repeat[i, j, k])
                {
                    resul = 1;
                    return resul;
                }
            }
        }
    }
    return resul;
}

int QuantityNumber(int number)
{
    int quantity = 0;
    number = Math.Abs(number);
    while (number > 0)
    {
        number /= 10;
        quantity++;
    }
    return quantity;
}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());
Console.Write("Введите количество элементов длинны массива: ");
int size = int.Parse(Console.ReadLine());

while (row < 0 || column < 0 || size < 0)
{
    if (row < 0)
    {
        Console.Write("Вы ввели отрицательное количество строк. Введите заново количество строк в массиве: ");
        row = int.Parse(Console.ReadLine());
    }
    if (column < 0)
    {
        Console.Write("Вы ввели отрицательное количество столбцов. Введите заново количество столбцов в массиве: ");
        column = int.Parse(Console.ReadLine());
    }
    if (size < 0)
    {
        Console.Write("Вы ввели отрицательное количество элементов длинны массива. Введите заново количество элементов длинны массива: ");
        size = int.Parse(Console.ReadLine());
    }
}

Console.Write("Введите двузначное число, которое будет минимальным значением диапазона генерации случайных чисел: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите двузначное число, которое будет максимальным значением диапазона генерации случайных чисел: ");
int max = int.Parse(Console.ReadLine());

int countMin = QuantityNumber(min);
int countMax = QuantityNumber(max);

while (min > max || countMin != 2 || countMax != 2 || (min < -9 && max > 9))
{
    if (min > max)
    {
        Console.Write("Вы ввели минимальное значение диапазона генерации случайных чисел больше чем максимальное. ");
        Console.WriteLine("Сформировать такой диапазон генерации случайных чисел невозможно.");
        Console.Write("Введите двузначное число, которое будет минимальным значением диапазона генерации случайных чисел: ");
        min = int.Parse(Console.ReadLine());
        Console.Write("Введите двузначное число, которое будет максимальным значением диапазона генерации случайных чисел: ");
        max = int.Parse(Console.ReadLine());
        countMin = QuantityNumber(min);
        countMax = QuantityNumber(max);
    }
    if (countMin != 2)
    {
        Console.Write("Вы ввели не двузначное число. ");
        Console.Write("Введите двузначное число, которое будет минимальным значением диапазона генерации случайных чисел: ");
        min = int.Parse(Console.ReadLine());
        countMin = QuantityNumber(min);
    }
    if (countMax != 2)
    {
        Console.Write("Вы ввели не двузначное число. ");
        Console.Write("Введите двузначное число, которое будет максимальным значением диапазона генерации случайных чисел: ");
        max = int.Parse(Console.ReadLine());
        countMax = QuantityNumber(max);
    }
    if (min < -9 && max > 9)
    {
        Console.WriteLine("Вы ввели значения диапазона генерации случайных чисел при которых он будет заполнен не двузначными числами. ");
        Console.Write("Введите двузначное число, которое будет минимальным значением диапазона генерации случайных чисел: ");
        min = int.Parse(Console.ReadLine());
        Console.Write("Введите двузначное число, которое будет максимальным значением диапазона генерации случайных чисел: ");
        max = int.Parse(Console.ReadLine());
        countMin = QuantityNumber(min);
        countMax = QuantityNumber(max);
    }
}

int[,,] array = new int[row, column, size];

for (int k = 0; k < array.GetLength(2); k++)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j, k] = new Random().Next(min, max);
            int resul = RepeatNumber(i, j, k, array);
            while (resul == 1)
            {
                array[i, j, k] = new Random().Next(min, max);
                resul = RepeatNumber(i, j, k, array);
            }
        }
    }
}

for (int k = 0; k < array.GetLength(2); k++)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j, k]} ({i},{j},{k})  ");
        }
        Console.WriteLine();
    }
}








// Напишите программу, которая заполнит спирально массив 4 на 4. Например, на выходе получается вот такой массив:

void PrintArray(int[,] print)
{
    for (int i = 0; i < print.GetLength(0); i++)
    {
        for (int j = 0; j < print.GetLength(1); j++)
        {
            Console.Write(print[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int row = 4;
int column = 4;
int[,] array = new int[row, column];
Console.WriteLine("Начальное значение будет задано случайным числом из заданного диапазона. ");
Console.Write("Введите минимальное значение диапазона генерации случайных чисел: ");
int minMeaning = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение диапазона генерации случайных чисел: ");
int maxMeaning = int.Parse(Console.ReadLine());

while (minMeaning > maxMeaning)
{
    Console.Write("Вы ввели минимальное значение диапазона генерации случайных чисел больше чем максимальное. ");
    Console.WriteLine("Сформировать такой диапазон генерации случайных чисел невозможно.");
    Console.Write("Введите минимальное значение диапазона генерации случайных чисел меньше чем максимальное: ");
    minMeaning = int.Parse(Console.ReadLine());
    Console.Write("Введите максимальное значение диапазона генерации случайных чисел: ");
    maxMeaning = int.Parse(Console.ReadLine());
}

int k = new Random().Next(minMeaning, maxMeaning);

for (int j = 0; j < array.GetLength(1); j++)
{
    array[0, j] = k;
    k++;
}

for (int i = 1; i < array.GetLength(0); i++)
{
    array[i, array.GetLength(1) - 1] = k;
    k++;
}

for (int j = 2; j >= 0; j--)
{
    array[array.GetLength(0) - 1, j] = k;
    k++;
}

for (int i = 2; i > 0; i--)
{
    array[i, 0] = k;
    k++;
}

for (int j = 1; j < array.GetLength(1) - 1; j++)
{
    array[array.GetLength(0) - 3, j] = k;
    k++;
}

for (int j = 2; j > 0; j--)
{
    array[array.GetLength(0) - 2, j] = k;
    k++;
}
Console.WriteLine("Массив 4 на 4 заполненый спирально:");
PrintArray(array);