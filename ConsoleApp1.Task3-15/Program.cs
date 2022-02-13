using System;

namespace ConsoleApp1.Task3_15
{
    /* 15)* 5 dene eded daxil et. Bunlarda 2 denesi 3 reqemli. 2 denesi 6 reqemli . 1 denesi 7 reqemli olsun.
     * 3 reqemli ededlerin cemini tap ve cavabin axirdan 2 denesini kvadratini tap.
     * Sonra alinan cavabin ustune 3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededi gel.
     * Cavabdan 7 reqemli ededin son 5 reqemini cix.
     * Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel.
     * Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavabi gel.
     * Cavabin axirina 11 artir.
     * Sonra 7 reqemli ededin tek yerde dayan reqemlerinde alinan ededi cix.
     * Cavabin axirdan II reqemi ile axirinci reqemin arasina 88 elave et.*/

    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 341;
            int b = 521;
            int c = 123456;
            int d = 234567;
            int e = 1234567;

            bool isSuccess = (a >= 100 && a < 1000 && b >= 100 && b < 1000 && c >= 100000 && c < 1000000 && d >= 100000 && d < 1000000 && e >= 1000000 && e < 10000000);
            if (!isSuccess)
            {
                Console.WriteLine("3, 6, ve ya 7 reqemli deyil");
                return;
            }

            int f = a + b;
            f = f % 100;
            int p = f * f;


            a = a * 1000;
            a = a + b;

            p = p + a;

            int g = e % 100000;

            p = p - g;

            int h = c + d;
            h = h % 1000;
           
            p = p + h;

            int sum = 0;
            int mod;

            int e1 = e;

            while (e1 > 0)
            {
                mod = e1 % 10;
                e1 = e1 / 10;
                sum = sum + mod;
            }

            int mod2;
            int newNumber = 0;

            while (sum > 0)
            {
                mod2 = sum % 10;
                newNumber = newNumber * 10 + mod2;

                sum /= 10;
            }

            p = p + newNumber;

            p = p * 100;
            p = p + 11;

            Console.WriteLine(p);


            int counter = 1;
            int mod3;
            int newNumber3 = 0;

            while (e > 0)
            {
                mod3 = e % 10;
                e = e / 10;

                if (counter % 2 != 0)
                {
                    newNumber3 = newNumber3 * 10 + mod3;
                }
                counter++;
            }

            e = newNumber3;
            newNumber3 = 0;

            while (e > 0)
            {
                mod3 = e % 10;
                e = e / 10;
                newNumber3 = newNumber3 * 10 + mod3;
            }
            Console.WriteLine(newNumber3);

            int l = p - newNumber3;

            int l1 = l % 10;

            l = l / 10;
            l = (l * 100) +88;
            Console.WriteLine(l);

            /* bura qeder dogrudur, sonra sehv cavab alinir.
             * cavab menfi alinir ???????? */

            l = (l * 10) + l1;
            Console.WriteLine(l);

            
      
           



         








        }
    }
}
