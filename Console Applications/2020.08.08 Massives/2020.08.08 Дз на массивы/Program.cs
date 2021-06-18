using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace _2020._08._08_Дз_на_массивы
{
    class Program
    {
        static void Main(string[] args)
        {
            
                 /* Задание (начальное)
                1. Объявить одномерный (5 элементов ) массив с именем
                A и двумерный массив (3 строки, 4 столбца) дробных
                чисел с именем B. Заполнить одномерный массив А
                числами, введенными с клавиатуры пользователем,
                а двумерный массив В случайными числами с помощью циклов. Вывести на экран значения массивов:
                массива А в одну строку, массива В — в виде матрицы. Найти в данных массивах общий максимальный
                элемент, минимальный элемент, общую сумму всех
                элементов, общее произведение всех элементов, сумму четных элементов массива А, сумму нечетных
                столбцов массива В. */
             Console.WriteLine("Задача №1");
             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine("Введите значения массива А:");
             int[] A = new int[5];
             for (int i = 0; i < 5; i++)
             {
                 A[i] = Convert.ToInt32(Console.ReadLine());
             }
             Console.WriteLine("Массив А: ");
             foreach (int i in A)
             Console.Write($"{i} ");
             Console.WriteLine();

             Console.WriteLine("Массив В: ");
             double[,] B = new double[3, 4];
             for (int i = 0; i < 3; i++)
             {
                 for (int j = 0; j < 4; j++)
                 {
                     Random value = new Random();
                     B[i, j] = value.NextDouble() * 100;
                     Console.Write($"{B[i, j]} \t");
                 }
                 Console.WriteLine();
             }
             Console.WriteLine();
             int max_A = 0;
             double max_B = 0;
             int x_A = 1;
             double x_B = 1;
             int min_A = 1000;
             double min_B = 1000;
             int sum_A = 0;
             int chetn_A = 0;
             double sum_B = 0;
             double nechetn_B = 0;
             for (int i = 0; i < 5; i++)
             {
                 if (A[i] > max_A)
                 {
                     max_A = A[i];
                 }

                 if (A[i] < min_A)
                 {
                     min_A = A[i];
                 }

                 if (A[i] % 2 == 0)
                 {
                     chetn_A = A[i] + chetn_A;
                 }

                 sum_A = A[i] + sum_A;
                 x_A = A[i] * x_A;
             }

             for (int i = 0; i < 3; i++)
             {
                 for (int j = 0; j < 4; j++)
                 {
                     if (B[i, j] > max_B)
                     {
                         max_B = B[i, j];
                     }

                     if (B[i, j] < min_B)
                     {
                         min_B = B[i, j];
                     }
                     sum_B = +B[i, j];
                     x_B = B[i, j] * x_B;

                     if (j%2 != 0)
                     {
                         nechetn_B = B[i,j]+nechetn_B;
                     }

                 }
             }

             if (max_A > max_B)
             {
                 Console.WriteLine("Максимальное значение среди двух массивов:{0}", max_A);
             }
             else
             {
                 Console.WriteLine("Максимальное значение среди двух массивов:{0}", max_B);
             }
             Console.WriteLine();

             if (min_A < min_B)
             {
                 Console.WriteLine("Минимальное значение среди двух массивов:{0}", min_A);
             }
             else
             {
                 Console.WriteLine("Минимальное значение среди двух массивов:{0}", min_B);
             }

             Console.WriteLine();

             double sum;
             double x;

             sum = sum_A + sum_B;

             Console.WriteLine("Сумма всех элементов массивов: {0}", sum);
             Console.WriteLine();

             x = x_A * x_B;
             Console.WriteLine("Произведение всех элементов массивов: {0}", x);
             Console.WriteLine();

             Console.WriteLine("Сумма всех четных элементов массива А: {0}", chetn_A);
             Console.WriteLine();

             Console.WriteLine("Сумма всех элементов нечетных столбцов массива В: {0}", nechetn_B);
             Console.WriteLine();

             /*Даны 2 массива размерности M и N соответственно.
               Необходимо переписать в третий массив общие элементы первых двух массивов без повторений.*/

             Console.WriteLine("Задача №2");
             Console.WriteLine();
             int n = 0;
             int m = 0;
             Console.WriteLine("Введите размера первого массива");
             n = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine();
             Console.WriteLine("Введите размер второго массива");
             m = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine();
             int[] mass1 = new int[n];
             int[] mass2 = new int[m];
             int a = n + m;
             int[] mainmass = new int[a];

             Console.WriteLine("Введите значения первого массива:");
             for (int i = 0; i<n; i++)
             {
                 mass1[i] = Convert.ToInt32(Console.ReadLine());
             }

             Console.WriteLine();
             Console.WriteLine("Введите значения второго массива:");
             for (int i = 0; i<m; i++)
             {
                 mass2[i] = Convert.ToInt32(Console.ReadLine());
             }
             Console.WriteLine();
             Console.WriteLine("Первый массив:");
             foreach (int i in mass1)
             Console.Write($"{i} ");
             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine("Второй массив:");
             foreach (int i in mass2)
             Console.Write($"{i} ");
             Console.WriteLine();
             Console.WriteLine();
             int k = 0;
             int b = 0;
             int counter = 0;
             int counter2 = 0;
             int counter3 = 0;
             for (int i = 0; i < a; i++)
             {
                 do
                 {
                     do
                     {
                         if (k == n || b == m || counter3 == mass2[b])
                         {
                             k = n;
                         }
                         else if (mass1[k] == mass2[b])
                         {
                            mainmass[i] = mass2[b];
                             counter3 = mass2[b];
                            counter2 = b;
                            counter++;
                            k = n;
                            b = m;

                         }
                         else
                         {
                            k++;
                         }

                     }
                     while (k < n);
                     k = 0;
                     b++;
                 }
                 while (b < m);

                     b = counter2+1;
             }
             Console.WriteLine();
             Console.WriteLine("Массив общих чисел первого и второго массива");
             for(int i = 0; i < counter; i++)
             {
                 Console.Write($"{mainmass[i]} ");
             }
            Console.WriteLine();

            /*Задача № 3 Пользователь вводит строку. Проверить, является ли
             * эта строка палиндромом. Палиндромом называется
             * строка, которая одинаково читается слева направо
             * и справа налево.*/

            Console.WriteLine("Задача № 3");
            Console.WriteLine();
            char[] charmass;

            string strocmass;
            Console.WriteLine("Введите слово: ");
            strocmass = Console.ReadLine();
            charmass = strocmass.ToCharArray();
            Console.WriteLine(strocmass);
            Console.WriteLine(charmass);
            int bi = charmass.Length - 1;
            for (int i = 0; i < charmass.Length; i++)
            {
                if (charmass.Length % 2 == 0)
                {
                    if (bi == (charmass.Length - 1) / 2)
                    {
                        Console.WriteLine("Данная строка палиндром");
                        break;
                    }
                    else if (charmass[i] == charmass[bi])
                    {
                        bi--;
                    }
                    else
                    {
                        Console.WriteLine("Данная строка не палиндромом");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Строка имеет нечетное количество элементов");
                    break;

                }
            }

            /*Задача №4 Подсчитать количество слов во введенном предложении. */

            Console.WriteLine("Задача № 4");
            Console.WriteLine();

            Console.WriteLine("Введите текст:");
            string[] textMass;
            string text = Console.ReadLine();
            textMass = text.Split(' ');
            Console.WriteLine("Количество слов:");
            Console.WriteLine(textMass.Length);

            /*Зачада № 5 Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100.
             * Определить сумму элементов массива, расположенных
             * между минимальным и максимальным элементами.*/

            Console.WriteLine("Задача № 5");
            Console.WriteLine();

            int[,] mass = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Random value = new Random();
                    mass[i, j] = value.Next(-100, 100);
                    Console.Write($"{mass[i, j]} \t");
                }
            }

            Console.WriteLine();
            int max_mass = 0;
            int min_mass = 101;
            int index1A = 0;
            int index2A = 0;
            int index1B = 0;
            int index2B = 0;
            int sum2 = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (mass[i, j] > max_mass)
                    {
                        max_mass = mass[i, j];
                        index1A = i;
                        index2A = j;
                    }
                    else if (mass[i, j] < min_mass)
                    {
                        min_mass = mass[i, j];
                        index1B = i;
                        index2B = j;
                    }
                }
            }
            if (index1A > index1B && index2A > index2B)
            {
                for (int i = index1B; i < index1A; i++)
                {
                    for (int j = index2B; j < index2A; j++)
                    {
                        sum2 = mass[i, j] + sum2;
                    }
                }
                Console.WriteLine("Максимальный элемент:{0}", max_mass);
                Console.WriteLine("Минимальный элемент:{0}", min_mass);
                Console.WriteLine("сумма элементов:{0}", sum2);
            }
            else if (index1B > index1A && index2B > index2A)
            {
                for (int i = index1A; i < index1B; i++)
                {
                    for (int j = index2A; j < index2B; j++)
                    {
                        sum2 = mass[i, j] + sum2;
                    }
                }
                Console.WriteLine("Максимальный элемент:{0}", max_mass);
                Console.WriteLine("Минимальный элемент:{0}", min_mass);
                Console.WriteLine("сумма элементов:{0}", sum2);
            }
            else if (index1B > index1A && index2A > index2B)
            {
                for (int i = index1A; i < index1B; i++)
                {
                    for (int j = index2B; j < index2A; j++)
                    {
                        sum2 = mass[i, j] + sum2;
                    }
                }
                Console.WriteLine("Максимальный элемент:{0}", max_mass);
                Console.WriteLine("Минимальный элемент:{0}", min_mass);
                Console.WriteLine("сумма элементов:{0}", sum2);
            }
            else if (index1A > index1B && index2B > index2A)
            {
                for (int i = index1B; i < index1A; i++)
                {
                    for (int j = index2A; j < index2B; j++)
                    {
                        sum2 = mass[i, j] + sum2;
                    }
                }
                Console.WriteLine("Максимальный элемент:{0}", max_mass);
                Console.WriteLine("Минимальный элемент:{0}", min_mass);
                Console.WriteLine("сумма элементов:{0}", sum2);
            }
        }
    }
}

 
 
 