using System;

class Program
{
    const int SIZE = 5;
    const int MINES = 5;
    static int[,] board = new int[SIZE, SIZE];
    static bool[,] revealed = new bool[SIZE, SIZE];
    static int moves = 0;

    static void Main()
    {
        Init();
        while (true)
        {
            PrintBoard();
            PrintMoves();
            Console.Write("Enter row and column: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Reveal(x, y);
            moves++;
        }
    }

    static void Init()
    {
        Random rand = new Random();
        for (int i = 0; i < MINES; i++)
        {
            int x = rand.Next(SIZE);
            int y = rand.Next(SIZE);
            if (board[x, y] != -1)
            {
                board[x, y] = -1;
            }
            else
            {
                i--;
            }
        }
    }

    static int CountMines(int x, int y)
    {
        int count = 0;
        for (int i = -1; i <= 1; i++)
        {
            for (int j = -1; j <= 1; j++)
            {
                if (x + i >= 0 && x + i < SIZE && y + j >= 0 && y + j < SIZE && board[x + i, y + j] == -1)
                {
                    count++;
                }
            }
        }
        return count;
    }

    static void Reveal(int x, int y)
    {
        if (x >= 0 && x < SIZE && y >= 0 && y < SIZE && !revealed[x, y])
        {
            revealed[x, y] = true;
            if (board[x, y] == -1)
            {
                Console.WriteLine("Game Over");
                Environment.Exit(0);
            }
            else
            {
                board[x, y] = CountMines(x, y);
            }
        }
    }

    static void PrintBoard()
    {
        Console.Clear();
        for (int i = 0; i < SIZE; i++)
        {
            for (int j = 0; j < SIZE; j++)
            {
                if (revealed[i, j])
                {
                    if (board[i, j] == -1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write(board[i, j] + " ");
                    }
                }
                else
                {
                    Console.Write("- ");
                }
            }
            Console.WriteLine();
        }
    }

    static void PrintMoves()
    {
        Console.WriteLine("Moves completed: " + moves);
    }
}