using System;

namespace OnlineRadio.Models
{
    using OnlineRadio.Utilities;
    public class Song
    {
        private int seconds;
        private int minutes;
        private string artistName;
        private string songName;

        public Song(string artistName, string songName, int minutes, int seconds)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }
        public int Seconds
        {
            //C# 7.0
            get => seconds;
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException(ErrorMessages.InvalidSongSeconds);
                }
                seconds = value;
            }

        }
        public int Minutes
        {
            get => minutes;

            set
            {
                if (value < 0 || value > 14)
                {
                    throw new ArgumentException(ErrorMessages.InvalidSongMinutes);
                }
                minutes = value;
            }
        }
        public string ArtistName
        {
            get => artistName;

            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new ArgumentException(ErrorMessages.InvalidArtistName);
                }

                artistName = value;
            }
        }
        public string SongName
        {
            get => songName;

            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new ArgumentException(ErrorMessages.InvalidSongLength);
                }
                if (value.Length == 0)
                {
                    throw new ArgumentException(ErrorMessages.InvalidSongName);
                }

                songName = value;
            }
        }
    }
}
