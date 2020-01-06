using System;

namespace NamuDarbas1
{
    class Program
    {
        static void Main(string[] args)
        {
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

            if (arTaiSkaicius==true)
            {
                Console.WriteLine("Valioo!");

            }
            else
            {
                Console.WriteLine("Ivestas neteisingas skaicius, bandykite is naujo");
                return;
                
            }
            
            int skaicius1 = Convert.ToInt32(skaicius);
            if (TeisingiReziai(skaicius1)==false) return;
            Console.WriteLine("Ivestas teisingas skaicius");
        }

        static bool TeisingiReziai(int skaitmuo)
        {
            if (skaitmuo > -10 && skaitmuo < 10) return true;
            else return false;
        }
    }
}
