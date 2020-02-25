using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zork_2020_Visual
{
    class World
    {
        List<Area> allAreas = new List<Area>();
        Area startingArea;
        Area currentArea;

        public World()
        {
            Area a1 = new Area("Puff the magic dragon inn", "Finish your jug and start the new advnture");
            Area a2 = new Area("The city border of Kovir", "You are now about to leave the safty inside the walls of Kovir");
            Area a3 = new Area("The wildernes south of Kovir", "You are now out in the wild, so be aware of the monsters lurking in this world");
            Area a4 = new Area("The road between the south of Kovir and the north of Kaer Morhen", "The roads are flooding with bandits, but in the forrest is lurking the sqauds of Squirrls");
            Area a5 = new Area("The western border of Kaer Morhen", "You are now safe within the walls of the old gatekeep of Kaer Morhen, but you can acess the portal to Puff the Magic Dragon Inn north in Kaer Morhen");

            a1.Connect(a2, Directions.East);
            a2.ConnectBidirectional(a3, Directions.South);
            a3.ConnectBidirectional(a4, Directions.South);
            a4.Connect(a5, Directions.East);
            a5.ConnectBidirectional(a1, Directions.North);

            startingArea = a1;
            currentArea = a1;


        }
    }
}
