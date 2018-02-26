using System;

class Program
{

    static void Main()
    {
        // min skaicius 
        const int FROM_NUMBER = -9;
        // max skaicius 
        const int TO_NUMBER = 9;

        string inputString = "";
        int inputNumber = 0;

        Console.Write("Sveiki!");
        while (inputString != " ")
        {
            Console.Write("\n(Enter SPACE to exit.)\nIveskite skaiciu:");
            inputString = Console.ReadLine();
            if (checkIfGoodNumber(inputString))
            {
                Console.WriteLine("Skaicius teisingas!");
                inputNumber = Convert.ToInt32(inputString);
                if (checkIfNumberInRange(FROM_NUMBER, TO_NUMBER, inputNumber))
                {
                    Console.WriteLine("Skaicius {0} zodziais: {1}", inputNumber, changeNumberToText(inputNumber));
                }
                else
                {
                    Console.WriteLine("Blogas skaicius {0}, prasau ivesti skaiciu reziuose: {1}..{2}", inputString, FROM_NUMBER, TO_NUMBER);
                }
            }
            else
            {
                Console.WriteLine("Ivesti duomenys:{0} nera skaicius!", inputString);
            }

        }

        Console.WriteLine("\nAciu uz demesi, viso gero.");
        Console.ReadKey();
    }

    // funkcija gauna int skaiciu, pakeicia ji i string teksta kuri zodziais nusako skaiciu. PVZ: -1684542 turi grazint - "minus vienas milijonas sesi simtai astuoniasdesimt keturi tukstanciai penki simtai keturiasdiasimt du"
    static string changeNumberToText(int number)
    {
        throw new Exception("TODO: grazinkite skaiciu zodziais.");
    }

    // funkcija gauna string skaiciu, patikrina ar skaicius teisingu formatu. Pvz: "123", "-123" grazina true. "12a3", "1-23" grazina false.
    static bool checkIfGoodNumber(string dataToCheck)
    {
        throw new Exception("TODO: grazinkite true, jei tekstas yra teisingas skaicius.");
    }

    // funkcija gauna true jei skaicius checkNumber yar tarp fromNumber ir toNumber (imtinai)
    private static bool checkIfNumberInRange(int fromNumber, int toNumber, int checkNumber)
    {
        throw new Exception("TODO: Patikrinkite ar checkNumber yar tarp skaiciu fromNumber,  toNumber");
    }


    //Skaiciai zodziais:  
    // "minus"; 
    // "nulis", "vienas", "du", "trys", "keturi", "penki", "sesi", "septyni", "astuoni", "devyni"; 
    // "desimt", "vienualika", "dvylika", "trylika", "keturiolika", "penkiolika", "sesiolika", "septyniolika", "astuoniolika", "devyniolika"; 
    // "dvidesimt", "trisdesimt", "keturiasdesimt", "penkiasdesimt", "sesiasdesimt", "septyniasdesimt", "astuoniasdesimt", "devyniasdesimt"; 
    // "simtas", "tukstantis", "milijonas", "milijardas"; 
    // "simtai", "tukstanciai", "milijonai", "milijardai"; 
    // "simtu", "tukstanciu", "milijonu", "milijardu"; 
}