using System;

namespace CbasHome6Task4
{
    /*Задание 6 

        Расширьте пример 5 (русско-английский словарь) еще и украинским словарем. Реализуйте возможность поиска
    не только по ключевым русским словам и словам на остальных языках.*/

    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.OutputEncoding = Encoding.Unicode;
            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["книжка"]);
            Console.WriteLine(dictionary["дом"]);
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["table"]);
            Console.WriteLine(dictionary["карандаш"]);
            Console.WriteLine(dictionary["apple"]);
            Console.WriteLine(dictionary["солнце"]);




            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
