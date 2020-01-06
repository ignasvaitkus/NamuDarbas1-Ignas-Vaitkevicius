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
            Console.WriteLine(skaicius);
        }
    }
}
