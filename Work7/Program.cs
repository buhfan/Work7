namespace Work7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------------------------------------
            //1. Создать массив mass из 15 элементов. Заполнить его случайными числами от 10..99 и вывести в строку.
            //2. Посчитать и вывести среднее арифметическое массива.
            //3. Найти и вывести максимум массива.
            //3*. Найти и вывести второй максимум массива.
            //4. Пользователь вводит число T. Вывести все числа этого массива, которые делятся на T.
            //5. Все числа, которые делятся на 3 разделить на сумму всех чисел массива, делящихся на 3 и вывести получившийся массив.


            Random random = new Random();
            int[] mass = new int[15];
            int rand;
            int max =0;

            //ВСЕГДА разделяйте смысловые блоки
            for (int i = 0; i < mass.Length; i++)
            {
                rand = random.Next(9, 100);
                mass[i] = rand;
            }

            for (int j = 0; j < mass.Length; j++)
            {
                Console.Write($"{mass[j]} ");
                max = mass[0];
                if (mass[j] > max)
                {
                    max = mass[j];
                }
                else if (mass[j] == max)
                {
                    max = mass[j];
                }
                else
                {
                    max = max;
                }
                
            }
            Console.WriteLine();
            Console.WriteLine($"{max} - максимальное число");
            //for (int k = 0; k < mass.Length; k++)
            //{
            //    max = mass[0];
            //    if (max > mass[k])
            //    {
            //        max = mass[k];
            //    }
            //    else if (max == mass[k])
            //    {
            //        max = mass[k];
            //    }
            //    else
            //    {
            //        max = max;
            //    }
            //    Console.WriteLine($"{max} - максимаьное число");
            //}   
        }
    }
}