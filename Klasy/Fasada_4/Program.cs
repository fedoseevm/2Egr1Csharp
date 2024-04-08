using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasada_4
{
    class HomeThreaterFacade
    {
        Client Client;
        Projector Projector;
        SoundSystem SoundSystem;
        MediaPlayer MediaPlayer;

        public void watchMovie() { }
        public void endMovie() { }
        public void AddClient(Client client)
        {
            Client = client;
        }
        public void AddProjector(Projector projector)
        {
            Projector = projector;
        }
        public void AddSoundSystem(SoundSystem soundSystem)
        {
            SoundSystem = soundSystem;
        }
        public void SetMediaPlayer(MediaPlayer mediaPlayer)
        {
            this.MediaPlayer = mediaPlayer;
        }

    }
    class Client
    {

    }
    class Projector
    {
        public void on() { }
        public void off() { }
    }
    class SoundSystem
    {
        public void on() { }
        public void off() { }
    }
    class MediaPlayer
    {
        public void play() { }
        public void stop() { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
