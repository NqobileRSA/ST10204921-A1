// handles all console display, formatting, and colour output
static class ConsoleUI
{
    // display the ascii art header and a divider line
    public static void DisplayBanner()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(" ██████╗██╗   ██╗██████╗ ███████╗██████╗ ███████╗███████╗ ██████╗");
        Console.WriteLine("██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗██╔════╝██╔════╝██╔════╝");
        Console.WriteLine("██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝███████╗█████╗  ██║");
        Console.WriteLine("██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗╚════██║██╔══╝  ██║");
        Console.WriteLine("╚██████╗   ██║   ██████╔╝███████╗██║  ██║███████║███████╗╚██████╗");
        Console.WriteLine(" ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝╚══════╝╚══════╝ ╚═════╝");
        Console.WriteLine("        Cybersecurity Awareness Bot — Protecting South Africa");
        Console.ResetColor();

        // print a separator line below the banner
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine(new string('=', 70));
        Console.ResetColor();
    }

    // print the user prompt label in green with no trailing newline
    public static void PrintUserLabel(string name)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"[{name}]: ");
        Console.ResetColor();
    }

    // print the bot label in yellow with no trailing newline
    public static void PrintBotLabel()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Bot: ");
        Console.ResetColor();
    }

    // print a standard informational message in white
    public static void PrintInfo(string message)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    // print an error message in red
    public static void PrintError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    // print text one character at a time to simulate a typing effect
    public static void TypeWrite(string message)
    {
        Console.ForegroundColor = ConsoleColor.White;
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(18);
        }
        Console.ResetColor();
    }
}
