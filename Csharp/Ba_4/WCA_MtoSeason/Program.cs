using System;

namespace WCA_MtoSeason
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a month:");

            string month = Console.ReadLine().ToLower().Replace("ı","i").Replace("ü", "u").Replace("ğ", "g").Replace("ş", "s");
            string answer = month switch
            {
                string _month when _month == "aralik" || _month  == "ocak" || _month == "şubat" => "kış", // case
                string _month when _month == "mart" || _month == "nisan" || _month == "mayis" => "ilkbahar", // case
                string _month when _month == "haziran" || _month == "temmuz" || _month == "agustos" => "yaz", // case
                string _month when _month == "eylul" || _month == "ekim" || _month == "kasim" => "sonbahar", // case

                _ => "can't decide." // default

            };
            #region
            //string answer = "";
            //switch (month)
            //{
            //    case "aralık":
            //    case "ocak":
            //    case "şubat":
            //        answer = "Kış";
            //        break;
            //    case "mart":
            //    case "nisan":
            //    case "mayıs":
            //        answer = "ilkbahar";
            //        break;
            //    case "haziran":
            //    case "temmuz":
            //    case "ağustos":
            //        answer = "yaz";
            //        break;
            //    case "eylül":
            //    case "ekim":
            //    case "kasım":
            //        answer = "sonbahar";
            //        break;
            //    default:
            //        answer = "unexpected season name.";
            //        break;
            //}
            #endregion
            Console.WriteLine(answer);
        }
    }
}
