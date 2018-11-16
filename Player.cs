/*Gavin Rodgers and Louis Rodriguez
 * 3309 Battleship project III
 * This is the Player class that handles all Player storage and information
 * Last Edited: 11/7/18
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Classes
{
    class Player
    {
        //attribute for playername
        string playername;
        //constructor to the PlayerModel class
        //method for input name
        public Player(string name)
        {
            playername = name;
        }
    }
}
