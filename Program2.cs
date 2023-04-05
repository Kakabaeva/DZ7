// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.WriteLine("введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] numbers = new int[rows, columns];
// FillArrayIntNumbers(numbers);
// PrintArray(numbers);
// Average(numbers);


// void FillArrayIntNumbers(int[,] array)
// {

//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array[i, j] = new Random().Next(0, 11);
//             }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void Average(int[,] array)
// {
//     Console.WriteLine("Среднее арифметическое каждого столбца: ");


//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double sum = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             sum = sum + array[i, j];
//         }
//         Console.Write($"{sum / (rows):F2} ; ");
//     }
// }