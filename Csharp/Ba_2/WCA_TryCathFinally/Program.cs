using System;

namespace WCA_TryCathFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            // FailSafe // try :: catch
            {
            /*
                // try is used when there is high risk for errors.
                try 
                    {
                    Console.WriteLine("please enter your phone.");
                    int phone_number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("phone number: {0}", phone_number);
                    }
                    // CATCH works when TRY code fails.
                    catch 
                    {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please Check the number you entered.");
                    Console.ResetColor();
                    }
            */
            }
            // FailSafe and System Error Message // try :: catch (exception, name)
            {
             /* 
                try
                {
                    Console.WriteLine("please enter your phone.");
                    int phone_number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("phone number: {0}", phone_number);
                }
             //  catch (exception (exception_name))
                    catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please Check the number you entered.");
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }

             */
            }
            // FailSafe and System Error Message with FinalWord // try :: catch (exception, name):: finally
            {
                /*
                try
                {
                    Console.WriteLine("please enter your phone.");
                    int phone_number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("phone number: {0}", phone_number);
                 // DbConnection Open()
                 // CRUD  :: anything can happen ie; electricity out, connection lost, server sutdown...
                 // DbConnection Close()
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please Check the number you entered.");
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
                    // finally = runs whether code fails or not
                finally 
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("this code runs either way.");
                    Console.ResetColor();
                }
                */
            }
            //  EXTRA :)
            {
            //
                try
                {
                    Console.WriteLine("please enter your phone.");
                    int phone_number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("phone number: {0}", phone_number);
                 // DbConnection Open()
                 // CRUD  :: anything can happen ie; electricity out, connection lost, server sutdown...
                 // DbConnection Close()
                }
                // too many numbers
                catch (OverflowException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have entered too many numbers please check your phone number.");
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
                // non numerical input
                catch (FormatException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Phone number has to be numerical only.");
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
                //else runs this code. this is general error message. has to be at the end.
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please Check the number you entered.");
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }

            //
            }
        }
    }
}
