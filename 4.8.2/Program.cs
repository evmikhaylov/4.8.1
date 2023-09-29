using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._8._2
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
			Console.Clear();

			int[,] matrix = new int[strMatrix, columnMatrix];
			int[,] matrix2 = new int[strMatrix, columnMatrix];
			int[,] sumMatrix = new int[strMatrix, columnMatrix];
			Console.WriteLine("Первая матрица");
			for (int i = 0; i < strMatrix; i++)
			{
				for (int j = 0; j < columnMatrix; j++)
				{
					matrix[i, j] = rnd.Next(10);
					Console.Write(matrix[i, j] + " ");
				}

			}
			Console.WriteLine("\nВторая матрица");
			for (int k = 0; k<strMatrix; k++)
			{
				for (int l = 0; l<columnMatrix; l++)
				{
					matrix2[k, l] = rnd.Next(10);
					Console.Write(matrix2[k, l] + " ");
				}
			}
            Console.WriteLine("\nСумма матриц");
            for (int u = 0; u < strMatrix; u++)
			{
				for (int y = 0; y < columnMatrix; y++)
				{
					sumMatrix[u, y] = matrix[u, y]+matrix2[y, y];
					Console.Write(sumMatrix[u, y] + " ");
				}
			}
			Console.ReadLine();
		}
	}
}
