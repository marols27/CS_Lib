using System;

class SafeConsoleInputs
{
    public double InputDouble()
    {
        Console.WriteLine("Input any numeric value: \n");
        string input = Console.ReadLine();
        double? output = null;
        while (output == null)
        {
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
                    Console.WriteLine("Something went wrong,\n" +
                        "check that you only use caracter 0 - 9, ',', '.'.");
                }
            }
        }
        return (double)output;
    }

    public double InputDouble(string message)
    {
        Console.WriteLine(message);
        string input = Console.ReadLine();
        double? output = null;
        while (output == null)
        {
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
                    Console.WriteLine("Something went wrong,\n" +
                        "check that you only use caracters 0 - 9, ',', '.'\n" +
                        "Try again:");
                    input = Console.ReadLine();
                }
            }
        }
        return (double)output;
    }
}
}

