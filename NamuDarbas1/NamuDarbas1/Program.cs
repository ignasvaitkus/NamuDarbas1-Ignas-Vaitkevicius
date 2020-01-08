using System;

namespace NamuDarbas1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu nuo -9 iki 9 ");
            string skaicius = Console.ReadLine();
            bool arTaiSkaicius = false;
            
            for (int i = 0; i < skaicius.Length; i++)
            {
                
                char simbolis = skaicius[i];
                if (simbolis == '-') continue;
                if (char.IsDigit(simbolis)) arTaiSkaicius = true;
                else
                {
                    arTaiSkaicius = false;
                    break;
                }

            }

            if (arTaiSkaicius == false)
            {
                Console.WriteLine("Ivestas neteisingas skaicius, bandykite is naujo");
                return;
            }   
            
            
            int skaicius1 = Convert.ToInt32(skaicius);
            if (TeisingiReziai(skaicius1)==false) return;

            if(skaicius1>-10 && skaicius1<10) Console.WriteLine(VienzenkliaiSkaiciai(skaicius1));
            else if (skaicius1>-20 && skaicius1<20) Console.WriteLine(VienzenkliaiSkaiciai(skaicius1));
            else Console.WriteLine(DvizenkliaiSkaiciai(skaicius1) + " " + VienzenkliaiSkaiciai(skaicius1));

        }

        static bool TeisingiReziai(int skaitmuo)
        {
            if (skaitmuo > -20 && skaitmuo < 20) return true;
            else return false;
        }

        static string VienzenkliaiSkaiciai(int skaitmuo)
        {
            string word="";
            string zodis = "";


            if (skaitmuo < 0)
            { skaitmuo = skaitmuo * -1;
                zodis = "minus "; }
                
                switch (skaitmuo)
            {
                    case 1:  zodis=zodis+"vienas";  break;
                    case 2:  zodis=zodis+"du";    break;
                    case 3:  zodis=zodis+"trys";    break;
                    case 4:  zodis=zodis+"keturi";  break;
                    case 5:  zodis=zodis+"penki";   break;
                    case 6:  zodis=zodis+"sesi";    break;
                    case 7:  zodis=zodis+"septyni"; break;
                    case 8:  zodis=zodis+"astuoni"; break;
                    case 9:  zodis=zodis+"devyni";  break;
                    case 0:  zodis=zodis+"nulis";   break;

            }

            return zodis;
        }

        static string DvizenkliaiSkaiciai(int skaitmuo)
        {
            string word = "";
            string zodis = "";


            if (skaitmuo < 0)
            {
                skaitmuo = skaitmuo * -1;
                zodis = "minus ";
            }
            if (skaitmuo > 9 && skaitmuo < 20)
            {
                switch (skaitmuo)
                {
                    case 10: zodis = zodis + "desimt"; break;
                    case 11: zodis = zodis + "vienuolika"; break;
                    case 12: zodis = zodis + "dvylika"; break;
                    case 13: zodis = zodis + "trylika"; break;
                    case 14: zodis = zodis + "keturiolika"; break;
                    case 15: zodis = zodis + "penkiolika"; break;
                    case 16: zodis = zodis + "sesiolika"; break;
                    case 17: zodis = zodis + "septyniolika"; break;
                    case 18: zodis = zodis + "astuoniolika"; break;
                    case 19: zodis = zodis + "devyniolika"; break;
                }
            }
            else
            {
                skaitmuo = skaitmuo / 10;

                switch (skaitmuo)
                {
                    
                    case 2: zodis = zodis + "dvidesimt"; break;
                    case 3: zodis = zodis + "trisdesimt"; break;
                    case 4: zodis = zodis + "keturiasdesimt"; break;
                    case 5: zodis = zodis + "penkiasdesimt"; break;
                    case 6: zodis = zodis + "sesiasdesimt"; break;
                    case 7: zodis = zodis + "septyniasdesimt"; break;
                    case 8: zodis = zodis + "astuoni"; break;
                    case 9: zodis = zodis + "devyniasdesimt"; break;
                    

                }
            }
            return zodis;

        }
    }
}
