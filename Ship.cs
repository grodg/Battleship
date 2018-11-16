/*Gavin Rodgers and Louis Rodriguez
 * 3309 Battleship project III
 * This is the Ship class that handles all ship counters and decrements
 * Last Edited: 11/7/18
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Battleship.Classes
{
    class Ship
    {
        //counter set for each one of the 10 ships made in the game
        private int carrierAclick = 5;
        private int battleshipAclick = 4;
        private int cruiserAclick = 3;
        private int submarineAclick = 3;
        private int destroyerAclick = 2;
        private int carrierBclick = 5;
        private int battleshipBclick = 4;
        private int cruiserBclick = 3;
        private int submarineBclick = 3;
        private int destroyerBclick = 2;
        //attribute for ship name called in
        private string shipname;
        //constructor that calls in ship name and length for each object
        public Ship(string name,int length)
        {
            shipname = name;
        }
        //decrements carrier placement amount in Board A
        public void CarrierADecrement()
        {
            carrierAclick--;
        }
        //checks Carrier Count of Board A
        public int CarrierACount()
        {
            return carrierAclick;
        }
        //decrements carrier placement amount in Board B
        public void CarrierBDecrement()
        {
            carrierBclick--;
        }
        //checks Carrier Count of Board B
        public int CarrierBCount()
        {
            return carrierBclick;
        }
        //decrements Battleship placement amount in Board A
        public void BattleshipADecrement()
        {
            battleshipAclick--;
        }
        //checks Battleship Count of Board A
        public int BattleshipACount()
        {
            return battleshipAclick;
        }
        //decrements Battleship placement amount in Board B
        public void BattleshipBDecrement()
        {
            battleshipBclick--;
        }
        //checks Carrier Count of Board B
        public int BattleshipBCount()
        {
            return battleshipBclick;
        }
        //decrements Cruiser placement amount in Board A
        public void CruiserADecrement()
        {
            cruiserAclick--;
        }
        //checks Cruiser Count of Board A
        public int CruiserACount()
        {
            return cruiserAclick;
        }
        //decrements Cruiser placement amount in Board B
        public void CruiserBDecrement()
        {
            cruiserBclick--;
        }
        //checks Cruiser Count of Board B
        public int CruiserBCount()
        {
            return cruiserBclick;
        }
        //decrements Submarine placement amount in Board A
        public void SubmarineADecrement()
        {
            submarineAclick--;
        }
        //checks Submarine Count of Board A
        public int SubmarineACount()
        {
            return submarineAclick;
        }
        //decrements Submarine placement amount in Board B
        public void SubmarineBDecrement()
        {
            submarineBclick--;
        }
        //checks Submarine Count of Board B
        public int SubmarineBCount()
        {
            return submarineBclick;
        }
        //decrements Destroyer placement amount in Board A
        public void DestroyerADecrement()
        {
            destroyerAclick--;
        }
        //checks Destroyer Count of Board A
        public int DestroyerACount()
        {
            return destroyerAclick;
        }
        //decrements Destroyer placement amount in Board B
        public void DestroyerBDecrement()
        {
            destroyerBclick--;
        }
        //checks Destroyer Count of Board B
        public int DestroyerBCount()
        {
            return destroyerBclick;
        }
   
      
    }
}
