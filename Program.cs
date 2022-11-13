using System;

namespace Семинар_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //_________ДОМАШНЕЕ ЗАДАНИЕ 9 СЕМИНАР_____________

            /* Задача 64: Задайте значение N. 
            Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
            Выполнить с помощью рекурсии. */



            /* Console.WriteLine("Введите натуральное число:");
            int Num = int.Parse(Console.ReadLine());
            Order(Num);

            void Order(int n){
                if (n<=0) 
                {
                    Console.WriteLine("Введено ненатуральное число!");
                    return;
                }
                if (n==1 && n>0)
                {
                  Console.Write($"{1}."); 
                }
                else
                {
                    Console.Write($"{n}, ");
                    Order(n-1);
                }
                

            } */

            /* Задача 66: Задайте значения M и N. 
            Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. */


            /* Console.WriteLine("Сумма натуральных чисел от:");
            int Num = int.Parse(Console.ReadLine());
            Console.WriteLine("до:");
            int Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(SumOrder(Num, Num1));
            

            int SumOrder (int num, int num1){
             
                if (num <= num1)
                {   
                    int result = num + SumOrder(num+1, num1);
                    return result;
                }
                else
                {
                    return 0;
                }
            } */


            /* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
            Даны два неотрицательных числа m и n */

            /* Console.WriteLine("Введите натуральное число M:");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите натуральное число N:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(FunAckermann(M, N));

            int FunAckermann(int m, int n){
                if (m == 0) return n + 1;
                if (m > 0 && n == 0) return FunAckermann(m - 1, 1);
                if (m > 0 && n > 0) return FunAckermann(m - 1, FunAckermann(m, n - 1));
            return FunAckermann(m, n);
            } */
        }
    }
}
