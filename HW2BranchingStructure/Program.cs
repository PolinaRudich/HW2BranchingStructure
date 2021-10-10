using System;

namespace HW2BranchingStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите число А");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double B = Convert.ToDouble(Console.ReadLine());

            double result;
            if (A > B)
            {
                result = A + B;
            }
            else if (A == B)
            {
                result = A * B;
            }
            else
            {
                result = A - B;
            }

            Console.WriteLine($"Результат: {result}");

            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите число X");
            double X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число Y");
            double Y = Convert.ToDouble(Console.ReadLine());
            string result2;
           
            if (X > 0 && Y > 0)
            {
                result2 = "I";


            }
            else if (X < 0 && Y > 0)
            {
                result2 = "II";
            }
            else if (X < 0 && Y < 0)
            {
                result2 = "III";
            }
            else
            {
                result2 = "IV";
            }
            if (X == 0 || Y == 0)
            {
                result2 = "Точка лежит на одной из координатных прямых";
            }
            Console.WriteLine(result2);

            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите число A");
            double A3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double B3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число C");
            double C3 = Convert.ToDouble(Console.ReadLine());

            if (A3 <= B3 && B3 <= C3)
            {
                Console.WriteLine($"{A3},{ B3},{ C3}");
            }
            else if (B3 <= A3 && A3 <= C3)
            {
                Console.WriteLine($"{B3},{A3},{C3}");
            }
            else if (C3 <= A3 && A3 <= B3)
            {
                Console.WriteLine($"{C3},{A3},{B3}");
            }
            else if (A3 <= C3 && C3 <= B3)
            {
                Console.WriteLine($"{A3},{C3},{B3}");
            }
            else if (B3 <= C3 && C3 <= A3)
            {
                Console.WriteLine($"{B3},{C3},{A3}");
            }
            else if (C3 <= B3 && B3 <= A3)
            {
                Console.WriteLine($"{C3},{B3},{A3}");
            }

            //Пользователь вводит 3 числа (A, B и С).
            //Выведите в консоль решение(значения X) квадратного уравнения стандартного вида,
            //где AX2+BX+C=0.

            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите число A");
            double A4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double B4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число C");
            double C4 = Convert.ToDouble(Console.ReadLine());
            double discriminant = Math.Pow(B4, 2) - 4*(A4) * (C4);
            double x1 = ((-1 * (B4)) - Math.Sqrt(discriminant)) / (2 * (A4));
            double x2 = ((-1 * (B4)) + Math.Sqrt(discriminant)) / (2 * (A4));
            if (discriminant>0)
            {
                Console.WriteLine($"Ответ x1={x1} x2={x2}");
            }
             else if (discriminant < 0)
            {
                Console.WriteLine("Решений нет");
            }
            else if (discriminant == 0)
            {
                Console.WriteLine($"Ответ x1={x1} x2={x2}");
            }
            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите двузначное число");
            int number = Convert.ToInt32(Console.ReadLine());
            string fromTenToNineteen = "";

            fromTenToNineteen = number switch
            {
                10 => "десять",
                11 => "одинадцать",
                12 => "двенадцать",
                13 => "тринадцать",
                14 => "Четырнадцать",
                15 => "Пятнадцать",
                16  => "Шестнадцать",
                17 => "Семнадцать",
                18 =>"Восемнадцать",
                19 =>"Девятнадцать",
                _=>"",
            };
            //switch (number)
            //{
            //    case 10:
            //        fromTenToNineteen = "Десять";
               
            //        break;
            //    case 11:
            //        fromTenToNineteen = "Одинадцать";
            //        break;
            //    case 12:
            //        fromTenToNineteen = "Двенадцать";
            //        break;
            //    case 13:
            //        fromTenToNineteen = "Тринадцать";
            //        break;
            //    case 14:
            //        fromTenToNineteen = "Четырнадцать";
            //        break;
            //    case 15:
            //        fromTenToNineteen = "Пятнадцать";
            //        break;
            //    case 16:
            //        fromTenToNineteen = "Шестнадцать";
            //        break;
            //    case 17:
            //        fromTenToNineteen = "Семнадцать";
            //        break;
            //    case 18:
            //        fromTenToNineteen = "Восемнадцать";
            //        break;
            //    case 19:
            //        fromTenToNineteen = "Девятнадцать";
            //        break;

            //}
            int ten = number / 10;
            int one = number % 10;
            string tens = "";
            string ones = "";
            tens = ten switch
            {
                2 => "Двадцать",
                3=> "Тридцать",
                4=> "Сорок",
                5=>"Пятьдесят",
                6=> "Шестьдесят",
                7=> "Семьдесят",
                8=> "Восемдесят",
                9=>"Девяносто",
                _=>"",
            };
            ones = one switch
            { 
                1=>"один",
                2=>"два",
                3=>"три",
                4=>"четыре",
                5=>"пять",
                6=>"шесть",
                7=>"семь",
                8=>"восемь",
                9=>"девять",


            };
            //switch (ten)
            //{
            //    case 2:
            //        tens = "Двадцать";
            //        break;
            //    case 3:
            //        tens = "Тридцать";
            //        break;
            //    case 4:
            //        tens = "Сорок";
            //        break;
            //    case 5:
            //        tens = "Пятьдесят";
            //        break;
            //    case 6:
            //        tens = "Шестьдесят";
            //        break;
            //    case 7:
            //        tens = "Семьдесят";
            //        break;
            //    case 8:
            //        tens = "Восемдесят";
            //        break;
            //    case 9:
            //        tens = "Девяносто";
            //        break;
            //    default:
            //        break;
            //}
            //switch (one)
            
            //{
            //    case 1:
            //        ones = " oдин";
            //        break;
            //    case 2:
            //        ones = "два";
            //        break;
            //    case 3:
            //        ones = "три";
            //        break;
            //    case 4:
            //        ones = "четыре";
            //        break;
            //    case 5:
            //        ones = "пять";
            //        break;
            //    case 6:
            //        ones = "шесть";
            //        break;
            //    case 7:
            //        ones = "семь";
            //        break;
            //    case 8:
            //        ones = "восемь";
            //        break;
            //    case 9:
            //        ones = "девять";
            //        break;

            //    default:
            //        break;
            //}

            if (number<20&&number>9)
            {
                Console.WriteLine("Результат: " + fromTenToNineteen);
            }
            else if (number<10||number>99)
            {
                Console.WriteLine("Результат: Число не принадлежит диапазону от 10 до 99");
            }
            else if (number > 19 && number < 100)
            {
                Console.WriteLine("Результат: "+ tens +" "+ ones);
            }
        }
    }
}
