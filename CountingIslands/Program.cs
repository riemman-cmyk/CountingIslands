namespace CountIslands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] grid = new int[Random.Shared.Next(10, 20), Random.Shared.Next(10, 20)];

            GenerateIslands(grid);
            PrintIslands(grid);
            Num_Of_Islands(grid);
            Console.WriteLine("misia shesrulebulia:))");
        }
        static void PrintIslands(int[,] grid)
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }

                    Console.Write($"{grid[i, j]} ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
        static void GenerateIslands(int[,] grid)
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j] = Random.Shared.Next(10) > 7 ? 1 : 0;
                }
            }
        }
        static void Num_Of_Islands(int[,] grid)
        {
            int row = grid.GetLength(0);
            int col = grid.GetLength(1);
            int num = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        num++;
                        Seach_For_Islands(grid, i, j);
                    }
                }
            }
            Console.WriteLine($"we have: {num} islands");
        }
        static void Seach_For_Islands(int[,] grid, int i, int j)
        {
            int row = grid.GetLength(0);
            int col = grid.GetLength(1);


            if (i < 0 || j < 0 || i >= row || j >= col || grid[i, j] != 1)
            {
                return;
            }
            grid[i, j] = 2;


            Seach_For_Islands(grid, j - 1, j);
            Seach_For_Islands(grid, i + 1, j);
            Seach_For_Islands(grid, i, j - 1);
            Seach_For_Islands(grid, i, j + 1);
            Seach_For_Islands(grid, i - 1, j - 1);
            Seach_For_Islands(grid, i - 1, j + 1);
            Seach_For_Islands(grid, i + 1, j - 1);
            Seach_For_Islands(grid, i + 1, j + 1);
        }
    }
}