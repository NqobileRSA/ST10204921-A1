// manages the main chatbot session flow
class ChatBot
{
    // no dependencies needed in constructor
    public ChatBot() { }

    // start the chatbot — plays greeting, shows banner, then enters chat loop
    public void Run()
    {
        // play voice greeting on startup
        AudioPlayer.PlayGreeting();

        // show ascii art banner
        ConsoleUI.DisplayBanner();

        // prompt user for their name
        ConsoleUI.PrintInfo("Please enter your name:");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("> ");
        Console.ResetColor();
        string name = Console.ReadLine() ?? string.Empty;

        // fall back to a default name if blank
        if (string.IsNullOrWhiteSpace(name))
            name = "User";

        // greet the user by name with typing effect
        Console.WriteLine();
        ConsoleUI.PrintBotLabel();
        ConsoleUI.TypeWrite($"Hello, {name}! Welcome to the Cybersecurity Awareness Bot. Type 'help' to see available topics, or 'exit' to quit.");
        Console.WriteLine();

        // main interaction loop
        while (true)
        {
            Console.WriteLine();
            ConsoleUI.PrintUserLabel(name);
            string raw = Console.ReadLine() ?? string.Empty;

            // reject empty or whitespace-only input
            if (string.IsNullOrWhiteSpace(raw))
            {
                ConsoleUI.PrintError("Please enter a message.");
                continue;
            }

            // get and display the bot response
            string response = ResponseEngine.GetResponse(raw, name);
            ConsoleUI.PrintBotLabel();
            ConsoleUI.TypeWrite(response);
            Console.WriteLine();

            // break loop when user wants to exit
            string trimmed = raw.Trim().ToLower();
            if (trimmed == "exit" || trimmed == "quit")
                break;
        }
    }
}
