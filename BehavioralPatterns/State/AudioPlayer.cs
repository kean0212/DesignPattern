using System;
using System.Collections.Generic;

namespace BehavioralPatterns.State
{
    public class AudioPlayer
    {
        private State _state;
        private UserInterface _ui;
        private int _volume;
        private List<string> _playlist;
        private string _currentSong;

        public AudioPlayer()
        {
            _state = new ReadyState();
            _ui = new UserInterface();
            _ui.LockButton.OnClick = ClickLock;
            _ui.PlayButton.OnClick += ClickPlay;
            _ui.NextButton.OnClick += ClickNext;
            _ui.PreviousButton.OnClick += ClickPrevious;
        }

        public void ChangeState(State newState)
        {
            _state = newState;
        }

        public void ClickLock()
        {
            Console.WriteLine($"{nameof(ClickLock)}");
        }

        public void ClickPlay()
        {
            Console.WriteLine($"{nameof(ClickPlay)}");
        }

        public void ClickNext()
        {
            Console.WriteLine($"{nameof(ClickNext)}");
        }

        public void ClickPrevious()
        {
            Console.WriteLine($"{nameof(ClickPrevious)}");
        }

        public void StartPlayback()
        {
            Console.WriteLine($"{nameof(StartPlayback)}");
        }

        public void StopPlayback()
        {
            Console.WriteLine($"{nameof(StopPlayback)}");
        }

        public void NextSong()
        {
            Console.WriteLine($"{nameof(NextSong)}");
        }

        public void PreviousSong()
        {
            Console.WriteLine($"{nameof(PreviousSong)}");
        }

        public void FastForward(TimeSpan timeSpan)
        {
            Console.WriteLine($"{nameof(FastForward)} {timeSpan}");
        }

        public void Rewind(TimeSpan timeSpan)
        {
            Console.WriteLine($"{nameof(Rewind)} {timeSpan}");
        }
    }
}
