// While 4, 5, 17, 18, 20, 21, 24-27

// While 4 Дано целое число N (> 0). Если оно является степенью числа 3, то
// вывести TRUE, если не является — вывести FALSE.
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n >= 3 && n % 3 == 0) 
//     n /= 3;
// Console.WriteLine(n == 1);

// While 5 Дано целое число N (> 0), являющееся некоторой степенью числа 2:
// N = 2K. Найти целое число K — показатель этой степени.
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine()!);
// int k = 0;
// while (n > 1)
// {
//     n /= 2;
//     k++;
// }
// Console.WriteLine(k);

// While 17 Дано целое число N (> 0). Используя операции деления нацело и
// взятия остатка от деления, вывести все его цифры, начиная с самой правой (разряда единиц).
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n > 0)
// {
//     Console.WriteLine(n % 10);
//     n /= 10;
// }

// While 18 Дано целое число N (> 0). Используя операции деления нацело и
// взятия остатка от деления, найти количество и сумму его цифр.
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine()!);
// int count = 0;
// int sum = 0;
// while (n > 0)
// {
//     sum += n % 10;
//     count++;
//     n /= 10;
// }
// Console.WriteLine($"Количесто цифр: {count}, Сумма цифр: {sum}");

// While 20 Дано целое число N (> 0). С помощью операций деления нацело
// и взятия остатка от деления определить, имеется ли в записи числа N
// цифра «2». Если имеется, то вывести TRUE, если нет — вывести FALSE.
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine()!);
// bool hasTwo = false;
// while (n > 0)
// {
//     if (n % 10 == 2)
//     {
//         hasTwo = true;
//     }
//
//     n /= 10;
// }
// Console.WriteLine(hasTwo);

// While 21 Дано целое число N (> 0). С помощью операций деления нацело
// и взятия остатка от деления определить, имеются ли в записи числа N
// нечетные цифры. Если имеются, то вывести TRUE, если нет — вывести FALSE.
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine()!);
// bool oddNumbers = false;
// while (n > 0)
// {
//     if ((n % 10) % 2 != 0)
//     {
//         oddNumbers = true;
//     }
//
//     n /= 10;
// }
// Console.WriteLine(oddNumbers);

// While 24 Дано целое число N (> 1). Последовательность чисел Фибоначчи FK определяется следующим образом:
// F1 = 1, F2 = 1, FK = FK−2 + FK−1, K = 3, 4, . . . . Проверить, является ли число N числом Фибоначчи.
// Если является, то вывести TRUE, если нет — вывести FALSE.
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine()!);
// int f1 = 1, f2 = 1, fk = 1;
// while (fk < n) 
// {
//     fk = f1 + f2;
//     f1 = f2;
//     f2 = fk;
// }
// Console.WriteLine(fk == n);

// While 25 Дано целое число N (> 1). Найти первое число Фибоначчи, большее N.
// (определение чисел Фибоначчи дано в задании While24).
// F1 = 1, F2 = 1, FK = FK−2 + FK−1, K = 3, 4, . . . .
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine()!);
// int f1 = 1, f2 = 1, fk = 1;
// while (fk < n)
// {
//     fk = f1 + f2;
//     f1 = f2;
//     f2 = fk;
// }
// Console.WriteLine(fk);

// While 26 Дано целое число N (> 1), являющееся числом Фибоначчи: N = FK
// (определение чисел Фибоначчи дано в задании While24). Найти целые
// числа FK−1 и FK+1 — предыдущее и последующее числа Фибоначчи.
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine()!);
// int f1 = 1, f2 = 1, fk = 1;
// while (fk < n)
// {
//     fk = f1 + f2;
//     f1 = f2;
//     f2 = fk;
// }
// Console.WriteLine($"Предыдущее: {f1}, Последующее: {f1 + f2}");

// While 27 Дано целое число N (> 1), являющееся числом Фибоначчи: N = FK
// (определение чисел Фибоначчи дано в задании While24). Найти целое
// число K — порядковый номер числа Фибоначчи N.
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine()!);
// int f1 = 1, f2 = 1, fk = 1, countK = 0;
// while (fk < n)
// {
//     fk = f1 + f2;
//     f1 = f2;
//     f2 = fk;
//     countK++;
// }
// Console.WriteLine(countK);