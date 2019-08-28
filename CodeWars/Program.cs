namespace Solution
{
    public class BattleshipField
    {
        public static bool ValidateBattlefield(int[,] field)
        {
            //if I find and remove bigger ship first, their parts will not be mistaken for smaller ships
            for (int shipSize = 4; shipSize > 0; shipSize--) //iterate battleship->submarine
            {
                int shipsToFind = 5 - shipSize; //smaller ship -> bigger number
                bool shouldStop = false;
                //ship must be straight line -> horizontal or diagonal search will find it
                //horizontal search
                for (int rows = 0; rows < 10; rows++) //iterate rows
                {
                    int counter = 0; //how much points in a row found
                    for (int columns = 0; columns < 10; columns++) //iterate columns
                    {
                        if (field[rows, columns] == 1)
                            counter++;
                        else
                            counter = 0;
                        if (counter == shipSize)
                        {
                            shipsToFind--;
                            counter = 0;
                            for (int i = 0; i < shipSize; i++) //remove found ship
                                field[rows, columns - i] = 0;
                            //search surrounding for touching ships
                            if (columns + 1 < 10 && field[rows, columns + 1] == 1) //found in front
                                return false;
                            if (columns - shipSize - 1 >= 0 
                                && field[rows, columns - shipSize] == 1) //found behind
                                return false;
                            for (int i = 0; i < shipSize; i++)
                            {
                                if (rows + 1 < 10 && field[rows + 1, columns - i] == 1) //found above
                                    return false;
                                if (rows - 1 >= 0 && field[rows - 1, columns - i] == 1) //found under
                                    return false;
                            }
                        }
                        if (shipsToFind == 0)
                            shouldStop = true;
                        if (shouldStop)
                            break;
                    }
                    if (shouldStop)
                        break;
                }
                //diagonal - only changed place of rows and columns variables 
                for (int rows = 0; rows < 10; rows++) //iterate rows
                {
                    int counter = 0; //how much points in a row found
                    for (int columns = 0; columns < 10; columns++) //iterate columns
                    {
                        if (field[columns, rows] == 1)
                            counter++;
                        else
                            counter = 0;
                        if (counter == shipSize)
                        {
                            shipsToFind--;
                            counter = 0;
                            for (int i = 0; i < shipSize; i++) //remove found ship
                                field[columns - i, rows] = 0;
                            //search surrounding for touching ships
                            if (columns + 1 < 10 && field[columns + 1, rows] == 1) //found in front
                                return false;
                            if (columns - shipSize - 1 >= 0
                                && field[columns - shipSize, rows] == 1) //found behind
                                return false;
                            for (int i = 0; i < shipSize; i++)
                            {
                                if (rows + 1 < 10 && field[columns - i, rows + 1] == 1) //found above
                                    return false;
                                if (rows - 1 >= 0 && field[columns - i, rows - 1] == 1) //found under
                                    return false;
                            }
                        }
                        if (shipsToFind == 0)
                        {
                            shouldStop = true;
                        }

                        if (shouldStop)
                            break;
                    }
                    if (shouldStop)
                        break;
                }
                if (shipsToFind != 0) //not enough ships of given class found
                    return false;
            }
            int sum = 0;
            foreach (int i in field)
                sum += i;
            if (sum > 0) //anything left on board
                return false;

            return true;
        }
    }
}