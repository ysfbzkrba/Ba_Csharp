using System;

namespace WCA_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
                    //  CONVERT //
            /*
                >> byte, sbyte, short, ushort, int, uint, long, ulong
                >> float, double, decimal(=money in sql)
                >> bool
            */

         String ValueTobeConverted = "123";
         Console.Write (ValueTobeConverted);
         Console.WriteLine ("  is string data");
         Console.WriteLine ("Please wait. StringValue is being converted..");
            byte c1 = Convert.ToByte(ValueTobeConverted) ;
         Console.Write (ValueTobeConverted);
         Console.WriteLine(" is now byte data");

            sbyte c2 = Convert.ToSByte(ValueTobeConverted); //int16
         Console.Write (ValueTobeConverted);
         Console.WriteLine(" is now sbyte data");
            short c3 = Convert.ToInt16(ValueTobeConverted); //int16
         Console.Write (ValueTobeConverted);
         Console.WriteLine(" is now short data");
            int c4 = Convert.ToInt32(ValueTobeConverted);   //int32
         Console.Write (ValueTobeConverted);
         Console.WriteLine(" is now int data");
            uint c5 = Convert.ToUInt32(ValueTobeConverted); //int32
         Console.Write (ValueTobeConverted);
         Console.WriteLine(" is now uint data");
            long c6 = Convert.ToInt64(ValueTobeConverted);  //parse or int64
         Console.Write (ValueTobeConverted);
         Console.WriteLine(" is now long data");
            ulong c7 = ulong.Parse(ValueTobeConverted);     // parse or int64
         Console.Write (ValueTobeConverted);
         Console.WriteLine(" is now ulong data");
            float c21 = Convert.ToSingle (ValueTobeConverted);    // to single. single decimal value
         Console.Write (ValueTobeConverted);
         Console.WriteLine(" is now float data");
            double c22 = Convert.ToDouble(ValueTobeConverted);  // to double. 2 decimal value.
         Console.Write (ValueTobeConverted);
         Console.WriteLine(" is now double data");
            decimal c23 = Convert.ToDecimal(ValueTobeConverted);    //to decimal. decimal value
         Console.Write (ValueTobeConverted);
         Console.WriteLine(" is now decimal data");
         Console.WriteLine("Can't convert to Bool Data.");
         Console.WriteLine ("EndLine");
            // bool = ?
            // parse = disects input


            string number_input = Convert.ToString(c23);
            string number_input2 = c23.ToString(); // extention method
            
            string  char_text = "A";
            char c_char = "A";

        
        }
    }
}
