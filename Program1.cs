// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// // 17 -> такого числа в массиве нет

// Console.WriteLine("введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] numbers = new int[rows, columns];
// Console.WriteLine("Введите целое число для поиска в массиве");
// int findNumber = Convert.ToInt32(Console.ReadLine());


// FillArrayIntNumbers(numbers);
// PrintArray(numbers);
// FindPositionPositive(numbers);
// Console.Write(FindPositionNegative(numbers));



// void FillArrayIntNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 11);
//         }
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


// void FindPositionPositive(int[,] array)
// {



//     for (int i = 0; i < array.GetLength(0); i++)

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] == findNumber)
//                 Console.WriteLine($"  Искомый элемент находится в {i + 1} строке  {j + 1} столбца ");

//         }


// }

// string FindPositionNegative(int[,] array)
// {
// string result="Искомого элемента нет в массиве";
// for (int i = 0; i < array.GetLength(0); i++)

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] == findNumber)
//                 result="";

//         }
// return result;
// }