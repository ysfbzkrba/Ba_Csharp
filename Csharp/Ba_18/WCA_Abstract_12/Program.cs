using System;
using System.Collections;
using System.Reflection;
using WCA_Abstract_12.Models;

namespace WCA_Abstract_12
{
    class Program
    {
        static void WriteToConsole(string key, string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(key.PadRight(10) + ":");
            Console.ResetColor();
            Console.WriteLine(value);
        }

        static void Main(string[] args)
        {
            //      you shouldn't be able to instance Enstruman()   \\
            //  Enstruman enst = new Enstruman();                   \\
            //  enst.Aciklama = "asd";                              \\
            //  enst.Fiyat = 12;                                    \\
            //  enst.Marka = "asd";                                 \\
            //  enst.Hammadde = Hammadde.Agac;                      \\
            //      therefore it is abstract.                       \\


            #region Bateri
            Bateri bateri = new Bateri();
            bateri.Marka = "yamaha";
            bateri.Aciklama = "Yamaha DTx225K Dijital Davul Seti";
            bateri.Deri = "Plastik";
            bateri.Model = "DTx522K";
            bateri.Fiyat = 6.998M;
            bateri.Hammadde = Hammadde.Plastik;

            Muzisyen baterist = new Muzisyen();
            baterist.Name = "hamza";
            baterist.Soyadi = "Baterisoy";
            baterist.Enstruman = bateri;
            #endregion
            // noob way

            #region Keman
            Muzisyen kemanci = new Muzisyen();
            kemanci.Name = "hamza";
            kemanci.Soyadi = "Kemansoy";
            kemanci.Enstruman = new Keman()
            {
                Marka = "Yamaha",
                Model = "YVS 104 R Elektro Keman",
                Fiyat = 6.000M,
                Hammadde = Hammadde.Agac,
                Tel = "Daddario H31044Mb10",
                Arse = "Valencia Vab300 Viyola Yayı Arse",
                Aciklama = "Yamaha Elektro Keman"
            };
            #endregion
            //object initialize way

            #region Gitar/ProWay
            Muzisyen gitarist = new Muzisyen
            {
                Name = "Hamza",
                Soyadi = "Gitarsoy",
                Enstruman = new Gitar
                {
                    Marka = "Yamaha",
                    Model = "VST 2000 YC",
                    Fiyat = 7.000M,
                    Aciklama = "Çok Pahalı",
                    Tel = "Pirastro Olive Gitar Teli",
                    Hammadde = Hammadde.Agac,
                    Pena =  "Plastik"
                }
            };

            #endregion
            //object in object init way

            #region Piyanist
            Piyano piyano = new Piyano
            {
                Marka = "Yamaha",
                Fiyat = 45.000M,
                Hammadde = Hammadde.Agac,
                Model = "YMH1005",
                Aciklama = "Efso",
                TusTakimi = "ABANOZ",
                Tel = "Çelik piyano tel takımı"
            };
            Muzisyen piyanist = new Muzisyen
            {
                Name = "Hamza",
                Soyadi = "Say",
                Enstruman = piyano
            };
            #endregion
            //object init + object init 

            ArrayList muzisyenler = new ArrayList();

            muzisyenler.Add(baterist);
            muzisyenler.Add(kemanci);
            muzisyenler.Add(gitarist);
            muzisyenler.Add(piyanist);

            foreach (Muzisyen muzisyen in muzisyenler) // foreachloop to get each muzisyen
            {
                foreach  (PropertyInfo property in muzisyen.GetType().GetProperties()) // foreachloop to get properties of each muzisyen
                {
                    if (property.Name == "Enstruman") //if property is Enstruman 
                    {
                        object enstruman = property.GetValue(muzisyen);
                        Console.WriteLine($"\n{enstruman.GetType().Name}"); //write enstruman name in console default color

                        foreach (PropertyInfo propertyInfo in enstruman.GetType().GetProperties())
                        {
                            WriteToConsole(propertyInfo.Name, propertyInfo.GetValue(enstruman).ToString());

                            //Console.ForegroundColor = ConsoleColor.Green;
                            //Console.Write(propertyInfo.Name.PadRight(10) + ":");
                            //Console.ResetColor();
                            //Console.WriteLine(propertyInfo.GetValue(enstruman));
                        }

                        var function = enstruman.GetType().GetMethod("Sound"); // get sound method under enstruman class
                        //Console.ForegroundColor = ConsoleColor.Green;
                        //Console.Write(property.Name.PadRight(10) + ":");
                        //Console.ResetColor();
                        //Console.WriteLine(function.Invoke(enstruman,null));
                        WriteToConsole(property.Name, function.Invoke(enstruman, null).ToString());

                    }
                    else // if property is not enstruman
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(property.Name.PadRight(10) + ":");
                        Console.ResetColor();
                        Console.WriteLine(property.GetValue(muzisyen));
                    }
                }
                Console.WriteLine(new string('-', 55));
            }

        }
    }
}
