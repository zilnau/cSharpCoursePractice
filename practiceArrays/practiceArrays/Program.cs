using System;


class Program
{
    static void Main()
    {
        findMagicNumber();
        //printMineSweeperNumbers();


        string[,] names;

        int[][] scores;

         = 8;

        Console.WriteLine(scores[0][2]);

        int[] numbers = new int[] { 12, 98, -12, 65, 12 };
        foreach (int item in numbers)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    private static void findMagicNumber()
    {
        throw new NotImplementedException("TODO: Suraskite magiška 6 skaitmenų skaičių (naudodami masyvus)!");
    }

    private static void printMineSweeperNumbers()
    {
        throw new NotImplementedException("TODO: Sukurkite programą kuri liepia vartotojui įvesti MineSweeper žaidimo lauko duomenis. " +
            "Tada paskaičiuoja ir išspausdina lentelę su skaičiais kiek aplinkui(8 kryptyse įskaitant įstrižai) yra minų.");
    }
}

