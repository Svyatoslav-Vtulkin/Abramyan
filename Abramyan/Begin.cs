// Begin: 1-12, 16, 20, 22-24, 31-34

// Begin 1
// Дана сторона квадрата a. Найти его периметр P = 4·a.
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine(4 * a);

// Begin 2
// Дана сторона квадрата a. Найти его площадь S = a^2.
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine(Math.Pow(a, 2));

// Begin 3
// Даны стороны прямоугольника a и b. Найти его площадь S = a·b и периметр P = 2·(a + b).
// Console.Write("Введите значение a:");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение b:");
// int b = int.Parse(Console.ReadLine());
// Console.Write("Площадь равна:");        // МОЖНО СОКРАТИТЬ
// Console.WriteLine(a * b);
// Console.Write("Периметр равен:");
// Console.WriteLine(2 * (a + b));

// Begin 4
// Дан диаметр окружности d. Найти ее длину L = π·d. В качестве значения π использовать 3.14.
// Console.Write("Введите значение D: ");
// int d = int.Parse(Console.ReadLine());
// Console.WriteLine($"Длина окружности равна: {d * 3,14}"); // 3.14

// Begin 5
// Дана длина ребра куба a.Найти объем куба V = a^3 и площадь его поверхности S = 6·a^2.
// Console.Write("Введите значение a:");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Объем куба равен:");
// Console.WriteLine(Math.Pow(a, 3));
// Console.Write("Площадь поверхности равна:");
// Console.Write(6 * Math.Pow(a,2));

// Begin 6
// Даны длины ребер a, b, c прямоугольного параллелепипеда.
// Найти его объем V = a·b·c и площадь поверхности S = 2·(a·b + b·c + a·c).
// Console.Write("Введите значение a:");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение b:");
// int b = int.Parse(Console.ReadLine());
// Console.Write("Введите значение c:");
// int c = int.Parse(Console.ReadLine());
// Console.WriteLine($"Объем равен {a * b * c}");
// Console.WriteLine($"Площадь поверхности равна {2 * (a * b + b * c + a * c)}");

// Begin 7
// Найти длину окружности L и площадь круга S заданного радиуса R: L = 2·π·R, S = π·R^2.
// Console.Write("Введите значение R:");
// int R = int.Parse(Console.ReadLine());
// Console.WriteLine($"Объем равен {R * 2 * 3,14}");
// Console.WriteLine($"Площадь поверхности равна {Math.Pow(R,2)*3,14}");

// Begin 8
// Даны два числа a и b. Найти их среднее арифметическое: (a + b) / 2
// Console.Write("Введите значение a:");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение b:");
// int b = int.Parse(Console.ReadLine());
// Console.WriteLine($"Среднее арифметическое {(a+b)/2}");

// Begin 9
// Даны два неотрицательных числа a и b.
// Найти их среднее геометрическое, то есть квадратный корень из их произведения: √a·b.
// Console.Write("Введите значение a:");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение b:");
// int b = int.Parse(Console.ReadLine());
// Console.WriteLine($"Среднее арифметическое {Math.Sqrt(a * b)}");

// Begin 10
// Даны два ненулевых числа. Найти сумму, разность, произведение и частное их квадратов.
// Console.Write("Введите значение a:");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение b:");
// int b = int.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма {Math.Pow(a, 2) + Math.Pow(b, 2)}");
// Console.WriteLine($"Разность {Math.Pow(a, 2) - Math.Pow(b, 2)}");
// Console.WriteLine($"Произведение {Math.Pow(a, 2) * Math.Pow(b, 2)}");
// Console.WriteLine($"Частное {Math.Pow(a/b, 2)}");

// Begin 11
// Даны два ненулевых числа. Найти сумму, разность, произведение и частное их модулей.
// Console.Write("Введите значение a:");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение b:");
// int b = int.Parse(Console.ReadLine());
// int a = Math.Abs(a);
// int b = Math.Abs(b);
// Console.WriteLine($"Сумма {Math.Pow(a, 2) + Math.Pow(b, 2)}");
// Console.WriteLine($"Разность {Math.Pow(a, 2) - Math.Pow(b, 2)}");
// Console.WriteLine($"Произведение {Math.Pow(a, 2) * Math.Pow(b, 2)}");
// Console.WriteLine($"Частное {Math.Pow(a/b, 2)}");

// Begin 12
// Даны катеты прямоугольного треугольника a и b.
// Найти его гипотенузу c и периметр P: c =√(a^2 + b^2), P = a + b + c.
// Console.Write("Введите значение a:");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение b:");
// int b = int.Parse(Console.ReadLine());
// int c = Math.Pow(a, 2) + Math.Pow(b, 2));
// Console.WriteLine($"Гипотенузу {c}");
// Console.WriteLine($"Периметр {a + b + c}");

// Begin 16
// Найти расстояние между двумя точками с заданными координатами x1 и x2 на числовой оси: | x2 − x1 |.
// Console.Write("Введите значение x1:");
// int x1 = int.Parse(Console.ReadLine());
// Console.Write("Введите значение x2:");
// int x2 = int.Parse(Console.ReadLine());
// Console.WriteLine($"Расстояние {x1 - x2}");

// Begin 20
// Найти расстояние между двумя точкамис заданными координатами(x1, y1) и(x2, y2) на плоскости.
// Расстояние вычисляется по формуле √((x2 − x1)^2 + (y2 − y1)^2)
// Console.Write("Введите значение x1:");
// int x1 = int.Parse(Console.ReadLine());
// Console.Write("Введите значение x2:");
// int x2 = int.Parse(Console.ReadLine());
// Console.Write("Введите значение y1:");
// int y1 = int.Parse(Console.ReadLine());
// Console.Write("Введите значение y2:");
// int y2 = int.Parse(Console.ReadLine());
// double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 -y1, 2));
// Console.WriteLine($"Расстояние равно {result}");

//Begin 22
// Поменять местами содержимое переменных A и B и вывести новые значения A и B.
// Console.Write("Введите значение A:");
// int A = int.Parse(Console.ReadLine());
// Console.Write("Введите значение B:");
// int B = int.Parse(Console.ReadLine());
// (A, B) = (B, A);
// Console.WriteLine($"A равно {A}");
// Console.WriteLine($"B равно {B}");

// Begin23
// Даны переменные A, B, C.
// Изменить их значения, переместив содержимое A в B, B — в C, C — в A, и вывести новые значения переменных A,B, C.
// Console.Write("Введите значение A:");
// int A = int.Parse(Console.ReadLine());
// Console.Write("Введите значение B:");
// int B = int.Parse(Console.ReadLine());
// Console.Write("Введите значение C:");
// int C = int.Parse(Console.ReadLine());
// int b = B;
// B = A;
// A = C;
// C = b;
// Console.WriteLine($"A равно {A}");
// Console.WriteLine($"B равно {B}");
// Console.WriteLine($"C равно {C}");

// Begin24
// Даны переменные A, B, C.
// Изменить их значения, переместив содержимое A в C, C — в B, B — в A, и вывести новые значения переменных A,B, C
// Console.Write("Введите значение A:");
// int A = int.Parse(Console.ReadLine());
// Console.Write("Введите значение B:");
// int B = int.Parse(Console.ReadLine());
// Console.Write("Введите значение C:");
// int C = int.Parse(Console.ReadLine());
// int b = B;
// B = C;
// C = A;
// A = b;
// Console.WriteLine($"A равно {A}");
// Console.WriteLine($"B равно {B}");
// Console.WriteLine($"C равно {C}");

// Begin31
// Дано значение температуры T в градусах Фаренгейта.
// Определить значение этой же температуры в градусах Цельсия.
// Температура по Цельсию TC и температура по Фаренгейту TF связаны следующим соотношением:TC = (TF − 32)·5 / 9.
// Console.Write("Введите значение Tf:");
// int Tf = int.Parse(Console.ReadLine());
// int Tc = (Tf - 32) * 5 / 9;
// Console.WriteLine($"Температура Tf равна {Tf}");
// Console.WriteLine($"Температура Tc равна {Tc}");

// Begin32 
// Дано значение температуры T в градусах Цельсия.
// Определить значение этой же температуры в градусах Фаренгейта.
// Температура по Цельсию TC и температура по Фаренгейту TF связаны следующим соотношением:TC = (TF − 32)·5 / 9
// Console.Write("Введите значение Tc:");
// int Tc = int.Parse(Console.ReadLine());
// int Tf = Tc * 5 / 9 + 32;
// Console.WriteLine($"Температура Tc равна {Tc}");
// Console.WriteLine($"Температура Tf равна {Tf}");

// Begin33
// Известно, что X кг конфет стоит A рублей.
// Определить, сколько стоит 1 кг и Y кг этих же конфет.
// Console.Write("Введите значение X:");
// int X = int.Parse(Console.ReadLine());
// Console.Write("Введите значение A:");
// int A = int.Parse(Console.ReadLine());
// Console.Write("Введите значение Y:");
// int Y = int.Parse(Console.ReadLine());
// Console.WriteLine($"1 кг стоит {A / X}");
// Console.WriteLine($"{Y} кг стоит {(A / X) * Y}");

// Begin34
// Известно, что X кг шоколадных конфет стоит A рублей, а Y кг ирисок стоит B рублей.
// Определить, сколько стоит 1 кг шоколадных конфет,1 кг ирисок, а также во сколько раз шоколадные конфеты дороже ирисок.
// Console.Write("Введите значение X:");
// int X = int.Parse(Console.ReadLine());
// Console.Write("Введите значение A:");
// int A = int.Parse(Console.ReadLine());
// Console.Write("Введите значение Y:");
// int Y = int.Parse(Console.ReadLine());
// Console.Write("Введите значение B:");
// int B = int.Parse(Console.ReadLine());
// double priceChocolate = A / X;
// double priceIriska = B / Y;
// double raznost = priceChocolate / priceIriska;
// Console.WriteLine($"1 кг Шоколадных конфет стоит {priceChocolate}");
// Console.WriteLine($"1 кг Ирисок стоит {priceIriska}");
// Console.WriteLine($"Разность в стоимости {raznost}");