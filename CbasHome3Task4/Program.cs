using System;

namespace CbasHome3Task4
{
    /*Задание 3 

        Используя Visual Studio, создайте проект по шаблону Console Application. Требуется:
    Создать класс MyMatrix, обеспечивающий представление матрицы произвольного размера с 
    возможностью изменения числа строк и столбцов. Написать программу, которая выводит на 
    экран матрицу и производные от нее матрицы разных порядков. */

    internal class Program
    {
        static void Main(string[] args)
        {
            MyMatrix myMatrix = new MyMatrix(3, 3);
            myMatrix.Zapolnenia();
            myMatrix.Vuvod();

            Console.WriteLine();
            Console.WriteLine(myMatrix[3,0]);
            Console.WriteLine(myMatrix[0,3]);

            myMatrix[0, 0] = 500;
            myMatrix.Vuvod();

            Console.ReadKey();
        }
    }
    class MyMatrix
    {
        int[,] matrix;
        Random rand = new Random();

        public MyMatrix (int x, int y)
        {
            matrix = new int[x,y];
        }
        public void Zapolnenia()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = rand.Next(0,10);
                }
            }
        }
        public void Vuvod()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                   Console.Write(matrix[i,j]+"  ");
                }
                Console.WriteLine();
            }
        }
        public int this[int x,int y]
        {
            get
            {
                if (x <= 0 && x< matrix.GetLength(0))
                {
                    if (y <= 0 && y < matrix.GetLength(1))
                    {
                        return matrix[x, y];
                    }
                  
                }
                return -1;
            }
            set 
            {
                if (x <= 0 && x < matrix.GetLength(0))
                {
                    if (y <= 0 && y < matrix.GetLength(1))
                    {
                        matrix[x, y]=value;
                        return;
                    }

                }
                Console.WriteLine("Ви вийшли за границі масиву");
            }
        }


    }

}



