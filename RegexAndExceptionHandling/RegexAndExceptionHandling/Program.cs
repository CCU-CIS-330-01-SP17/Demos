using System;
using System.Text.RegularExpressions;

namespace RegexAndExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Regex.Match("color", @"colou?r").Success);

            Console.WriteLine(Regex.Match("say 25 miles more", @"\d+(?=\smiles)"));

            Console.WriteLine(Regex.Match("say 25 miles more", @"(?<=say\s)\d+"));

            //AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            //Console.WriteLine(ExceptionHandlingDemo());
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine("**** My Custom Unhandled Exception Handler *****: {0}", e.ExceptionObject.ToString());
        }

        private static int? ExceptionHandlingDemo()
        {
            string x = "4";
            string y = "2";

            try
            {
                return DivideStringValues(x, y);
            }
            catch (ArgumentNullOrWhitespaceException ex)
            {
                Console.WriteLine("{0}: {1}", ex.GetType().Name, ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("{0}: {1}", ex.GetType().Name, ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("{0}: {1}", ex.GetType().Name, ex.Message);
                //return -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("*** WARNING: Fallback Handler Used ***: {0}: {1}", ex.GetType().Name, ex.Message);
                //throw;
            }
            finally
            {
                Console.WriteLine("Finally");
            }

            return null;
        }

        private static int DivideStringValues(string x, string y)
        {
            if (string.IsNullOrWhiteSpace(x))
            {
                throw new ArgumentNullOrWhitespaceException("Argument must have a value other than null or whitespace.", nameof(x));
            }

            if (string.IsNullOrWhiteSpace(y))
            {
                throw new ArgumentNullOrWhitespaceException("Argument must have a value other than null or whitespace.", nameof(y));
            }

            int xValue = Int32.Parse(x);
            int yValue = Int32.Parse(y);
            //int yValue;

            if (!Int32.TryParse(y, out yValue))
            {
                throw new ArgumentException($"The value \"{y}\" for y could not be converted to an int.");
            }

            return xValue / yValue;
        }
    }
}
