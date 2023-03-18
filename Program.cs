// №1 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.Write("Введите пятизначное число:  ");
// string number = Console.ReadLine()!;
// int n = number.Length;
// if (n!=5)
// {
//     Console.Write($"{number} не пятизначное то число");

// }
// else if(number[0] == number[4] && number[1] == number[3])
// {
//     Console.WriteLine($"{number} полиандр");
// }
//     else {
//     Console.WriteLine($"{number} обычное число");
// }


// № 2 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



// Console.Write("Введите положительное число: ");
// int num = int.Parse(Console.ReadLine()!);
// int start = 1;
// if(num <= 0){
// Console.Write("Число должно быть больше нуля");
// }
// else{
// while (start <= num)
// {
//     double s = Math.Pow(start, 3);

//     Console.Write($"{s }, ");
//     start++;
// }
// }

// № 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
// int Coordinat(string text)
// {
//     Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[] a = new int[3];
// int[] b = new int[3];
// int[] c = new int[3];

// a[0] = Coordinat("Значение Х точки A : ");
// a[1] = Coordinat("Значение Y точки A : ");
// a[2] = Coordinat("Значение Z точки A : ");
// b[0] = Coordinat("Значение Х точки B : ");
// b[1] = Coordinat("Значение Y точки B : ");
// b[2] = Coordinat("Значение Z точки B : ");

// double result = Math.Round(Math.Sqrt(Math.Pow(b[0] - a[0], 2) + Math.Pow(b[1] - a[1], 2) + Math.Pow(b[2] - a[2], 2)), 2);
// Console.WriteLine("Расстояние между точками = " + result);
