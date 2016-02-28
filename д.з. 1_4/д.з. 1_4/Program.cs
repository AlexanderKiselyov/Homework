using System;

namespace д.з._1_4
{
	/// outputs elements of the matrix in a circle
    class Program
    {
    	/// outputs elements of the matrix in a circle
    	private static void CrawlingSnake(int[,] array)
    	{
    		int n = array.GetLength(0);
    		int count = 1;
    		int str = (n + 1) / 2 - 1;
    		int column = (n + 1) / 2 - 1;
    		int boundary = 1;
    		Console.WriteLine ("New array:");
    		Console.WriteLine (array[(n + 1) / 2 - 1, (n + 1) / 2 - 1]);
    		if (n != 1)
    		{
    			while (count < n * n)
    			{
    				for (int i = 0; i < boundary; i++)
    				{
    					if (count >= n * n)
    					{
    						break;
					}
					column++;
					Console.WriteLine(array[str, column]);
					count++;
				}
				for (int i = 0; i < boundary; i++)
				{
					if (count >= n * n)
					{
						break;
					}
					str++;
					Console.WriteLine(array[str, column]);
					count++;
				}
				boundary++;
				for (int i = 0; i < boundary; i++)
				{
					if (count >= n * n)
					{
						break;
					}
					column--;
					Console.WriteLine(array[str, column]);
					count++;
				}
				for (int i = 0; i < boundary; i++)
				{
					if (count >= n * n)
					{
						break;
					}
					str--;
					Console.WriteLine(array[str, column]);
					count++;
				}
				boundary++;
			}
    		}
    	}
    	
        public static void Main(string[] args)
        {
            Console.WriteLine("Write number of strings and columns:");
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[n, n];
            Console.WriteLine("Write array:");
            for (int i = 0; i < n; i++)
            {
                for (int j =0 ; j < n; j++)
                {
			array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            CrawlingSnake(array);
        }
    }
}
