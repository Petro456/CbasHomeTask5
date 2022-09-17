using System;
using System.Linq;

namespace CbasHome4Task4
{
    /// <summary>
    /// В 77 рядку n нуль і не можу по ціні вибрати, гляньте як зможите. Дякую!
    /// </summary>
    class Article
    {
       public string nameTovar { get; set; }
        public string nameMagasin { get; set; }
        public double chinaTovara { get; set; }
        public Article(string nametovar, string namemagasin, double chinatovara)
        {
            nameTovar = nametovar;
            nameMagasin = namemagasin;
            chinaTovara = chinatovara;

        }
        public override string ToString()
        {
            return $"назва товару: {nameTovar}, магазин: {nameMagasin}, ціна: {chinaTovara}";
        }
        public static double operator + (Article obj1, Article obj2)
        {
            return obj1.chinaTovara + obj2.chinaTovara;
        }


    }

    class Store
    {
        Article [] article;
         public int Length { get;  set; }
        public Store(int length)
        {
            Length = length;
            article = new Article[Length];
        }
        public Article this[int index]
        {
            get
            {
                if (IsValid(index))
                    return article[index];
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (IsValid(index))
                    article[index] = value;
                else
                    throw new IndexOutOfRangeException();
            }
        }
        public Article FindArticle(string nametovar)
        {
            foreach (Article item in article)
            {
                if (item.nameTovar == nametovar)
                    return item; 
            }
            return null;
        }
        public Article[] SortBynameTovar()
        {
            return article.OrderBy(n => n.nameTovar).ToArray();
        }
        public Article[] SortByShop()
        {
            return article.OrderBy(n => n.nameMagasin).ToArray();
        }
        public Article[] SortByChina()
        {
            return article.OrderBy(n=>n.chinaTovara).ToArray();
        }
        private bool IsValid(int index)
        {
            return (index >= 0) && (index < Length);
        }


    }
    /*Задание 4 

        Используя Visual Studio, создайте проект по шаблону Console Application. Требуется:
        Создать класс Article, содержащий следующие закрытые поля:
        • название товара;
        • название магазина, в котором продается товар;
        • стоимость товара в гривнах. Создать класс Store, содержащий закрытый массив элементов типа Article.
            Обеспечить следующие возможности:
        • вывод информации о товаре по номеру с помощью индекса;
        • вывод на экран информации о товаре, название которого введено с клавиатуры, 
            если таких товаров нет, выдать соответствующее сообщение; Написать программу, вывода на экран информацию о товаре. */
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store(5);
            store[0] = new Article("Годинник", "Самсунг",10300);
            store[1] = new Article("Годинник", "Ксіомі",9300);
            store[2] = new Article("Годинник", "Хуавей",7300);
            store[2] = new Article("Телефон", "Самсунг",21300);
            store[2] = new Article("Телефон", "Ксіомі",14300);
            Article test = store.FindArticle("Годинник");
            if (test != null)
                Console.WriteLine(test.ToString());
            Console.WriteLine();
            Article[] test1 = store.SortByChina();
            for (int i = 0; i < test1.Length; i++)
            {
                Console.WriteLine(test1[i].ToString());
            }
            Console.WriteLine();
            Console.WriteLine(store[0] + store[1]);
            Console.ReadKey();
        }
    }
}
