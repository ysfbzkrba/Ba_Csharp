using System;

namespace WCA_Variables_core
{
    class Program
    {
        static void Main(string[] args)
        {

            // variables => stores values on RAM while in use.
            // in total there are 8 integer, 3 decimal, 2 text and 1 logical variable is available in c#

            // Değişken Tanımlama Kuralları
            {
                /*

                     *Değişkenler sayı ile başlayamaz, sayı içerir veya sayı ile bitebilir.

                     * Değişken isimleri, tanımlı kelimeler olmamalıdır.
                         string class = 'yusuf' ; // CLASS zaten tanımlı bir kelime

                     * Aynı çalışma alanında, aynı isimde tanımlama yapılamaz.

                     * Değişken tanımlaması yaparken türkçe karakter kullanılmaz. ( o an çalışır fakat ileride hata verebilir.)

                     * değişken isimleri uniqe ve anlamlı olmalıdır.

                     * değişken isimleri ayrık kelimeden oluşamaz.
                         string benim adım = "asadasd" ; // olmaz.

                     * isimlendirmede küçük büyük harf duyarlılığı vardır.

                  >> değişken tanımlama şekli
                         veriTipi değişkenAdi = değişkenDeğeri ;
                         string      adim     = "yusuf"        ;

                     *   tam sayı veri tipleri
                     *   byte, sbyte, short, ushort, int, uint, long, ulong,
                        >>   byte sayi1 = 256;
                        >>     SByte sayi2 = -128; // 127>= sbyte >= -128 
                        >>        // F12 = go to definition of type.
                        >>        //^^ yeşil çizgi kullanılmadığı için. kırmızı çizgi hata.
                        
                     *   ondalıklı sayı veri tipleri
                     *   float, double, decimal
                */
                float ondalikli1 = 1.0F;    // 32bit
                double ondalikli2 = 1.0;    // 64bit
                decimal ondalikli3 = 1.0M;  // 128bit
                /*        
                     *   metinsel veri
                     *   string, char
                */
                string metin = "takes as much as RAM can carry."; // UTF16 Code
                char karakter = 'A';    //
                /* 
                     *   mantıksal veri tipi
                     *   bool
                */
                bool result = 10 > 2;
                    // result true  => alışveriş yap
                    // result false => alışveriş yapma
                /* 
                 */

            }

            Console.WriteLine("Hello World!");
        }
    }
}
