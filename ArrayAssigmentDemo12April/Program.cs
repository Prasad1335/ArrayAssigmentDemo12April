//Demo Assigment salim 12 April 2022





for (int row = 0; row < 5; row++)
{
    for (int column = 0; column < 5; column++)
    {
        if (((column == 0 || column == 4) && (row > 3 || row < 1)) || row == column || (column == 1 && row == 3) || column == 3 && row == 1)
            Console.Write("*\t");
        else
            Console.Write("\t");
    }
    Console.Write("\n");
}


