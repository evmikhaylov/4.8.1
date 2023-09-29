using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._8._1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
            Console.WriteLine("Введите количество строк матрицы:");
			int strMatrix = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов матрицы");
			int columnMatrix = Int32.Parse(Console.ReadLine());

			int[,] matrix = new int[strMatrix, columnMatrix];
			int sumMatrix = 0;

			for (int i = 0; i < strMatrix; i++)
			{
				for (int j = 0; j < columnMatrix; j++)
				{
					matrix[i, j] = rnd.Next(10);
					Console.Write($"{matrix[i, j]} ");
					sumMatrix+=matrix[i, j];
				}
				Console.WriteLine();
            }
            Console.WriteLine($"Сумма всех членов матрицы = {sumMatrix}");
            Console.ReadLine();

        }
	}
}
