using System;

class Program
{

    static void Main()
    {
        string inputString = "";
        int inputNumber = 0;

        inputString = Console.ReadLine();
        inputNumber = Convert.ToInt32(inputString);

        Console.WriteLine("Skaicius {0} zodziais: {1}", inputNumber, changeNumberToText(inputNumber));

        Console.WriteLine("\nAciu uz demesi, viso gero.");
        Console.ReadKey();

            // bendra funkcija apjungti visom funkcijom kurias jus sukursit.

            // TODO : sukurti funkcija kuri grazina skaiciu -19...19 zodziais - changeTeensToText

            // TODO : sukurti funkcija kuri grazina skaiciu -99...99 zodziais - changeTensToText

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
    static string changeNumberToText(int _i)
    {
        int i;

        string[] sk = new string[20];
        sk[0] = "nulis";
        sk[1] = "vienas";
        sk[2] = "du";
        sk[3] = "trys";
        sk[4] = "keturi";
        sk[5] = "penki";
        sk[6] = "sesi";
        sk[7] = "septyni";
        sk[8] = "aštuoni";
        sk[9] = "devyni";
        sk[10] = "dešimt";
        string[] skniol = new string[11];
        skniol[0] = "dešimt";
        skniol[1] = "vienuolika";
        skniol[2] = "dvylika";
        skniol[3] = "trylika";
        skniol[4] = "keturiolika";
        skniol[5] = "penkiolika";
        skniol[6] = "šešiolika";
        skniol[7] = "septyniolika";
        skniol[8] = "aštuoniolika";
        skniol[9] = "devyniolika";
        string[] skdes = new string[10];
        skdes[2] = "dvi";
        skdes[3] = "tris";
        skdes[4] = "keturias";
        skdes[5] = "penkias";
        skdes[6] = "šešias";
        skdes[7] = "septynias";
        skdes[8] = "aštuonias";
        skdes[9] = "devynias";
        string[] skt = new string[10];
        skt[1] = "dešimt";
        skt[2] = "šimtas";
        skt[3] = "tūkstantis";
        string[] skt2 = new string[10];
        skt2[2] = "šimtai";
        skt2[3] = "tūkstančiai";

        //_i = 9910;
        string s = Convert.ToString(_i);
        string zodziais = "";
        int ilgis = Convert.ToInt32(s.Length.ToString());
        int skaiciukas = 0;
        bool daug = true;

        // 0 - 9
        if (ilgis <= 1)
        {
            return sk[_i];
        }
        // 10 - 19
        if ((ilgis <= 2) && (_i < 19))
        {
            return skniol[Convert.ToInt32(s.Substring(1, 1))];
        }
        // 215 - ilgis 3, tikrinti 2-3 del niolikos
        for (i = 1; i <= ilgis; i++)
        {
            skaiciukas = Convert.ToInt32(s.Substring(i - 1, 1));
            if (skaiciukas == 1)
            {
                daug = false;
            }
            else
            {
                daug = true;
            }

            if (i + 1 == ilgis) // desimtys
            {
                if (skaiciukas == 0)
                {
                    // nieko nedarau
                }
                if (skaiciukas == 1) // niolika
                {
                    //Console.WriteLine(Convert.ToInt32(s.Substring(ilgis-1, 1)));
                    zodziais = zodziais + skniol[Convert.ToInt32(s.Substring(ilgis - 1, 1))];
                    return zodziais;
                }
                else
                if (skaiciukas > 1)
                {
                    //Console.WriteLine(skdes[skaiciukas]);
                    if ((_i % 10) == 0)
                    {
                        return zodziais + skdes[skaiciukas] + sk[10];
                    }
                    else
                    {
                        zodziais = zodziais + skdes[skaiciukas] + sk[10] + " ";

                    }

                }
                //zodziais = zodziais + sk[Convert.ToInt32(s.Substring(i - 1, 1))];
            }
            else
            {
                if (daug == true)
                {
                    zodziais = zodziais + sk[skaiciukas] + " " + skt2[ilgis - i] + " "; // desimtys
                }
                else
                {
                    zodziais = zodziais + sk[skaiciukas] + " " + skt[ilgis - i] + " "; // desimtys

                }

            }
        }

        //zodziais = zodziais + sk[Convert.ToInt32(s.Substring(i - 1, 1))];
        return zodziais;
    }

}
