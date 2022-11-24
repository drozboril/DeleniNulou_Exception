using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dělení_nulou_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte první číslo");
            int cislo = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte druhé číslo");
            int cislo1 = int.Parse(Console.ReadLine());
            try
            {
                int vysledek = cislo / cislo1;
                Console.WriteLine("Výsledek dělení je: {0}", vysledek);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Dělení nulou\n" + e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Chyba programu\n" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Děkujeme za použití programu");
            }
            Console.ReadKey();
        }
    }
}