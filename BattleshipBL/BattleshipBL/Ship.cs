using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipBL
{
    class Ship
    {
        public enum ShipType { Carrier, Battleship, Cruiser, Submarine, Minesweeper }

        //declare properties
        public ShipType Type { get; set; }
        public List<Point> OccupiedPoints { get; set; }
        public int Length { get; set; }
        public bool IsDestroyed { get; }

        //constructor
        public Ship(ShipType typeOfShip)
        {
            this.OccupiedPoints = new List<Point>();
            this.Type = typeOfShip;

            switch (typeOfShip)
            {
                case ShipType.Carrier:
                    this.Length = 5;
                    break;
                case ShipType.Battleship:
                    this.Length = 4;
                    break;
                case ShipType.Cruiser:
                    this.Length = 3;
                    break;
                case ShipType.Submarine:
                    this.Length = 3;
                    break;
                case ShipType.Minesweeper:
                    this.Length = 2;
                    break;
                default:
                    break;
            }

        }

        }
}
