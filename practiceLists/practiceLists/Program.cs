using System;

class Program
{

    static void Main()
    {
        // TODO : keiskite FROM..TO skaicius pagal tai kiek spesite padaryt uzduociu. (-19...19, -99..99, ir tt.)
        // min skaicius 
        const int FROM_NUMBER = -999;
        // max skaicius 
        const int TO_NUMBER = 999;

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
                    int firstDigit = inputNumber / 10; //papildomi kintamieji suskaldyt skaiciu >20 i du skaitmenis, pagal kuriuos nustatysim kokiam pozicija
                    int lastDigits = inputNumber % 10; //papildomi kintamieji suskaldyt skaiciu >20 i du skaitmenis, pagal kuriuos nustatysim kokiam pozicija

                    if (inputNumber >= 0 && inputNumber <= 10) // nuo 0 iki 10
                    {
                        Console.WriteLine("Skaicius {0} zodziais: {1}", inputNumber, changeNumberToText(inputNumber));
                    }
                    else if (inputNumber < 0 && inputNumber >= -10)// nuo -1 iki -10
                    {
                        Console.WriteLine("Skaicius {0} zodziais: minus {1}", inputNumber, changeNumberToText(inputNumber));
                    }
                    else if (inputNumber < -10 && inputNumber > -20)// nuo -11 iki -19
                    {
                        Console.WriteLine("Skaicius {0} zodziais: minus {1}", inputNumber, changeNumberToText(inputNumber));
                    }
                    else if (inputNumber >= 20 && inputNumber < 100) // nuo 20 iki 99
                    {
                        if (lastDigits != 0) // papildoma apsauga kad ivedus pvz: 20 - nerasytu atsakymo - dvidesimt nulis
                        {
                            Console.WriteLine("Skaicius {0} zodziais: {1}", inputNumber, changeTensToText(firstDigit) + changeNumberToText(lastDigits));
                        }
                        else
                        {
                            Console.WriteLine("Skaicius {0} zodziais: {1}", inputNumber, changeTensToText(firstDigit));
                        }
                    }
                    else if (inputNumber < -19 && inputNumber > -101) // nuo -20 iki -99
                    {
                        if (lastDigits != 0)// papildoma apsauga kad ivedus pvz: -20 - nerasytu atsakymo - minus dvidesimt nulis
                        {
                            Console.WriteLine("Skaicius {0} zodziais: minus {1}", inputNumber, changeTensToText(firstDigit) + changeNumberToText(lastDigits));
                        }
                        else
                        {
                            Console.WriteLine("Skaicius {0} zodziais: minus {1}", inputNumber, changeTensToText(firstDigit));
                        }
                    }

                    else // atspausdina nuo 11 iki 19
                    {
                        Console.WriteLine("Skaicius {0} zodziais: {1}", inputNumber, changeNumberToText(inputNumber));
                    }
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

    // bendra funkcija apjungti visom funkcijom kurias jus sukursit.
    static string changeNumberToText(int number)
    {
        string changing = "";//sukuriau tuscia string, ant kurio bus rasomi rezultatai zodziu atlikus salygas ir grazinamas i funkcija virsuje 
        // TODO : pakeiskite sita funkcija pagal savo poreiki. (tiek kiek skaiciu spesite apdorot.)
        if (number > -11 && number < 11)
        {
            changing = changeOnesToText(number);
        }
        else if (number < -10 && number > -20 || number > 10 && number < 20)
        {
            changing = changeTeensToText(number);
        }
        else if (number < -19 && number > -100 || number > 19 && number < 100)
        {
            changing = changeTensToText(number);
        }
        return changing;
    }
    // funkcija gauna string skaiciu, patikrina ar skaicius teisingu formatu. Pvz: "123", "-123" grazina true. "12a3", "1-23" grazina false.
    static bool checkIfGoodNumber(string dataToCheck)
    {
        //tikrinimas3 tiesiog bool kintamasis
        bool tikrinimas3 = false;
        for (int i3 = 0; i3 < dataToCheck.Length; i3++)//sukurtas ciklas praeis pro visus irasytus simbolius iki kol pasieks zodzio gala
        {
            if (i3 == 0)
            {
                char hm3 = dataToCheck[i3];//susikuriau atskirai char ir prilyginau gautiems simboliams
                if (hm3 != 48 && hm3 != 49 && hm3 != 50 && hm3 != 51 && hm3 != 52 && hm3 != 53 && hm3 != 54 && hm3 != 55 && hm3 != 56 && hm3 != 57 && hm3 != 58)
                {     //salyga tikrina simbolius nuo 0 iki 9
                    if (hm3 == 45) // patikrina ar prieki yra minusas
                    {
                        tikrinimas3 = true;
                    }
                    else
                    {
                        tikrinimas3 = false;
                    }
                }
                else
                {
                    tikrinimas3 = true;
                }
            }
            if (i3 == 1)
            {
                char hm3 = dataToCheck[i3];
                if (hm3 != 48 && hm3 != 49 && hm3 != 50 && hm3 != 51 && hm3 != 52 && hm3 != 53 && hm3 != 54 && hm3 != 55 && hm3 != 56 && hm3 != 57 && hm3 != 58)
                {
                    tikrinimas3 = false;
                }
                else
                {
                    tikrinimas3 = true;
                }
            }
            if (i3 == 2)
            {
                char hm3 = dataToCheck[i3];
                if (hm3 != 48 && hm3 != 49 && hm3 != 50 && hm3 != 51 && hm3 != 52 && hm3 != 53 && hm3 != 54 && hm3 != 55 && hm3 != 56 && hm3 != 57 && hm3 != 58)
                {
                    tikrinimas3 = false;
                }
                else
                {
                    tikrinimas3 = true;
                }
            }
            if (i3 == 3)
            {
                char hm3 = dataToCheck[i3];
                if (hm3 != 48 && hm3 != 49 && hm3 != 50 && hm3 != 51 && hm3 != 52 && hm3 != 53 && hm3 != 54 && hm3 != 55 && hm3 != 56 && hm3 != 57 && hm3 != 58)
                {
                    tikrinimas3 = false;
                }
                else
                {
                    tikrinimas3 = true;
                }
            }
            if (i3 == 4)
            {
                char hm3 = dataToCheck[i3];
                if (hm3 != 48 && hm3 != 49 && hm3 != 50 && hm3 != 51 && hm3 != 52 && hm3 != 53 && hm3 != 54 && hm3 != 55 && hm3 != 56 && hm3 != 57 && hm3 != 58)
                {
                    tikrinimas3 = false;
                }
                else
                {
                    tikrinimas3 = true;
                }
            }
        }
        return tikrinimas3;
    }
    // funkcija gauna true jei skaicius checkNumber yar tarp fromNumber ir toNumber (imtinai)
    private static bool checkIfNumberInRange(int fromNumber, int toNumber, int checkNumber)
    {
        bool tikrinimas = false;
        if (checkNumber >= fromNumber && checkNumber <= toNumber)
        {
            tikrinimas = true;
        }
        else
        {
            tikrinimas = false;
        }
        return tikrinimas;

    }
    // funkcija gauna int skaiciu, pakeicia ji i string teksta kuri zodziais nusako skaiciu. PVZ: -1684542 turi grazint - "minus vienas milijonas sesi simtai astuoniasdesimt keturi tukstanciai penki simtai keturiasdiasimt du"
    static string changeOnesToText(int number)
    {
        string changeOnesToText = "";
        if (number == -1 || number == 1)
        {
            changeOnesToText = "vienas";
        }
        if (number == -2 || number == 2)
        {
            changeOnesToText = "du";
        }
        if (number == -3 || number == 3)
        {
            changeOnesToText = "trys";
        }
        if (number == -4 || number == 4)
        {
            changeOnesToText = "keturi";
        }
        if (number == -5 || number == 5)
        {
            changeOnesToText = "penki";
        }
        if (number == -6 || number == 6)
        {
            changeOnesToText = "sesi";
        }
        if (number == -7 || number == 7)
        {
            changeOnesToText = "septyni";
        }
        if (number == -8 || number == 8)
        {
            changeOnesToText = "astuoni";
        }
        if (number == -9 || number == 9)
        {
            changeOnesToText = "devyni";
        }
        if (number == -10 || number == 10)
        {
            changeOnesToText = "desimt";
        }
        if (number == 0)
        {
            changeOnesToText = "nulis";
        }
        return changeOnesToText;
    }

    static string changeTeensToText(int number)
    {
        string changeTeensToText = "";
        if (number == -11 || number == 11)
        {
            changeTeensToText = "vienuolika";
        }
        if (number == -12 || number == 12)
        {
            changeTeensToText = "dvylika";
        }
        if (number == -13 || number == 13)
        {
            changeTeensToText = "trylika";
        }
        if (number == -14 || number == 14)
        {
            changeTeensToText = "keturiolika";
        }
        if (number == -15 || number == 15)
        {
            changeTeensToText = "penkiolika";
        }
        if (number == -16 || number == 16)
        {
            changeTeensToText = "sesiolika";
        }
        if (number == -17 || number == 17)
        {
            changeTeensToText = "septyniolika";
        }
        if (number == -18 || number == 18)
        {
            changeTeensToText = "astuoniolika";
        }
        if (number == -19 || number == 19)
        {
            changeTeensToText = "devyniolika";
        }
        return changeTeensToText;
    }

    static string changeTensToText(int number)
    {
        string changeTensToText = "";
        if (number == -2 || number == 2)
        {
            changeTensToText = "dvidesimt ";
        }
        if (number == -3 || number == 3)
        {
            changeTensToText = "trisdesimt ";
        }
        if (number == -4 || number == 4)
        {
            changeTensToText = "keturiasdesimt ";
        }
        if (number == -5 || number == 5)
        {
            changeTensToText = "penkiasdesimt ";
        }
        if (number == -6 || number == 6)
        {
            changeTensToText = "sesiasdesimt ";
        }
        if (number == -7 || number == 7)
        {
            changeTensToText = "septyniasdesimt ";
        }
        if (number == -8 || number == 8)
        {
            changeTensToText = "astuoniasdesimt ";
        }
        if (number == -9 || number == 9)
        {
            changeTensToText = "devyniasdesimt ";
        }

        return changeTensToText;
    }



    // TODO : sukurti funkcija kuri grazina skaiciu -999...999 zodziais - changeHundredsToText

    // TODO : sukurti funkcija kuri grazina skaiciu -9999...9999 zodziais - changeThousandsToText

    // TODO : sukurti funkcija kuri grazina skaiciu -9999999...9999999 zodziais - changeMillionsToText

    // TODO : sukurti funkcija kuri grazina skaiciu -9999999999...9999999999 zodziais - changeBilllionsToText



    //Skaiciai zodziais:  
    // "minus"; 
    // "nulis", "vienas", "du", "trys", "keturi", "penki", "sesi", "septyni", "astuoni", "devyni"; 
    // "desimt", "vienualika", "dvylika", "trylika", "keturiolika", "penkiolika", "sesiolika", "septyniolika", "astuoniolika", "devyniolika"; 
    // "dvidesimt", "trisdesimt", "keturiasdesimt", "penkiasdesimt", "sesiasdesimt", "septyniasdesimt", "astuoniasdesimt", "devyniasdesimt"; 
    // "simtas", "tukstantis", "milijonas", "milijardas"; 
    // "simtai", "tukstanciai", "milijonai", "milijardai"; 
    // "simtu", "tukstanciu", "milijonu", "milijardu"; 
}