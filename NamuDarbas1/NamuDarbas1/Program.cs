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
                
                if (simbolis <= 0 || simbolis > 0) arTaiSkaicius = true;
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

                
            }

        }
    }
}
