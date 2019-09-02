using System;

class Sudoku
{
    int[][] board;
    int n;
    public Sudoku(int[][] sudokuData)
    {
        this.board = sudokuData;
        n = sudokuData.Length;
    }

    public bool IsValid()
    {
        //n > 0
        if (n <= 0)
            return false;
        //sqrt(n) == int
        int sqrtN = 0;
        try{
            sqrtN = int.Parse(Math.Sqrt(n) + "");
        } catch(Exception){
            return false;
        }
        //all arrays same size
        foreach (int[] i in board)
            if (i.Length != n)
                return false;
        int rightSum = n % 2 == 0 ? (n + 1) * (n / 2) : (n + 1) * (n / 2) + (n + 1) / 2;
        //first dimensions check
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = 0; j < n; j++)
                sum += board[i][j];
            if (sum != rightSum)
                return false;
        }
        //second dimensions check
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = 0; j < n; j++)
                sum += board[j][i];
            if (sum != rightSum)
                return false;
        }
        //check squares
        for (int i = 0; i < sqrtN; i++)
        {
            for (int j = 0; j < sqrtN; j++)
            {
                int sum = 0;
                for (int k = 0; k < sqrtN; k++)
                    for (int l = 0; l < sqrtN; l++)
                    {
                        sum += board[k + sqrtN * i][l + sqrtN * j];
                    }
                if (sum != rightSum)
                    return false;
            }
        }
        return true;
    }
}