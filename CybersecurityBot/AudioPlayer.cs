// handles voice greeting audio playback
using System.Media;

static class AudioPlayer
{
    // play the wav greeting file from the assets folder on startup
    public static void PlayGreeting()
    {
        try
        {
            // create player pointing to the greeting wav file
            SoundPlayer player = new SoundPlayer("assets/sound.wav");

            // play synchronously so greeting finishes before the banner appears
            player.PlaySync();
        }
        catch (Exception)
        {
            // notify user if audio file is missing and continue gracefully
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Voice greeting file not found. Continuing...");
            Console.ResetColor();
        }
    }
}
