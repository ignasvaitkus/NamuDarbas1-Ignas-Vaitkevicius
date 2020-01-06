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

            Console.WriteLine(VienzenkliaiSkaiciai(skaicius1));

        }

        static bool TeisingiReziai(int skaitmuo)
        {
            if (skaitmuo > -10 && skaitmuo < 10) return true;
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
    }
}
