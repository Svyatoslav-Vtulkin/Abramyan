// Integer: 1-23, 30

// Integer1 Дано расстояние L в сантиметрах.
// Используя операцию деления нацело, найти количество полных метров в нем (1 метр = 100 см)
// Console.Write("Введите растояние L: ");
// int l = int.Parse(Console.ReadLine());
// Console.WriteLine($"Количество полных метров: {l / 100} ");

// Integer2 Дана масса M в килограммах.
// Используя операцию деления нацело,найти количество полных тонн в ней (1 тонна = 1000 кг).
// Console.Write("Введите массу M: ");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine($"Количество полных тонн: {m / 1000}");

// Integer3 Дан размер файла в байтах.
// Используя операцию деления нацело,найти количество полных килобайтов,
// которые занимает данный файл(1 килобайт = 1024 байта).
// Console.Write("Введите размер файла: ");
// int bait = int.Parse(Console.ReadLine());
// Console.WriteLine($"Размер файла в Кбайт: {bait / 1024}");
 
// Integer4 Даны целые положительные числа A и B (A > B).
// На отрезке длины A размещено максимально возможное количество отрезков длины B (без наложений).
// Используя операцию деления нацело, найти количество отрезков B, размещенных на отрезке A.
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение B: ");
// int b = int.Parse(Console.ReadLine());
//Console.WriteLine($"Количество отрезков: {a / b}");

// Integer5 Даны целые положительные числа A и B (A > B).
// На отрезке длины A размещено максимально возможное количество отрезков длины B (без наложений).
// Используя операцию взятия остатка от деления нацело, найти длину незанятой части отрезка A.
// Console.Write("Введите значение A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите значение B: ");
// int b = int.Parse(Console.ReadLine());
// Console.WriteLine($"Длина не занятой части равна {a % b}");

// Integer6 Дано двузначное число. Вывести вначале его левую цифру (десятки), а затем — его правую цифру (единицы).
// Для нахождения десятков использовать операцию деления нацело,
// для нахождения единиц — операцию взятия остатка от деления.
// Console.Write("Введите двузначное число A: ");
// int a = int.Parse(Console.ReadLine());
// int left = a / 10;
// int right = a % 10;
// Console.WriteLine($"Левая цифра: {left}");
// Console.WriteLine($"Правая цифра: {right}");

// Integer7 Дано двузначное число. Найти сумму и произведение его цифр.
// Console.Write("Введите двузначное число A: ");
// int a = int.Parse(Console.ReadLine());
// int left = a / 10;
// int right = a % 10;
// Console.WriteLine($"Сумма: {left + right}");
// Console.WriteLine($"Произведение: {left * right}");

// // Integer8 Дано двузначное число. Вывести число, полученное при перестановке цифр исходного числа.
// Console.Write("Введите двузначное число A: ");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine($"Число: {a % 10}{a / 10}");

// Integer9 Дано трехзначное число. Используя одну операцию деления нацело,вывести первую цифру данного числа (сотни).
// Console.Write("Введите трехзначное число A: ");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine($"Число: {a / 100}");

// Integer10 Дано трехзначное число. Вывести вначале его последнюю цифру (единицы),
// а затем — его среднюю цифру (десятки).
// Console.Write("Введите трехзначное число A: ");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine($"Число: {a % 10}{a / 10 % 10}");

// Integer11 Дано трехзначное число. Найти сумму и произведение его цифр.
// Console.Write("Введите трехзначное число A: ");
// int a = int.Parse(Console.ReadLine());
// int first = a % 10;
// int second = a / 10 % 10;
// int third = a / 100;
// Console.WriteLine($"Сумма {first + second + third}");
// Console.WriteLine($"Произведение {first * second * third}");

// Integer12 Дано трехзначное число. Вывести число, полученное при прочтении исходного числа справа налево.
// Console.Write("Введите трехзначное число A: ");
// int a = int.Parse(Console.ReadLine());
// int first = a % 10;
// int second = a / 10 % 10;
// int third = a / 100;
// Console.WriteLine($"Число наоборот: {first}{second}{third}");

// Integer13 Дано трехзначное число. В нем зачеркнули первую слева цифру и приписали ее справа. Вывести полученное число.
// Console.Write("Введите трехзначное число A: ");
// int a = int.Parse(Console.ReadLine());
// int first = a / 100;
// int second = a / 10 % 10;
// int third = a % 10;
// Console.WriteLine($"Число: {second}{third}{first}");

//Integer14 Дано трехзначное число. В нем зачеркнули первую справа цифру и приписали ее слева.
//Вывести полученное число.
// Console.Write("Введите трехзначное число A: ");
// int a = int.Parse(Console.ReadLine());
// int first = a / 100;
// int second = a / 10 % 10;
// int third = a % 10;
// Console.WriteLine($"Число: {third}{first}{second}");

// Integer15 Дано трехзначное число.
// Вывести число, полученное при перестановке цифр сотен и десятков исходного числа (например, 123 перейдет в 213).
// Console.Write("Введите трехзначное число A: ");
// int a = int.Parse(Console.ReadLine());
// int first = a / 100;
// int second = a / 10 % 10;
// int third = a % 10;
// Console.WriteLine($"Число: {second}{first}{third}");

// Integer16 Дано трехзначное число.
// Вывести число, полученное при перестановке цифр десятков и единиц исходного числа (например, 123 перейдет в 132).
// Console.Write("Введите трехзначное число A: ");
// int a = int.Parse(Console.ReadLine());
// int first = a / 100;
// int second = a / 10 % 10;
// int third = a % 10;
// Console.WriteLine($"Число: {first}{third}{second}");

// Integer17 Дано целое число, большее 999.
// Используя одну операцию деления нацело и одну операцию взятия остатка от деления,
// найти цифру, соответствующую разряду сотен в записи этого числа.
// Console.Write("Введите трехзначное число A: ");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine($"Цифра: {a / 100 % 10}");

// Integer18 Дано целое число, большее 999.
// Используя одну операцию деления нацело и одну операцию взятия остатка от деления,
// найти цифру, соответствующую разряду тысяч в записи этого числа.
// Console.Write("Введите трехзначное число A: ");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine($"Цифра: {a / 1000 % 10}");

// Integer19 С начала суток прошло N секунд (N — целое).
// Найти количество полных минут, прошедших с начала суток.
// Console.Write("Введите число секунд N: ");
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine($"Кол-во полных минут {n / 60}");

// Integer20 С начала суток прошло N секунд (N — целое).
// Найти количество полных часов, прошедших с начала суток.
// Console.Write("Введите число секунд N: ");
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine($"Кол-во полных часов {n / 3600}");

// Integer21 С начала суток прошло N секунд (N — целое).
// Найти количество секунд, прошедших с начала последней минуты.
// Console.Write("Введите число секунд N: ");
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine($"Кол-во секунд {n % 60}");

// Integer22 С начала суток прошло N секунд (N — целое).
// Найти количество секунд, прошедших с начала последнего часа.
// Console.Write("Введите число секунд N: ");
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine($"Кол-во секунд {n % 3600}");

// Integer23 С начала суток прошло N секунд (N — целое).
// Найти количество полных минут, прошедших с начала последнего часа.
// Console.Write("Введите число секунд N: ");
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine($"Кол-во полных минут {n % 3600 / 60}");

//Integer30 Дан номер некоторого года (целое положительное число).
//Определить соответствующий ему номер столетия, учитывая, что, к примеру, началом 20 столетия был 1901 год.
// Console.Write("Введите год: ");
// int year = int.Parse(Console.ReadLine());
// Console.WriteLine($"Номер столетия: {(year - 1) / 100 + 1}");