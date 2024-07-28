namespace Multiple_Interfaces
{
    internal class Program
    {
        //Multiple Interfaces:Create an interface IPlayable with methods Play() and Pause().
        //Define another interface IRecordable with methods Record() and StopRecording().
        //Create a class MediaPlayer that implements both interfaces.
        //Create an instance of MediaPlayer and test its play, pause, record, and stop recording functionality.
        static void Main(string[] args)
        {
            MediaPlayer player = new MediaPlayer();

            player.Play();
            player.Pause();
            player.Record();
            player.StopRecording();

            Console.ReadKey();
        }
    }
}
