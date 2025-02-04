using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kawkez
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] board = new int[8, 8];
            InitialiseBoard(board);
            ShowBoard(board);
        }
        private static void InitialiseBoard(int[,] board)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i < 3 && (i + j) % 2 == 1)
                    {
                        board[i, j] = 1;
                    }
                    else if (i > 4 && (i + j) % 2 == 1)
                    {
                        board[i, j] = 2;
                    }
                    else
                    {
                        board[i, j] = 0;
                    }
                }
            }
        }
        static void ShowBoard(int[,] board)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}


                
    

