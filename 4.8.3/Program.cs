using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._8._3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			int[,] map = new int[100, 100];
			for (int i = 0; i < 100; i++)
			{
				for (int j = 0; j < 100; j++)
				{
					map[i, j] = rnd.Next(2);
					Console.Write(map[i, j]);
				}
				Console.WriteLine();
			}
			Console.ReadKey();
		}
	}
}
