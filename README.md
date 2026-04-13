# CybersecurityBot — ST10204921

A command-line Cybersecurity Awareness chatbot built in C# (.NET 8) for Part 1 of the Programming 2B POE.

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8)
- Windows OS (required for `System.Media` audio playback)

## Setup Instructions

1. Clone the repository:

   ```bash
   git clone <your-repo-url>
   cd "ST10204921 A1"
   ```

2. Restore dependencies:

   ```bash
   dotnet restore CybersecurityBot/CybersecurityBot.csproj
   ```

3. Add your recorded voice greeting:
   - Record a short WAV file with your welcome message
   - Save it as `CybersecurityBot/assets/greeting.wav`
   - If the file is missing the bot will print a warning and continue

4. Run the application:
   ```bash
   dotnet run --project CybersecurityBot/CybersecurityBot.csproj
   ```

## Project Structure

```
CybersecurityBot/
├── Program.cs          — Entry point
├── ChatBot.cs          — Main session controller
├── ResponseEngine.cs   — Keyword matching and response logic
├── ConsoleUI.cs        — Colour formatting and typing effect
├── AudioPlayer.cs      — WAV audio playback via System.Media
└── assets/
    └── greeting.wav    — Recorded voice greeting (add your own)

.github/
└── workflows/
    └── build.yml       — GitHub Actions CI workflow
```

## Topics the Bot Covers

- Passwords
- Phishing
- Safe Browsing
- Malware
- Two-Factor Authentication (type `2fa` or `two factor`)
- Social Engineering
- General queries: `how are you`, `purpose`, `what can i ask`
- Type `help` for a full list at any time
- Type `exit` or `quit` to end the session

## CI Build

GitHub Actions is configured to restore and build the project on every push to `main` or `master`.

> Add a screenshot of the green CI check mark here before submission.

## YouTube Presentation

> Add your unlisted YouTube link here before submission.
