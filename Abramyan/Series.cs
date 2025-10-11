// Series: 1-4, 8, 10-16, 19-22, 29-36

// Series 1 Даны десять вещественных чисел. Найти их сумму.
// int sum = 0;
// for (int i = 0; i < 10; i++)
// {
//     Console.Write("Введите число: ");
//     sum += int.Parse(Console.ReadLine()!);
// }
// Console.WriteLine($"Сумма: {sum}");

// Series 2 Даны десять вещественных чисел. Найти их произведение.
// int product = 1;
// for (int i = 0; i < 10; i++)
// {
//     Console.Write("Введите число: ");
//     product *= int.Parse(Console.ReadLine()!);
// }
// Console.WriteLine($"Произведение: {product}");

// Series 3 Даны десять вещественных чисел. Найти их среднее арифметическое.
// int average = 1;
// for (int i = 0; i < 10; i++)
// {
//     Console.Write("Введите число: ");
//     average += int.Parse(Console.ReadLine()!);
// }
// Console.WriteLine($"Cреднее арифметическое: {average / 10}");

// Series 4 Дано целое число N и набор из N вещественных чисел.
// Вывести сумму и произведение чисел из данного набора.
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine()!);
// int number = 0,sum = 0, product = 1;
// for (int i = 0; i < n; i++)
// {
//     Console.Write("Введите число: ");
//     number = int.Parse(Console.ReadLine()!);
//     sum += number;
//     product *= number;
// }
// Console.WriteLine($"Сумма: {sum}, Произведение: {product}");

// Series 8 Дано целое число N и набор из N целых чисел. Вывести в том же
// порядке все четные числа из данного набора и количество K таких чисел.
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine()!);
// int count = 0;
// for (int i = 1; i <= n; i++)
// {
//     int number = int.Parse(Console.ReadLine()!);
//     if (number % 2 == 0)
//     {
//         Console.WriteLine($"Четное число: {number}");
//         count++;
//     }
// }
// Console.WriteLine($"Количество: {count}");

// Series 10 Дано целое число N и набор из N целых чисел. Если в наборе
// имеются положительные числа, то вывести TRUE; в противном случае вывести FALSE.
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine()!);
// bool hasPositive = false;
// for (int i = 1; i <= n; i++)
// {
//     int number = int.Parse(Console.ReadLine()!);
//     if (number > 0)
//     {
//         hasPositive = true;
//     }
// }
// Console.WriteLine(hasPositive);

// Series 11 Даны целые числа K, N и набор из N целых чисел. Если в наборе
// имеются числа, меньшие K, то вывести TRUE; в противном случае вывести FALSE.
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите K: ");
// int k = int.Parse(Console.ReadLine()!);
// bool numbersLessThanK = false;
// for (int i = 1; i <= n; i++)
// {
//     int number = int.Parse(Console.ReadLine()!);
//     if (number < k)
//     {
//         numbersLessThanK = true;
//     }
// }
// Console.WriteLine(numbersLessThanK);

// Series 12 Дан набор ненулевых целых чисел; признак его завершения — число 0.
// Вывести количество чисел в наборе.
// int n = -1, count = 0;
// while (n != 0)
// {
//     Console.Write("Введите число: ");
//     n = int.Parse(Console.ReadLine()!);
//     count++;
// }
// Console.WriteLine(count);

// Series 13 Дан набор ненулевых целых чисел; признак его завершения — число 0.
// Вывести сумму всех положительных четных чисел из данного набора.
// Если требуемые числа в наборе отсутствуют, то вывести 0.
// int n = -1, sum = 0;
// while (n != 0)
// {
//     Console.Write("Введите число: ");
//     n = int.Parse(Console.ReadLine()!);
//     if (n > 0 && n % 2 == 0)
//     {
//         sum += n;
//     }
// }
// Console.Write($"Сумма: {sum}");

// Series 14 Дано целое число K и набор ненулевых целых чисел; признак его
// завершения — число 0. Вывести количество чисел в наборе, меньших K.
// Console.Write("Введите число K: ");
// int k = int.Parse(Console.ReadLine()!);
// int count = 0, number = 1;
// while (number != 0)
// {
//     Console.Write("Введите число: ");
//     number = int.Parse(Console.ReadLine()!);
//     if (number < k)
//         count++;
// }
// Console.WriteLine(count);

// Series 15 Дано целое число K и набор ненулевых целых чисел; признак его
// завершения — число 0. Вывести номер первого числа в наборе, большего K.
// Если таких чисел нет, то вывести 0.



// Series 16 Дано целое число K и набор ненулевых целых чисел; признак его
// завершения — число 0. Вывести номер последнего числа в наборе, большего K.
// Если таких чисел нет, то вывести 0.