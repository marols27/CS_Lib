using System;

namespace Shapes
{
    internal class SafeConsoleInputs
    {
        public int? InputInt()
        {
            try
            {
                int x = Int32.Parse(Console.ReadLine());
                return x;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public int? InputInt(string message)
        {
            Console.Write(message);
            try
            {
                int x = Int32.Parse(Console.ReadLine());
                return x;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public int? InputPositiveInt()
        {
            try
            {
                int x = Int32.Parse(Console.ReadLine());
                if (x < 0)
                {
                    Console.WriteLine("Must be a positive integer.");
                    return null;
                }
                else
                {
                    return x;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public int? InputPositiveInt(string message)
        {
            Console.Write(message);
            try
            {
                int x = Int32.Parse(Console.ReadLine());
                if (x < 0)
                {
                    Console.WriteLine("Must be a positive integer.");
                    return null;
                }
                else
                {
                    return x;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public double? InputDouble()
        {
            string input = Console.ReadLine();
            double output;
            try
            {
                try
                {
                    output = Double.Parse(input);
                }
                catch (Exception ex_)
                {
                    output = Double.Parse(input.Replace(".", ","));
                }
            }
            catch (Exception ex)
            {
                try
                {
                    output = Double.Parse(input.Replace(",", "."));
                }
                catch (Exception ex_)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
            return output;
        }

        public double? InputDouble(string message)
        {
            Console.Write(message);

            string input = Console.ReadLine();
            double output;
            try
            {
                try
                {
                    output = Double.Parse(input);
                }
                catch (Exception ex_)
                {
                    output = Double.Parse(input.Replace(".", ","));
                }
            }
            catch (Exception ex)
            {
                try
                {
                    output = Double.Parse(input.Replace(",", "."));
                }
                catch (Exception ex_)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
            return output;
        }
    }
}