using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public class Player
    {
        string name;
        int points;

        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }

        public int Points
        {
            get { return Points; }
            set { Points = value; }
        }

        public Player() { }

        public Player(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }
    }
}
