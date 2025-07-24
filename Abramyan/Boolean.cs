// Bool: 1-23 25-28, 30, 34-37

// Boolean1 Дано целое число A. Проверить истинность высказывания: «Число A является положительным».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine()!);
// bool b = a > 0;
// Console.WriteLine(b);

// Boolean2 Дано целое число A. Проверить истинность высказывания: «Число A является нечетным».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine()!);
// bool b = a % 2 != 0;
// Console.WriteLine(b);

// Boolean3 Дано целое число A. Проверить истинность высказывания: «Число A является четным».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine()!);
// bool b = a % 2 == 0;
// Console.WriteLine(b);

// Boolean4 Даны два целых числа: A, B.
// Проверить истинность высказывания: «Справедливы неравенства A > 2 и B ≤ 3».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение B: ");
// int b = int.Parse(Console.ReadLine()!);
// bool result = a > 2 && b <= 3;
// Console.WriteLine(result);

// Boolean5 Даны два целых числа: A, B.
// Проверить истинность высказывания: «Справедливы неравенства A ≥ 0 или B < −2»
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение B: ");
// int b = int.Parse(Console.ReadLine());
// bool result = a >= 0 || b <- 2;
// Console.WriteLine(result);

// Boolean6 Даны три целых числа: A, B, C.
// Проверить истинность высказывания: «Справедливо двойное неравенство A < B < C».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение B: ");
// int b = int.Parse(Console.ReadLine());
// Console.Write("Введите значение C: ");
// int c = int.Parse(Console.ReadLine());
// bool result = a < b && b < c;
// Console.WriteLine(result);

// Boolean7 Даны три целых числа: A, B, C.
// Проверить истинность высказывания: «Число B находится между числами A и C».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение B: ");
// int b = int.Parse(Console.ReadLine());
// Console.Write("Введите значение C: ");
// int c = int.Parse(Console.ReadLine());
// bool result = a < b && b < c || a > b && b > c;
// Console.WriteLine(result);

// Boolean8 Даны два целых числа: A, B.
// Проверить истинность высказывания: «Каждое из чисел A и B нечетное».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение B: ");
// int b = int.Parse(Console.ReadLine());
// bool result = a % 2 != 0 && b % 2 != 0;
// Console.WriteLine(result);

// Boolean9 Даны два целых числа: A, B.
// Проверить истинность высказывания: «Хотя бы одно из чисел A и B нечетное»
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение B: ");
// int b = int.Parse(Console.ReadLine());
// bool result = a % 2 != 0 || b % 2 != 0;
// Console.WriteLine(result);

// Boolean10 Даны два целых числа: A, B.
// Проверить истинность высказывания: «Ровно одно из чисел A и B нечетное».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение B: ");
// int b = int.Parse(Console.ReadLine());
// bool result = (a % 2 != 0 && b % 2 == 0) || (a % 2 == 0 && b % 2 != 0);
// Console.WriteLine(result);

// Boolean11 Даны два целых числа: A, B. Проверить истинность высказывания: «Числа A и B имеют одинаковую четность».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение B: ");
// int b = int.Parse(Console.ReadLine());
// bool result = (a % 2 == 0 && b % 2 == 0) || (a % 2 != 0 && b % 2 != 0);
// Console.WriteLine(result);

// Boolean12 Даны три целых числа: A, B, C. Проверить истинность высказывания: «Каждое из чисел A, B, C положительное».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение B: ");
// int b = int.Parse(Console.ReadLine());
// Console.Write("Введите значение C: ");
// int c = int.Parse(Console.ReadLine());
// bool result = a > 0 && b > 0 && c > 0;
// Console.WriteLine(result);

// Boolean13 Даны три целых числа: A, B, C.
// Проверить истинность высказывания: «Хотя бы одно из чисел A, B, C положительное».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение B: ");
// int b = int.Parse(Console.ReadLine());
// Console.Write("Введите значение C: ");
// int c = int.Parse(Console.ReadLine());
// bool result = a > 0 || b > 0 || c > 0;
// Console.WriteLine(result);

// Boolean14 Даны три целых числа: A, B, C.
// Проверить истинность высказывания: «Ровно одно из чисел A, B, C положительное».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение B: ");
// int b = int.Parse(Console.ReadLine());
// Console.Write("Введите значение C: ");
// int c = int.Parse(Console.ReadLine());
// bool result = (a > 0 && b <= 0 && c <= 0) || (a <= 0 && b > 0 && c <= 0) || (a <= 0 && b <= 0 && c > 0);
// Console.WriteLine(result);

// Boolean15 Даны три целых числа: A, B, C.
// Проверить истинность высказывания: «Ровно два из чисел A, B, C являются положительными».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение B: ");
// int b = int.Parse(Console.ReadLine());
// Console.Write("Введите значение C: ");
// int c = int.Parse(Console.ReadLine());
// bool result = (a > 0 && b > 0 && c <= 0) || (a > 0 && b <= 0 && c > 0) || (a <= 0 && b > 0 && c > 0);
// Console.WriteLine(result);

// Boolean16 Дано целое положительное число.
// Проверить истинность высказывания: «Данное число является четным двузначным».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine());
// bool result = a % 2 == 0 && a > 9 && a < 100;
// Console.WriteLine(result);

// Boolean17 Дано целое положительное число.
// Проверить истинность высказывания: «Данное число является нечетным трехзначным».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine());
// bool result = a % 2 != 0 && a > 99 && a < 1000;
// Console.WriteLine(result);

// Boolean18 Проверить истинность высказывания: «Среди трех данных целых чисел есть хотя бы одна пара совпадающих».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение B: ");
// int b = int.Parse(Console.ReadLine());
// Console.Write("Введите значение C: ");
// int c = int.Parse(Console.ReadLine());
// bool result = a == b || a == c || b == c;
// Console.WriteLine(result);

// Boolean19 Проверить истинность высказывания: «Среди трех данных целых чисел
// есть хотя бы одна пара взаимно противоположных».
Console.Write("Введите значение A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите значение B: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите значение C: ");
int c = int.Parse(Console.ReadLine());
bool result = a == b || a == c || b == c;
Console.WriteLine(result);

