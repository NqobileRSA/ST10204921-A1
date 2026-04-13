// handles voice greeting audio playback
using System.IO;
using System.Media;

static class AudioPlayer
{
    // play the wav greeting file from the assets folder on startup
    public static void PlayGreeting()
    {
        try
        {
            string baseDir = AppContext.BaseDirectory;
            string wavPath = Path.Combine(baseDir, "assets", "sound.wav");
            SoundPlayer player = new SoundPlayer(wavPath);

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
