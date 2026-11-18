using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Events
{
    struct Location
    {
        public Location(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public override string ToString()
        {
            return $"({X} , {Y} , {Z})";
        }
    }
    internal class Ball
    {
        private Location _location;

        public Location Location
        {
            get => _location;
            set
            {
                if (!_location.Equals(value))
                {
                    _location = value;
                    LocationChanged(value);
                }
            }
        }

        public event Action<Location> LocationChanged;
    }

    class Playeer
    {
        public Playeer(string name, string team)
        {
            Name = name;
            Team = team;
        }

        public string Name { get; set; }
        public string Team { get; set; }
        public override string ToString() => $"Player : {Name} in team : {Team}";

        public void Run(Location newlocation)
        {
            Console.WriteLine($"{this.ToString()} is Running Towards >>>> {newlocation}");
        }

    }

    class Refree
    {
        public Refree(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public override string ToString() => $"Refree : {Name}";

        public void Look(Location newlocation)
        {
            Console.WriteLine($"{this.ToString()} is Looking Towards >>> {newlocation}");
        }
    }
}
