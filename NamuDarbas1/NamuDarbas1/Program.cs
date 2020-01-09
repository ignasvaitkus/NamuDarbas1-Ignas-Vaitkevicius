using System;

namespace NamuDarbas1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu nuo -99 iki 99 ");
            string skaicius = Console.ReadLine();
            bool arTaiSkaicius = false;
            int x = 0;

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
            if (TeisingiReziai(skaicius1) == false)
            { Console.WriteLine("Neteisingi reziai!"); return; }

            if(skaicius1>-10 && skaicius1<0) Console.WriteLine("Minus "+VienzenkliaiSkaiciai(skaicius1,x));
            else if (skaicius1>0 && skaicius1<10) Console.WriteLine(VienzenkliaiSkaiciai(skaicius1,x));
            else if (skaicius1>-20 && skaicius1<20) Console.WriteLine(DvizenkliaiSkaiciai(skaicius1,x));
            else Console.WriteLine(DvizenkliaiSkaiciai(skaicius1,x) + " " + VienzenkliaiSkaiciai(skaicius1,x));

        }

        static bool TeisingiReziai(int skaitmuo)
        {
            if (skaitmuo > -100 && skaitmuo < 100) return true;
            else return false;
        }

        static string VienzenkliaiSkaiciai(int skaitmuo, int x)
        {
            string word="";
            string zodis = "";
            if (x == 1) return "";
            if (skaitmuo > -100 && skaitmuo < -19 && skaitmuo > 19 && skaitmuo < 100) skaitmuo = skaitmuo % 10;
            

            if (skaitmuo < 0)
            { skaitmuo = skaitmuo * -1;
                }
                
                switch (skaitmuo)
            {
                    case 1:  zodis="vienas";  break;
                    case 2:  zodis="du";    break;
                    case 3:  zodis="trys";    break;
                    case 4:  zodis="keturi";  break;
                    case 5:  zodis="penki";   break;
                    case 6:  zodis="sesi";    break;
                    case 7:  zodis="septyni"; break;
                    case 8:  zodis="astuoni"; break;
                    case 9:  zodis="devyni";  break;
                    case 0:  zodis="nulis";   break;

            }

            return zodis;
        }

        static string DvizenkliaiSkaiciai(int skaitmuo,int x)
        {
            string word = "";
            string zodis = "";
            x++;

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
