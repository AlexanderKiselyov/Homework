using System;

namespace д.з._1_5
{
	/// matrix sort
	class Program
	{
		/// sorts elements of the matrix
		private static void MatrixBubbleSort(int[,] array)
		{
			int n = array.GetLength(0);
			int m = array.GetLength(1);
			for (int i = 0; i < m; i++)
			{
				for (int j = m - 1; j > i; j--)
				{
					if (array[0, j - 1] > array[0, j])
					{
						for (int k = 0; k < n; k++)
						{
							int current = array[k, j - 1];
							array[k, j - 1] = array[k, j];
							array[k, j] = current;
						}
					}
				}
			}
		}
		
		public static void Main (string[] args)
		{
			Console.WriteLine("Write number of string and columns:");
			int n = int.Parse(Console.ReadLine());
			int m = int.Parse(Console.ReadLine());
			int[,] array = new int[n, m];
			Console.WriteLine("Enter array of " + n * m + " elements:");
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					array[i, j] = int.Parse(Console.ReadLine());
				}
			}
			MatrixBubbleSort(array);
			Console.WriteLine("New array:");
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					Console.Write(array[i, j] + " ");
				}
			}
			Console.WriteLine();
		}
	}
}
