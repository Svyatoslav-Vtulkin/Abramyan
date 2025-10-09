
//For: 1-20, 33, 36-40

// For 1 Даны целые числа K и N (N > 0). Вывести N раз число K.
// Console.Write("Введите число K: ");
// int k = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);
// for (int i = 0; i < n; i++)
// {
//     Console.WriteLine(k);
// }

// For 2  Даны два целых числа A и B (A < B).
// Вывести в порядке возрастания все целые числа,
// расположенные между A и B(включая сами числа A и B), а также количество N этих чисел.
// Console.Write("Введите число A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int b = int.Parse(Console.ReadLine()!);
// for (int i = a; i < b; i++)
// {
//     Console.WriteLine(i);
// }
// Console.WriteLine($"CountN: {b - a + 1}");

// For 3 Даны два целых числа A и B(A < B).
// Вывести в порядке убывания все целые числа,
// расположенные между A и B(не включая числа A и B), а также количество N этих чисел.
// Console.Write("Введите число A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int b = int.Parse(Console.ReadLine()!);
// for (int i = b; i >= a; i--)
// {
//     Console.WriteLine(i);
// }
// Console.WriteLine($"CountN: {b - a + 1}");

// For 4 Дано вещественное число — цена 1 кг конфет.
// Вывести стоимость 1, 2, . . . , 10 кг конфет.
// Console.Write("Введите цену: ");
// int cost = int.Parse(Console.ReadLine());
// for (int i = 1; i <= 10; i++)   
// {
//     Console.WriteLine($"Цена за {i} кг = {cost * i}");
// }

// For 5 Дано вещественное число — цена 1 кг конфет.
// Вывести стоимость 0.1, 0.2, . . . , 1 кг конфет.
// Console.Write("Введите число: ");
// int cost = int.Parse(Console.ReadLine()!);
// for (int i = 1; i <= 10; i ++)
// {
//     Console.WriteLine($"Цена за {i * 0.1} кг = {cost * i * 0.1}");
// }

// For 6 Дано вещественное число — цена 1 кг конфет.
// Вывести стоимость 1.2,1.4, . . . , 2 кг конфет
// Console.Write("Введите число: ");
// decimal cost = decimal.Parse(Console.ReadLine()!);
// for (decimal i = 1.2m; i < 2; i+= 0.2m)
// {
//     Console.WriteLine($"Цена за {i} кг = {cost * i}");
// }


// For 7 Даны два целых числа A и B (A < B).
// Найти сумму всех целых чисел от A до B включительно.
// Console.Write("Введите число A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int b = int.Parse(Console.ReadLine()!);
// int sum = 0;
// for (int i = a; i <= b; i++)
// {
//     sum += i;
// }
// Console.WriteLine(sum);

// For 8 Даны два целых числа A и B (A < B).
// Найти произведение всех целых чисел от A до B включительно.
// Console.Write("Введите число A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int b = int.Parse(Console.ReadLine()!);
// int product = 1;
// for (int i = a; i <= b; i++)
// {
//     product *= i;
// }
// Console.WriteLine(product);

// For 9 Даны два целых числа A и B (A < B).
// Найти сумму квадратов всех целых чисел от A до B включительно.
// Console.Write("Введите число A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int b = int.Parse(Console.ReadLine()!);
// int sumOfSquares = 0;
// for (int i = a; i <= b; i++)
// {
//     sumOfSquares += i * i;
// }
// Console.WriteLine(sumOfSquares);

// For 10 Дано целое число N (> 0).
// Найти сумму 1 + 1/2 + 1/3 + . . . + 1/N (вещественное число).
// Console.Write("Введите число N: ");
// decimal n = decimal.Parse(Console.ReadLine()!);
// decimal sum = 0;
// for (decimal i = 1m; i <= n; i++)
// {
//     sum += 1.0m / i;
//     Console.WriteLine(sum);
// }

// For 11 Дано целое число N (> 0).
// Найти сумму N^2 + (N + 1)^2 + (N + 2)^2 + . . . + (2·N)^2 (целое число).
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// int sum = 0;
// for (int i = 0; i < n; i++)
// {
//     sum += (n + i) * (n + i);
// }
// Console.WriteLine(sum);

// For 12 Дано целое число N (> 0).
// Найти произведение 1.1 * 1.2 * 1.3 * . . . (N сомножителей).
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// decimal product = 1.1m, j = 1.2m;
// for (int i = 1; i <= n; i++, j += 0.1m)
// {
//     product *= j;
//     Console.WriteLine(product);
// }

// For 13 Дано целое число N (> 0).
// Найти значение выражения 1.1 − 1.2 + 1.3 − . . . (N слагаемых, знаки чередуются).
// Условный оператор не использовать.
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// decimal product = 0;
// int counter = -1;
// for (int i = 0; i <= n; i++)
// {
//     counter = -1;
//     product += counter * (1 + 0.1m * i);
//     Console.WriteLine(product);
// }

// For 14 Дано целое число N (> 0). Найти квадрат данного числа, используя для его вычисления следующую формулу:
// N^2 = 1 + 3 + 5 + . . . + (2·N − 1).
// После добавления к сумме каждого слагаемого выводить текущее значение суммы
// (в результате будут выведены квадраты всех целых чисел от 1 до N).
// Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);
// int product = 0;
// for (int i = 1; i <= n; i++)
// {
//     product += 2 * i - 1; 
// }
// Console.WriteLine(product);

// For 15 Дано вещественное число A и целое число N (> 0).
// Найти A в степени N: A^N = A·A· . . . ·A(числа A перемножаются N раз).
// Console.Write("Введите число A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);
// decimal degree = 1;
// for (int i = 0; i < n; i++)
// {
//     degree *= a;
// }
// Console.WriteLine(degree);

// For 16 Дано вещественное число A и целое число N (> 0).
// Используя один цикл, вывести все целые степени числа A от 1 до N.
// Console.Write("Введите число A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);
// decimal degree = 1;
// for (int i = 0; i < n; i++)
// {
//     degree *= a;
//     Console.WriteLine(degree);
// }

// For 17 Дано вещественное число A и целое число N (> 0).
// Используя один цикл, найти сумму 1 + A + A^2 + A^3 + . . . + A^N
// Console.Write("Введите число A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);
// int result = 1;
// int sum = 0;
// for (int i = 0; i < n; i++)
// {
//     result *= a;
//     sum += result;
//     Console.WriteLine(sum);
// }

// For 18 Дано вещественное число A и целое число N (> 0).
// Используя один цикл, найти значение выражения 1 − A + A^2 − A^3 + . . . + (−1)^N ·A^N.
// Условный оператор не использовать.
// Console.Write("Введите число A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);
// int currentTerm = a;
// int sum = 0;
// for (int i = 0; i < n; i++)
// {
//     currentTerm *= a;
//     sum += currentTerm;
//     currentTerm *= -1;
//     Console.WriteLine(sum);
// }

// currentTerm - текущий член последовательности

// For 19 Дано целое число N (> 0). Найти произведение N! = 1·2·. . .·N
// (N–факториал). Чтобы избежать целочисленного переполнения,
// вычислять это произведение с помощью вещественной переменной и вывести его как вещественное число.
// Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);
// decimal factorial = 1;
// for (int i = 2; i <= n; i++)
// {
//     factorial *= i;
//     Console.WriteLine(factorial);
// }

// For 20 Дано целое число N (> 0).
// Используя один цикл, найти сумму 1! + 2! + 3! + . . . + N!
// (выражение N! — N–факториал — обозначает произведение всех целых чисел от 1 до N: N! = 1·2·. . .·N).
// Чтобы избежать целочисленного переполнения, проводить вычисления
// с помощью вещественных переменных и вывести результат как вещественное число.
// Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);
// decimal factorial = 1;
// decimal sum = 0;
// for (int i = 1; i <= n; i++)
// {
//     factorial *= i;
//     sum += factorial;
//     Console.WriteLine(sum);
// }

// For 33 Дано целое число N (> 1). Последовательность чисел Фибоначчи FK (целого типа) определяется следующим образом:
// F1 = 1, F2 = 1, FK = FK−2 + FK−1, K = 3, 4, . . . .
// Вывести элементы F1, F2, ..., FN .
// Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);
// int f1 = 0, f2 = 1, fk = 0;
// Console.Write(f1 + " ");
// for (int i = 1; i <= n; i++)
// {
//     fk = f1 + f2;
//     f1 = f2;
//     f2 = fk;
//     Console.Write(fk + " ");
// }
// // Console.Write(fk + " ");

// For 36 Даны целые положительные числа N и K.
// Найти сумму 1^K + 2^K + . . . + N^K.
// Чтобы избежать целочисленного переполнения, вычислять слагаемые
// этой суммы с помощью вещественной переменной и выводить результат как вещественное число.
// Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число K: ");
// int k = int.Parse(Console.ReadLine()!);
// int result = 0;
// for (int i = 1; i <= n; i++)
// {
//     int pow = 1;
//     for (int j = 0; j < k; j++)
//     {
//         pow *= i;
//     }
//     result += pow;
//     Console.Write(pow + " ");
// }

// For 37 Дано целое число N (> 0).
// Найти сумму 1^1 + 2^2 + . . . + N^N.
// Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);
// int sum = 0;
// for (int i = 1; i <= n; i++)
// {
//     int pow = 1;
//     for (int j = 1; j <= i; j++)
//     {
//         pow *= j;
//     }
//     sum += pow;
//     Console.Write(sum + " ");
// }

// For 38 Дано целое число N (> 0).
// Найти сумму 1^N + 2^N−1 + . . . + N^1.
// Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);
// int sum = 0;
// for (int i = 1; i <= n; i++)
// {
//     int pow = 1;
//     for (int j = 0; j <= n - i; j++)
//     {
//         pow *= i;
//     }
//     sum += pow;
//     Console.WriteLine(sum + " ");
// }

// For 39 Даны целые положительные числа A и B (A < B). Вывести все целые
// числа от A до B включительно; при этом каждое число должно выводиться
// столько раз, каково его значение (например, число 3 выводится 3 раза).
// Console.Write("Введите число A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int b = int.Parse(Console.ReadLine()!);
// for (int i = a; i <= b; i++)
// {
//     for (int j = 0; j < i; j++)
//     {
//         Console.Write(i + " ");
//     }
// }
//


// For 40 Даны целые числа A и B (A < B).
// Вывести все целые числа от A до B включительно;
// при этом число A должно выводиться 1 раз,
// число A + 1 должно выводиться 2 раза и т. д.
// Console.Write("Введите число A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int b = int.Parse(Console.ReadLine()!);
// for (int i = a; i <= b; i++)
// {
//     for (int j = 0; j <= i - a; j++)
//     {
//         Console.Write(i + " ");
//     }
// }