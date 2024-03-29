﻿namespace ChallongeApiWrapper
{
    public class Participant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ChallongeUsername { get; set; }

        public int Seed { get; set; }

        public string Misc { get; set; }

        public string NameOrUsername { get { return string.IsNullOrEmpty(Name) ? ChallongeUsername : Name; } }
    }
}