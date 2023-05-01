// Урок 7. Двумерные массивы
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int Promt (string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine()!;
    int result = int.Parse (ReadInput);
    return result;
}

//Создание массива 
int [,] GenerateArray(int row1, int colmn1, int maxValue, int minValue)
{
    int [,] array = new int[row1, colmn1];
    Random random = new Random();
    for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < colmn1; j++)
        {
            array[i, j] = random.Next(minValue, maxValue);
        }
    }
    return array;
}

// Метод вывода массива
void PrintArray(int[,] array)
{
    int length_0 = array.GetLength(0);
    int length_1 = array.GetLength(1);
        for (int i = 0; i < length_0; i++)
    {
        for (int j = 0; j < length_1; j++)
        { Console.Write($"{array[i, j]}  "); };
        Console.WriteLine();
    }

    
}

// метод поиска среднего арифметического каждого столбца

void Arithmetic_mean(int[,] array)
{
    int length_0 = array.GetLength(0);
    int length_1 = array.GetLength(1);
    
    for (int i = 0; i < length_1; i++)
    {
        double tmp = 0;
        for (int j = 0; j < length_0; j++)
            tmp = tmp + array[j, i];
        Console.WriteLine($"Среднее арифметическое столбца {i+1}-го столбца равно {Math.Round(tmp/length_0, 2)}"); 
    }
}


Lable1:
int row = Promt("Введите количество строк  :");
int colmn = Promt("Введите количество столбцов  :");
int max = Promt("Введите максимальное значение для массива  :");
int min = Promt("Введите минимальное значение для массива  :");
if (min > max) { Console.WriteLine("Минимум не должен быть больше максимума"); goto Lable1; }
else { Console.WriteLine("Данные введены корректно"); }
int [,] array = GenerateArray(row, colmn, max, min);
PrintArray(array);
Arithmetic_mean(array);
