using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor_Submission
{
    class Pirate
    {
        public string Name { get; set; }
        public int KillCount { get; set; }

        public Pirate(string name, int kills)
        {
            Name = name;
            KillCount = kills;
        }
        public Pirate(string name) : this (name, 0)
        {

        }
    }
}
