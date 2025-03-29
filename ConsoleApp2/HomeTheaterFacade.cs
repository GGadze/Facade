﻿using ConsoleApp2.Звуковая_система;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class HomeTheaterFacade
    {
        private Amplifier _amplifier;
        private DVDPlayer _dvdPlayer;
        private Projector _projector;
        private SoundSystem _soundSystem;

        public HomeTheaterFacade(Amplifier amplifier, DVDPlayer dvdPlayer, Projector projector, SoundSystem soundSystem)
        {
            _amplifier = amplifier;
            _dvdPlayer = dvdPlayer;
            _projector = projector;
            _soundSystem = soundSystem;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Приготовься к просмотру фильма...");
            _projector.On();
            _projector.SetInput("DVD");
            _soundSystem.On();
            _soundSystem.SetMode("BassBoost");
            _amplifier.On();
            _amplifier.SetVolume(5);
            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Заканчиваем фильм...");
            _dvdPlayer.Stop();
            _dvdPlayer.Off();
            _soundSystem.Off();
            _amplifier.Off();
            _projector.Off();
        }
    }
}
