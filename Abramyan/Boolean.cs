// Bool: 1-23 25-28, 30, 34-37

// Boolean1 Дано целое число A. Проверить истинность высказывания: «Число A является положительным».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine()!);
// bool isPositive = a > 0;
// Console.WriteLine(isPositive);

// Boolean2 Дано целое число A. Проверить истинность высказывания: «Число A является нечетным».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine()!);
// bool isOdd = a % 2 != 0;
// Console.WriteLine(isOdd);

// Boolean3 Дано целое число A. Проверить истинность высказывания: «Число A является четным».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine()!);
// bool isEven = a % 2 == 0;
// Console.WriteLine(isEven);

// Boolean4 Даны два целых числа: A, B.
// Проверить истинность высказывания: «Справедливы неравенства A > 2 и B ≤ 3».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение B: ");
// int b = int.Parse(Console.ReadLine()!);
// bool isInequality = a > 2 && b <= 3;
// Console.WriteLine(isInequality);

// Boolean5 Даны два целых числа: A, B.
// Проверить истинность высказывания: «Справедливы неравенства A ≥ 0 или B < −2»
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение B: ");
// int b = int.Parse(Console.ReadLine());
// bool isInequality = a >= 0 || b <- 2;
// Console.WriteLine(isInequality);

// Boolean6 Даны три целых числа: A, B, C.
// Проверить истинность высказывания: «Справедливо двойное неравенство A < B < C».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение C: ");
// int c = int.Parse(Console.ReadLine()!);
// bool isDoubleInequality = a < b && b < c;
// Console.WriteLine(isDoubleInequality);

// Boolean7 Даны три целых числа: A, B, C.
// Проверить истинность высказывания: «Число B находится между числами A и C».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение C: ");
// int c = int.Parse(Console.ReadLine()!);
// bool isMiddleNumber = a < b && b < c || a > b && b > c;
// Console.WriteLine(isMiddleNumber);

// Boolean8 Даны два целых числа: A, B.
// Проверить истинность высказывания: «Каждое из чисел A и B нечетное».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение B: ");
// int b = int.Parse(Console.ReadLine());
// bool isOdd = a % 2 != 0 && b % 2 != 0;
// Console.WriteLine(isOdd);

// Boolean9 Даны два целых числа: A, B.
// Проверить истинность высказывания: «Хотя бы одно из чисел A и B нечетное»
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение B: ");
// int b = int.Parse(Console.ReadLine());
// bool isOdd = a % 2 != 0 || b % 2 != 0;
// Console.WriteLine(isOdd);

// Boolean10 Даны два целых числа: A, B.
// Проверить истинность высказывания: «Ровно одно из чисел A и B нечетное».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение B: ");
// int b = int.Parse(Console.ReadLine());
// bool isOdd = (a % 2 != 0 && b % 2 == 0) || (a % 2 == 0 && b % 2 != 0);
// Console.WriteLine(isOdd);

// Boolean11 Даны два целых числа: A, B. Проверить истинность высказывания: «Числа A и B имеют одинаковую четность».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение B: ");
// int b = int.Parse(Console.ReadLine());
// bool isSameParity = (a % 2 == 0 && b % 2 == 0) || (a % 2 != 0 && b % 2 != 0);
// Console.WriteLine(isSameParity);

// Boolean12 Даны три целых числа: A, B, C. Проверить истинность высказывания: «Каждое из чисел A, B, C положительное».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение B: ");
// int b = int.Parse(Console.ReadLine());
// Console.Write("Введите значение C: ");
// int c = int.Parse(Console.ReadLine());
// bool isEveryPositive = a > 0 && b > 0 && c > 0;
// Console.WriteLine(isEveryPositive);

// Boolean13 Даны три целых числа: A, B, C.
// Проверить истинность высказывания: «Хотя бы одно из чисел A, B, C положительное».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение B: ");
// int b = int.Parse(Console.ReadLine());
// Console.Write("Введите значение C: ");
// int c = int.Parse(Console.ReadLine());
// bool isPositive = a > 0 || b > 0 || c > 0;
// Console.WriteLine(isPositive);

// Boolean14 Даны три целых числа: A, B, C.
// Проверить истинность высказывания: «Ровно одно из чисел A, B, C положительное».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение B: ");
// int b = int.Parse(Console.ReadLine());
// Console.Write("Введите значение C: ");
// int c = int.Parse(Console.ReadLine());
// bool isPositive = (a > 0 && b <= 0 && c <= 0) || (a <= 0 && b > 0 && c <= 0) || (a <= 0 && b <= 0 && c > 0);
// Console.WriteLine(isPositive);

// Boolean15 Даны три целых числа: A, B, C.
// Проверить истинность высказывания: «Ровно два из чисел A, B, C являются положительными».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение B: ");
// int b = int.Parse(Console.ReadLine());
// Console.Write("Введите значение C: ");
// int c = int.Parse(Console.ReadLine());
// bool isDoublePositive = (a > 0 && b > 0 && c <= 0) || (a > 0 && b <= 0 && c > 0) || (a <= 0 && b > 0 && c > 0);
// Console.WriteLine(isDoublePositive);

// Boolean16 Дано целое положительное число.
// Проверить истинность высказывания: «Данное число является четным двузначным».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine()!);
// bool isDoubleDigit = a % 2 == 0 && a > 9 && a < 100;
// Console.WriteLine(isDoubleDigit);

// Boolean17 Дано целое положительное число.
// Проверить истинность высказывания: «Данное число является нечетным трехзначным».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine()!);
// bool isOddThreeDigit = a % 2 != 0 && a > 99 && a < 1000;
// Console.WriteLine(isOddThreeDigit);

// Boolean18 Проверить истинность высказывания: «Среди трех данных целых чисел есть хотя бы одна пара совпадающих».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение B: ");
// int b = int.Parse(Console.ReadLine());
// Console.Write("Введите значение C: ");
// int c = int.Parse(Console.ReadLine());
// bool isPairMatch = a == b || a == c || b == c;
// Console.WriteLine(isPairMatch);

// Boolean19 Проверить истинность высказывания: «Среди трех данных целых чисел
// есть хотя бы одна пара взаимно противоположных».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение B: ");
// int b = int.Parse(Console.ReadLine());
// Console.Write("Введите значение C: ");
// int c = int.Parse(Console.ReadLine());
// bool isOpposite = a == -b || a == -c || b == -c;
// Console.WriteLine(isOpposite);

// Boolean20 Дано трехзначное число. Проверить истинность высказывания: «Все цифры данного числа различны».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine()!);
// bool isDifferent = a % 10 != a / 10 % 10 && a / 10 % 10 != a / 100 && a % 10 != a / 100;
// Console.WriteLine(isDifferent);

// Boolean21 Дано трехзначное число.
// Проверить истинность высказывания:«Цифры данного числа образуют возрастающую последовательность».
// Console.Write("Введите значение А: ");
// int a = int.Parse(Console.ReadLine()!);
// int a1 = a / 100;
// int a2 = a / 10 % 10;
// int a3 = a % 10;
// bool isIncreasingSequence = a1 < a2 && a1 < a3 && a2 < a3 ;
// Console.WriteLine(isIncreasingSequence);

// Boolean22 Дано трехзначное число.
// Проверить истинность высказывания: «Цифры данного числа образуют возрастающую или убывающую последовательность».
// Console.Write("Введите значение А: ");
// int a = int.Parse(Console.ReadLine()!);
// int a1 = a / 100;
// int a2 = a / 10 % 10;
// int a3 = a % 10;
// bool isSequence = (a1 < a2 && a1 < a3 && a2 < a3) || (a1 > a2 && a1 > a3 && a2 > a3);
// Console.WriteLine(isSequence);

// Boolean23 Дано четырехзначное число.
// Проверить истинность высказывания: «Данное число читается одинаково слева направо и справа налево».
// Console.Write("Введите значение А: ");
// int a = int.Parse(Console.ReadLine()!);
// int a1 = a / 1000;
// int a2 = a % 1000 / 100;
// int a3 = a / 10 % 10;
// int a4 = a % 10;
// bool isSequence = a1 == a4 && a2 == a3;
// Console.WriteLine(isSequence);

// Boolean25 Даны числа x, y.
// Проверить истинность высказывания: «Точка с координатами (x, y) лежит во второй координатной четверти».
// Console.Write("Введите значение X: ");
// int x = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение Y: ");
// int y = int.Parse(Console.ReadLine()!);
// bool isInSecondQuarter = x < 0 && y > 0;
// Console.WriteLine(isInSecondQuarter);

// Boolean26 Даны числа x, y.
// Проверить истинность высказывания: «Точка с координатами (x, y) лежит в четвертой координатной четверти»
// Console.Write("Введите значение X: ");
// int x = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение Y: ");
// int y = int.Parse(Console.ReadLine()!);
// bool isInFourQuarter = x > 0 && y < 0;
// Console.WriteLine(isInFourQuarter);

// Boolean27 Даны числа x, y.
// Проверить истинность высказывания: «Точка с координатами (x, y) лежит во второй или третьей координатной четверти».
// Console.Write("Введите значение X: ");
// int x = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение Y: ");
// int y = int.Parse(Console.ReadLine()!);
// bool isInQuarter = (x < 0 && y > 0) || (x < 0 && y < 0);
// Console.WriteLine(isInQuarter);

// Boolean28 Даны числа x, y.
// Проверить истинность высказывания: «Точка с координатами (x, y) лежит в первой или третьей координатной четверти».
// Console.Write("Введите значение X: ");
// int x = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение Y: ");
// int y = int.Parse(Console.ReadLine()!);
// bool isInQuarter = (x > 0 && y > 0) || (x < 0 && y < 0);
// Console.WriteLine(isInQuarter);

// Boolean30 Даны целые числа a, b, c, являющиеся сторонами некоторого треугольника.
// Проверить истинность высказывания: «Треугольник со сторонами a, b, c является равносторонним».
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение C: ");
// int c = int.Parse(Console.ReadLine()!);
// bool isEquilateralTriangle = a == b && b == c;
// Console.WriteLine(isEquilateralTriangle);

// Boolean34 Даны координаты поля шахматной доски x, y (целые числа, лежащие в диапазоне 1–8).
// Учитывая, что левое нижнее поле доски (1, 1)
// является черным, проверить истинность высказывания: «Данное поле является белым»
// Console.Write("Введите значение X: ");
// int x = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение Y: ");
// int y = int.Parse(Console.ReadLine()!);
// bool isFieldWhite = (x + y) % 2 != 0;
// Console.WriteLine(isFieldWhite);

// Boolean35 Даны координаты двух различных полей шахматной доски x1,y1, x2, y2
// (целые числа, лежащие в диапазоне 1–8). Проверить истинность высказывания: «Данные поля имеют одинаковый цвет».
// Console.Write("Введите значение X1: ");
// int x1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение Y1: ");
// int y1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение X2: ");
// int x2 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение Y2: ");
// int y2 = int.Parse(Console.ReadLine()!);
// bool haveSaveColor = (x1 + y1) % 2 == (x2 + y2) % 2;
// Console.WriteLine(haveSaveColor);

// Boolean36 Даны координаты двух различных полей шахматной доски x1, y1,x2, y2
// (целые числа, лежащие в диапазоне 1–8). Проверить истинность высказывания:
// «Ладья за один ход может перейти с одного поля на другое».
// Console.Write("Введите значение X1: ");
// int x1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение Y1: ");
// int y1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение X2: ");
// int x2 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение Y2: ");
// int y2 = int.Parse(Console.ReadLine()!);
// bool canRookMove = x1 == x2 || y1 == y2;
// Console.WriteLine(canRookMove);

// Boolean37 Даны координаты двух различных полей шахматной доски x1,y1, x2, y2
// (целые числа, лежащие в диапазоне 1–8). Проверить истинность высказывания:
// «Король за один ход может перейти с одного поля на другое».
// Console.Write("Введите значение X1: ");
// int x1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение Y1: ");
// int y1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение X2: ");
// int x2 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение Y2: ");
// int y2 = int.Parse(Console.ReadLine()!);
// bool canKingMove = Math.Abs(x1 - x2) < 2 && Math.Abs(y1 - y2) < 2;
// Console.WriteLine(canKingMove);