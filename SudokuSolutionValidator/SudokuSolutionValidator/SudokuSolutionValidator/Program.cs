public class Sudoku
{
    public static bool ValidateSolution(int[][] board)
    {
        //first dimensions check
        for (int i = 0; i < 9; i++)
        {
            int sum = 0;
            for (int j = 0; j < 9; j++)
                sum += board[i][j];
            if (sum != 45)
                return false;
        }
        //second dimensions check
        for (int i = 0; i < 9; i++)
        {
            int sum = 0;
            for (int j = 0; j < 9; j++)
                sum += board[j][i];
            if (sum != 45)
                return false;
        }
        //check 9 squares
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                int sum = 0;
                for (int k = 0; k < 3; k++)
                    for (int l = 0; l < 3; l++)
                    {
                        sum += board[k + 3 * i][l + 3 * j];
                    }
                if (sum != 45)
                    return false;
            }
        }
        return true;
    }
}