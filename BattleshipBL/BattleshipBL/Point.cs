using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipBL
{
    class Point
    {
        public enum PointStatus
        {
            Empty, Ship, Hit, Miss
        }
        public int X { get; set; }
        public int Y { get; set; }
        public PointStatus Status {get; set;}
        
        public Point (int x, int y, PointStatus Status);

    }

}
