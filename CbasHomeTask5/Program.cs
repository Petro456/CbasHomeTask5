using System;


namespace CbasHomeTask5
{
    /*Задание 2 

        Используя Visual Studio, создайте проект по шаблону Console Application. Требуется: 
    Создать массив размерностью N элементов, заполнить его произвольными целыми значениями. 
    Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов, 
    среднее арифметическое всех элементов, вывести все нечетные значения. */

    internal class Program
    {
        static void Main(string[] args)
        {           
            Random rand = new Random();
            int[] masuv = new int[40];
            for (int i = 0; i < masuv.Length; i++)
            {
                masuv[i] = rand.Next(0, 50);
                
                Console.Write("/ "+ masuv[i]+"   ");
                
            }
            int min = 0;
            Console.WriteLine();
            Console.WriteLine(new string ('*',80));
            for (int i = 0; i < masuv.Length; i++)
            {
                if (masuv[i] < masuv[min]) min = i;
            }
            Console.WriteLine("Мiнiмальнi значення  -  " + masuv[min]);
           
            int max = 0;
            Console.WriteLine(new string('*', 80));

            for (int i = 0; i < masuv.Length; i++)
            {
                if (masuv[i] > masuv[max]) max = i;
            }
            Console.WriteLine("Максимальне значення  -  " + masuv[max]);
           
            double serSum = 0;
            int sum = 0;
            Console.WriteLine(new string('*', 80));

            for (int i = 0; i < masuv.Length; i++)
            {
                sum += masuv[i];
            }
            serSum = sum / masuv.Length;
            Console.WriteLine("Середнє арифметичне значення -  " + serSum);
            Console.WriteLine(new string('*', 80));

            Console.WriteLine("Сума всiх значення -  " + sum);
            Console.WriteLine(new string('*', 80));

            for (int i = 0; i < masuv.Length; i++)
            {
                if (masuv[i] % 2 == 0)
                    Console.WriteLine("Парнi значення -  " + masuv[i]);
            }

            Console.ReadKey();
        }
    }
}
