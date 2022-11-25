using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Work
{
    internal class VideoPost : Post
    {
        //member fields
        protected bool isPlaying = false;
        protected int currentDuration = 0;
        Timer myTimer;

        //properties
        public string VideoURL { get; set; }
        public int VideoLenght { get; set; }

        public VideoPost() { }

        public VideoPost(string title,string sendByUserName, string videoURL, int videoLenght, bool isPublic)
        {
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.IsPublic = isPublic;
            this.VideoURL = videoURL;
            this.VideoLenght = videoLenght;
            this.ID = GetNextID();
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                myTimer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        private void TimerCallback(Object o)
        {
            if(currentDuration < VideoLenght)
            {
                currentDuration++;
                Console.WriteLine("Video at {0}s", currentDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying=false;
                Console.WriteLine("Stopped at {0}", currentDuration);
                currentDuration = 0;
                myTimer.Dispose();
            }
        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - by {this.SendByUserName} - link: {this.VideoURL} - lenght: {this.VideoLenght}");
        }

    }
}
