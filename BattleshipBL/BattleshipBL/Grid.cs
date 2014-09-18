
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipBL
{
    class Grid
    {
        public enum PlaceShipDirection { Horizontal, Vertical }

        //define properties
        public Point[,] Ocean { get; set; }
        public List<Ship> ListOfShips { get; set; }
        public bool AllShipsDestroyed { get; }
        public int CombatRound { get; set; }


        //constructor
        public Grid()
        {
            //initilize ocean
            this.Ocean = new Point[10, 10];
            //fill each cell with a point
            for (int x = 0; x <= 9; x++)
            {
                for (int y = 0; y <= 9; y++)
                {
                    this.Ocean[x, y] = new Point(x, y, Point.PointStatus.Empty);
                }
            }
            //initialize and fill list of ships with each type of ship
            this.ListOfShips = new List<Ship>();
            this.ListOfShips.Add(new Ship(Ship.ShipType.Carrier));
            this.ListOfShips.Add(new Ship(Ship.ShipType.Battleship));
            this.ListOfShips.Add(new Ship(Ship.ShipType.Cruiser));
            this.ListOfShips.Add(new Ship(Ship.ShipType.Submarine));
            this.ListOfShips.Add(new Ship(Ship.ShipType.Minesweeper));

        }
        //Methods and Functions
        private void PlaceShip(Ship shipToPlace, PlaceShipDirection direction, int startX, int startY)
        {
            for (int i = 0; i <= shipToPlace.Length; i++)
            {
                Point startPoint = Ocean[startX, startY];
                startPoint.Status = Point.PointStatus.Ship;
                shipToPlace.OccupiedPoints.Add(startPoint);

                if (direction == PlaceShipDirection.Horizontal)
                {
                    startX++;
                }
                else
                {
                    startY++;
                }

            }
        }
        private void DisplayOcean()
        {
            //write the x axis to the console
            Console.WriteLine(" 0 1 2 3 4 5 6 7 8 9 X");
            //for each row (y), write the Y axis notation "0||"
            for (int y = 0; y <= 9; y++)
            {
                for (int x = 0; x <= 9; x++)
                {
                    switch (this.Ocean[x, y].Status)
                    {
                        case Point.PointStatus.Empty: Console.Write("[ ]");
                            break;
                        case Point.PointStatus.Ship: Console.Write("[ ]");
                            break;
                        case Point.PointStatus.Hit: Console.Write("[X]");
                            break;
                        case Point.PointStatus.Miss: Console.Write("[O]");
                            break;
                        default:
                            break;
                    }
                }
            }

        }
        private void Target(int x, int y)
        {
        //get point from the ocean by using x, y
        //if the PointStatus is Ship, change the Status to Hit
        //if the PointStatus is Empty, change the Status to Miss
        }

        private void PlayGame()
        { 
        
        }

    }
}
