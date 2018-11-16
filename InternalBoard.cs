/*Gavin Rodgers and Louis Rodriguez
 * 3309 Battleship project III
 * This is the Internal Board class that handles all board storage and information
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
    class InternalBoard
    {
        //max number of hits posible in a board
        private int maxHits = 17;
        //arraylist that holds boat locations
        public ArrayList ShipLocations = new ArrayList();
        //Internal Board constructor
        public InternalBoard(int max)
        {

        }
        //determines if there is a hit made in the play of the game or not
        public Boolean isHit(int row, int col)
        {
            string output = (row/35).ToString() + (col/35).ToString();
            if (ShipLocations.Contains(output))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //inserts ships locations that were created by players
        public void shiplocationInsert(int row, int col)
        {
            string input = row.ToString() + col.ToString();
            ShipLocations.Add(input);
        }    
        //determines when there is a loser and therefore a loser
        public Boolean isLoser()
        {
            if (hitsCount() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //decrements the hits counter when a hit is made
        public void decrementHitsCounter()
        {
             maxHits--;
        }
        //checks what the hits count is
        public int hitsCount()
        {
           return maxHits;
        }

    }
}
