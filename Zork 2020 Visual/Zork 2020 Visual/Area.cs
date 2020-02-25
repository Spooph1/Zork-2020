using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zork_2020_Visual
{
    class Area
    {
        Dictionary<Directions, Area> neighbors = new Dictionary<Directions, Area>();

        List<Item> items = new List<Item>();

        string areaName;
        string description;

        public Area(string areaName, string description)
        {
            this.areaName = areaName;
            this.description = description;
        }
        public void Connect(Area other, Directions dir)
        {
            neighbors.Add(dir, other);
        }
        public void ConnectBidirectional(Area other, Directions dir)
        {
            Connect(other, dir);
            other.Connect(this, Opposite(dir));
        }
        Directions Opposite(Directions dir)
        {
            switch (dir)
            {
                case Directions.North:
                    return Directions.South;
                case Directions.South:
                    return Directions.North;
                case Directions.East:
                    return Directions.West;
                case Directions.West:
                    return Directions.East;
                default:
                    return Directions.North;
            }
        }
    }
    public enum Directions
    {
        North, South, East, West
    }
}
