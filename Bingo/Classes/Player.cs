/*
 * Alexandra Hart 
 * 2/7/2018
 * Player Class:
 * Keeps track of the players name
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo.Classes
{
    class Player
    {
        string playerName;

        public void setPlayerName(String name)
        {
            playerName = name;
        }
        public String getPlayerName()
        {
            return playerName;
        }
        public bool validateName(String name)
        {
            if (name == "")
            {
                return false;
            }
            return true;
        }
    }
}
