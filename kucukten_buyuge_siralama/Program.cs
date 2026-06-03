using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kucukten_buyuge_siralama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] sayidizisi = new int[5];
                for (int i = 0; i <sayidizisi.Length; i++)
                {
                    Console.Write("Sıralanacak {0}. sayıyı giriniz : ", i + 1);
                    sayidizisi[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i< sayidizisi.Length-1; i++)
                {
                    for (int j = i + 1; j < sayidizisi.Length; j++)
                    {
                        if (sayidizisi[i] > sayidizisi[j])
                        {
                            int TEMP = sayidizisi[i];
                            sayidizisi[i] = sayidizisi[j];
                            sayidizisi[j] = TEMP;
                        }
                    }
                }
                string siralama = "";
                foreach ( int sayi in sayidizisi)
                {
                    siralama += Convert.ToString(sayi) + "-";
                }
                Console.WriteLine(" Girilen dizideki elemanların küçükten büyüğe sıralanışı : {0}", siralama.Trim('-'));
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("HATA : {0}", ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
