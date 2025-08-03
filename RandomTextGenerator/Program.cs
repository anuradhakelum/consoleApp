using System;
using RandomTextGenerator.Models;
using RandomTextGenerator.Helpers;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0 || IsHelpRequested(args))
        {
            PrintHelp();
            return;
        }

        if (args[0].ToLower() != "generate")
        {
            Console.WriteLine("Unknown command. Use: generate");
            return;
        }

        var options = ParseOptions(args);

        string randomText = RandomTextHelper.GenerateRandomText(options);
        Console.WriteLine(randomText);
    }

    static bool IsHelpRequested(string[] args)
    {
        foreach (var arg in args)
        {
            if (arg == "-h" || arg == "--help" || arg == "?" || arg == "-?")
                return true;
        }
        return false;
    }

    static void PrintHelp()
    {
        Console.WriteLine("RandomTextGenerator usage:");
        Console.WriteLine("  generate [--length <number>] [--numeric <true|false>] [--specialcharacter <true|false>]");
        Console.WriteLine();
        Console.WriteLine("Options:");
        Console.WriteLine("  --length <number>            Length of the generated text (default: 10)");
        Console.WriteLine("  --numeric <true|false>       Include numeric characters (default: false)");
        Console.WriteLine("  --specialcharacter <true|false> Include special characters (default: false)");
        Console.WriteLine("  -h, --help, ?, -?            Show this help message");
    }

    static Options ParseOptions(string[] args)
    {
        var options = new Options();
        for (int i = 1; i < args.Length - 1; i++)
        {
            switch (args[i])
            {
                case "--length":
                    if (int.TryParse(args[i + 1], out int l)) options.Length = l;
                    i++;
                    break;
                case "--numeric":
                    if (bool.TryParse(args[i + 1], out bool n)) options.Numeric = n;
                    i++;
                    break;
                case "--specialcharacter":
                    if (bool.TryParse(args[i + 1], out bool s)) options.SpecialCharacter = s;
                    i++;
                    break;
            }
        }
        return options;
    }
}