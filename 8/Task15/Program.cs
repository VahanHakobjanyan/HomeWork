namespace Task15
{
    internal class Program
    {
        //Task15: Toggle a Flag On/Off
        static void Main(string[] args)
        {
            Settings currentSettings = Settings.FullScreenOn;
            Console.WriteLine(currentSettings);

            currentSettings = currentSettings ^ Settings.SoundOn;
            Console.WriteLine(currentSettings);

            Console.ReadKey();
        }
    }
    [Flags]
    enum Settings
    {
        SoundOn = 1,
        MusicOn = 2,
        FullScreenOn = 4
    }
}
