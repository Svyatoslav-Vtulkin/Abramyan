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

// If 10 Даны две переменные целого типа: A и B.
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
// if (a > b && a < c || a < b && a > c)
//     Console.WriteLine(a);
// else if (b > a && b < c || b < a && b > c)
//     Console.WriteLine(b);
// else if (c > a && c < b || c < a && c > b)
//     Console.WriteLine(c);

// If 14 Даны три числа. Вывести вначале наименьшее, а затем наибольшее из данных чисел.
// Console.Write("Введите число A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число C: ");
// int c = int.Parse(Console.ReadLine()!);
// if (a < b && a < c)
//     Console.WriteLine(a);
// else if (b < a && b < c)
//     Console.WriteLine(b);
// else if (c < a && c < b)
//     Console.WriteLine(c);
// if (a > b && b > c)
//     Console.WriteLine(a);
// else if (b > a && b > c)
//     Console.WriteLine(b);
// else if (c > a && c > b)
//     Console.WriteLine(c);

// If 15 Даны три числа. Найти сумму двух наибольших из них.
// Console.Write("Введите число A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число C: ");
// int c = int.Parse(Console.ReadLine()!);
// if (a < b && a < c)
//     Console.WriteLine(b + c);
// else if (b < a && b < c)
//     Console.WriteLine(a + c);
// else if (c < a && c < b)
//     Console.WriteLine(a + b);

// If 16 Даны три переменные вещественного типа: A, B, C.
// Если их значения упорядочены по возрастанию, то удвоить их;
// в противном случае заменить значение каждой переменной на противоположное.
// Вывести новые значения переменных A, B, C.
// Console.Write("Введите число A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число C: ");
// int c = int.Parse(Console.ReadLine()!);
// if (a < b && b < c)
// {
//     a *= 2;
//     b *= 2;
//     c *= 2;
// }
// else
// {
//     a = -a;
//     b = -b;
//     c = -c;
//     
// }
// Console.WriteLine($"New values A:{a} B:{b} C:{c}");

// If 17 Даны три переменные вещественного типа: A, B, C.
// Если их значения упорядочены по возрастанию или убыванию, то удвоить их;
// в противном случае заменить значение каждой переменной на противоположное.
// Вывести новые значения переменных A, B, C.
// Console.Write("Введите число A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число C: ");
// int c = int.Parse(Console.ReadLine()!);
// if (a < b && b < c || a > b && b > c)
// {
//     a *= 2;
//     b *= 2;
//     c *= 2;
// }
// else
// {
//     a = -a;
//     b = -b;
//     c = -c;
// }
// Console.WriteLine($"New values A:{a} B:{b} C:{c}");

// If 18 Даны три целых числа, одно из которых отлично от двух других, равных между собой.
// Определить порядковый номер числа, отличного от остальных.
// Console.Write("Введите число A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число C: ");
// int c = int.Parse(Console.ReadLine()!);
// if (b == c && b != a)
//     Console.WriteLine(1);
// else if (a == c && a != b)
//     Console.WriteLine(2);
// else if (a == b && a != c)
//     Console.WriteLine(3);
    
// If 19 Даны четыре целых числа, одно из которых отлично от трех других,равных между собой.
// Определить порядковый номер числа, отличного от остальных.
// Console.Write("Введите число A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число C: ");
// int c = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число D: ");
// int d = int.Parse(Console.ReadLine()!);
// if (b == c && c == d && a != b)
//     Console.WriteLine(1);
// else if (a == c && c == d && b != a)
//     Console.WriteLine(2);
// else if (a == b && b == d && a != c)
//     Console.WriteLine(3);
// else if (a == b && b == c && a != d)
//     Console.WriteLine(4);

// If 20 На числовой оси расположены три точки: A, B, C.
// Определить, какая из двух последних точек (B или C) расположена ближе к A,
// и вывести эту точку и ее расстояние от точки A.
// Console.Write("Введите число A: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число C: ");
// int c = int.Parse(Console.ReadLine()!);
// int abDistance = Math.Abs(a - b);
// int acDistance = Math.Abs(a - c);
// if (abDistance < acDistance)
//     Console.WriteLine($"B is located closer to A. Distance: {abDistance}");
// else
//     Console.WriteLine($"C is located closer to A. Distance: {acDistance}");

// If 22 Даны координаты точки, не лежащей на координатных осях OX и OY.
// Определить номер координатной четверти, в которой находится данная точка.
// Console.Write("Введите число X: ");
// int x = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число Y: ");
// int y = int.Parse(Console.ReadLine()!);
// if (x > 0 && y > 0)
//     Console.WriteLine(1);
// if (x < 0 && y > 0)
//     Console.WriteLine(2);
// if (x < 0 && y < 0)
//     Console.WriteLine(3);
// if (x > 0 && y < 0)
//     Console.WriteLine(4);

// If 29 Дано целое число. Вывести его строку-описание вида «отрицательное четное число»,
// «нулевое число», «положительное нечетное число» и т. д.
// Console.Write("Введите число A: ");
// int a = int.Parse(Console.ReadLine()!);
// if (a == 0)
//     Console.WriteLine("Null");
// else
// {
//     if (a > 0)
//         Console.Write("Positive ");
//     else
//         Console.Write("Negative ");
//
//     if (a % 2 == 0)
//         Console.WriteLine("Even number");
//     else
//         Console.WriteLine("Odd number");
// }

// If 30 Дано целое число, лежащее в диапазоне 1–999.
// Вывести его строку-описание вида «четное двузначное число», «нечетное трехзначное число» и т. д
Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine()!);
if (a % 2 == 0)
    Console.Write("Even number");
else
    Console.Write("Odd number");

if (a > 0 && a < 10)
    Console.Write("Single-digit number");
else if (a > 9 && a < 100)
    Console.Write("Double-digit number");
else
    Console.Write("Three-digit number");

// if (a == 0)
// {
//     Console.WriteLine("Bull Shit");
// }
// else
// {
//     if (a <= 10)
//         Console.Write("Single-digit number");
//     else if (a >= 10 && a <= 99)
//         Console.Write("Double-digit number");
//     else
//         Console.Write("Three-digit number");
//     
//     if (a % 2 == 0)
//          Console.WriteLine("Even number");
//     else
//          Console.WriteLine("Odd number");
// }

//
// if (a >= 1 && a <= 999)
// {
//     if (a <= 10)
//     {
//         Console.Write("Single digit number");
//     }
//     
//     if (a % 2 == 0)
//     {
//         Console.WriteLine("Even number");
//     }
//     else
//     { 
//         Console.WriteLine("Odd number");
//     }
// }