using System;

namespace WCA_arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                /*
            string s1 = "100";
           string s2 = "20" ;
           Console.WriteLine(s1+s2);
            // + is used to attach strings one after another. 

            int c1 = Convert.ToInt32(s1);
            int c2 = Convert.ToInt32(s2);

            Console.WriteLine("Sum of Values : "+ c1 + c2); //  Sum of values : 10020 // attaches all values together because there is a string value.
            Console.WriteLine("Sum of Values : "+ (c1 + c2)); //  Sum of values : 120 // calculates sum for it is enclosed between parantesees.
                */
            }
                // 1) (x+y) % (x-y) 
            {
                /*
                Console.WriteLine ("enter x");
            string inputx = Console.ReadLine();
            int x = Convert.ToInt32(inputx);
                Console.WriteLine ("enter y");
            string inputy = Console.ReadLine();
            int y = Convert.ToInt32(inputy);
            Console.WriteLine("mod of x+y to x-y = "+((x+y)%(x-y)));
            // 1) (x+y) % (x-y)    
                */
            }
                //2) ((x-10+20)%2)^2
            {
                 /*           
                Console.WriteLine ("enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            int Fa = (a-10+20) %2 ;
            Console.WriteLine("F(a) = "+(Fa*Fa));
                */
            }
                // 3) graduation calc vise = 30% final = 70%
            {
             /*
                Console.WriteLine("Enter Vise score.");
                double v = Convert.ToDouble(Console.ReadLine());
                double vp = v*0.3;
                Console.WriteLine("Enter Final score.");
                double f = Convert.ToDouble(Console.ReadLine());
                double fp= f*0.7;
                double gs = fp+vp ;
                Console.WriteLine("Your graduation score is "+gs);
             */   
            }
                // 4) mail generator. name.surname@hotmail.com
            {
            
                Console.WriteLine("please enter your name:");
                Console.WriteLine("");
                Console.Write("     ");
                string name = Console.ReadLine().ToLower();
                name = name.Trim();
                name = name.Replace(' ', '_');
                Console.WriteLine("please enter your last name:");
                Console.WriteLine("");
                Console.Write("     ");                
                string surname = Console.ReadLine().ToLower();
                surname = surname.Trim();
                surname = surname.Replace(' ', '_');
                //string mail = name+"."+surname+"@hotmail.com";
                string mail = string.Format("{0}.{1}@hotmail.com", name,surname);
                mail = mail.Replace('ı', 'i').Replace('ö','o').Replace('ş','s').Replace('ğ','g').Replace('ç','c').Replace('ü','u').Replace(" ","");
           
                Console.WriteLine("");
                Console.WriteLine("your mail address is "+mail);
            
            }
                // 5) (b^2+c^2) - (b^2-c^2)
            {
                /*
                Console.WriteLine("enter b");
                int b= Convert.ToInt32(Console.ReadLine());
                int b2 = b*b;
                Console.WriteLine("enter b");
                int c= Convert.ToInt32(Console.ReadLine());
                int c2 = c*c;
                int f = (b2+c2) - (b2-c2);
                Console.WriteLine(f);
                */
            }
        }
    }
}
