// IF: 1-20, 22, 29-30

// If 1 Дано целое число. Если оно является положительным,то прибавить к нему 1;
// в противном случае не изменять его. Вывести полученное число.
// Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);
// if (n > 0) 
//     n++;
//
// Console.WriteLine(n);

// If 2 Дано целое число. Если оно является положительным, то прибавить кнему 1;
// в противном случае вычесть из него 2. Вывести полученное число.
// Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);
// if (n > 0)
//     n++;
// else
//     n -= 2;
//
// Console.WriteLine(n);

// If 3 Дано целое число. Если оно является положительным, то прибавить к нему 1;
// если отрицательным, то вычесть из него 2;
// если нулевым, то заменить его на 10. Вывести полученное число.
// Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);
// if (n > 0)
//     n++;
// else if (n < 0)
//     n -= 2;
// else
//     n = 10;
//
// Console.WriteLine(n);

// If 4 Даны три целых числа. Найти количество положительных чисел в исходном наборе.
// Console.Write("Введите число A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число C: ");
// int c = int.Parse(Console.ReadLine()!);
// int positivesCount = 0;
// if (a > 0)
//     positivesCount++;
// if (b > 0)
//     positivesCount++;
// if (c > 0)
//     positivesCount++;
//
// Console.WriteLine(positivesCount);

// If 5 Даны три целых числа. Найти количество положительных и количество отрицательных чисел в исходном наборе.
// Console.Write("Введите число A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число C: ");
// int c = int.Parse(Console.ReadLine()!);
// int positivesCount = 0;
// int negativesCount = 0;
// if (a > 0)
//     positivesCount++;
// else if (a < 0)
//     negativesCount++;
// if (b > 0)
//     positivesCount++;
// else if (b < 0)
//     negativesCount++;
// if (c > 0)
//     positivesCount++;
// else if (c < 0)
//     negativesCount++;
//
// Console.WriteLine($"Positive Count: {positivesCount}");
// Console.WriteLine($"Negative Count: {negativesCount}");

// If 6 Даны два числа. Вывести большее из них.
// Console.Write("Введите число A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int b = int.Parse(Console.ReadLine()!);
// if (a > b)
//     Console.WriteLine(a);
// else
//     Console.WriteLine(b);

// If 7 Даны два числа. Вывести порядковый номер меньшего из них.
// Console.Write("Введите число A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int b = int.Parse(Console.ReadLine()!);
// if (a > b)
//     Console.WriteLine(1);
// else if (b > a)
//     Console.WriteLine(2);
// else
//     Console.WriteLine("The numbers are the same");

// If 8 Даны два числа. Вывести вначале большее, а затем меньшее из них
// Console.Write("Введите число A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int b = int.Parse(Console.ReadLine()!);
// if (a > b)
// {
//     Console.Write(a);
//     Console.Write(b);
// }
// else if (b > a)
// {
//     Console.WriteLine(b);
//     Console.WriteLine(a);
// }
// else
//     Console.WriteLine("The numbers are the same");

// If 9 Даны две переменные вещественного типа: A, B.
// Перераспределить значения данных переменных так, чтобы в A оказалось меньшее из значений,а в B — большее.
// Вывести новые значения переменных A и B.
// Console.Write("Введите число A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int b = int.Parse(Console.ReadLine()!);
// if (a > b)
// {
//     int c = 0;
//     c = a;
//     a = b;
//     b = c;
// }
// Console.WriteLine($"New values A:{a} B:{b}");

// If 10. Даны две переменные целого типа: A и B.
// Если их значения не равны, то присвоить каждой переменной сумму этих значений, а если равны,
// то присвоить переменным нулевые значения. Вывести новые значения переменных A и B.
// Console.Write("Введите число A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int b = int.Parse(Console.ReadLine()!);
// if (a != b)
// {
//     a += b;
//     b = a;
// }
// else if (a == b)
// {
//     a = 0;
//     b = 0;
// }
// Console.WriteLine($"New values A:{a} B:{b}");

// If 11 Даны две переменные целого типа: A и B.
// Если их значения не равны, то присвоить каждой переменной большее из этих значений, а если равны,
// то присвоить переменным нулевые значения. Вывести новые значения переменных A и B.
// Console.Write("Введите число A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int b = int.Parse(Console.ReadLine()!);
// if (a > b)
//     b = a;
// else if (b > a)
//     a = b;
// else if (a == b)
// {
//     a = 0;
//     b = 0;
// }
// Console.WriteLine($"New values A:{a} B:{b}");

// If 12 Даны три числа. Найти наименьшее из них.
// Console.Write("Введите число A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число C: ");
// int c = int.Parse(Console.ReadLine()!);
// if (c < a && c < b)
//     Console.WriteLine(c);
// else if (b < a && b < c)
//     Console.WriteLine(b);
// else if (a < b && a < c)
//     Console.WriteLine(a);

// If 13 Даны три числа. Найти среднее из них (то есть число, расположенное между наименьшим и наибольшим).
// Console.Write("Введите число A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число C: ");
// int c = int.Parse(Console.ReadLine()!);