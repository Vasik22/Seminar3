//Задача 1 способ 1
// Console.Write("Введите пятизначное число ");
// int number = int.Parse(Console.ReadLine());
// int temp = number;
// int reversenumber = 0;
// while (temp != 0)
// {
//     reversenumber = reversenumber * 10 + temp % 10; //Переворачиваем число по цифрам
//     temp /= 10; //Отбрасываем последнюю цифру
// }

// if (number == reversenumber)
// {
//     Console.WriteLine("True");
// }

// else
// {
//     Console.WriteLine("False");
// }

// return 0;

//Задача 1 способ 2
// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int len = number.Length;

// if (len == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"{number} - Палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"{number} - НЕ палиндром");
//     }
// }
// else
// {
//     Console.WriteLine($"ОШИБКА: {number} - Плохое число");
// }
Console.WriteLine("Введите координату X первой точки: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки: ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату X второй точки: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки: ");
int z2 = int.Parse(Console.ReadLine());
int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {length}");


