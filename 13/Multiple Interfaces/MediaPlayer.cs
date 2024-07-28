using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Interfaces
{
    internal class MediaPlayer : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Starting Playback");
        }
        public void Pause()
        {
            Console.WriteLine("Pausing Playback");
        }
        public void Record()
        {
            Console.WriteLine("Starting Recording");
        }
        public void StopRecording()
        {
            Console.WriteLine("Stoping Recording");
        }
    }
}
