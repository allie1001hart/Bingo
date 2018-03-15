/*
 * Alexandra Hart 
 * 2/7/2018
 * Internal Board Class:
 * Keeps track of any win situations using arrays and ints.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo.Classes
{
    class InternalBoard
    {
        int[] rowCounter = new int[5];
        int[] colCounter = new int[5];
        int forwardDiaCounter = 0;
        int backwardDiaCounter = 0;

        //initializes the interal board to 0 except where the free space is
        public InternalBoard()
        {
            int[] rowCounter = { 0, 0, 1, 0, 0};
            int[] colCounter = { 0, 0, 1, 0, 0 };
            forwardDiaCounter = 1;
            backwardDiaCounter = 1;
        }
        //record the user selected cell by row and col
        public void recordCalledNumber(int rowID, int colID)
        {
            rowCounter[rowID] ++;
            colCounter[colID] ++;
            if (rowID == colID)
            {
                forwardDiaCounter++;
            }
            if (rowID + colID == 4)
            {
                backwardDiaCounter++;
            }
        }
        //checks for bingo by seeing if any value equals 5
        public int checkForBingo()
        {
            if (forwardDiaCounter == 5)
            {
                return 1;
            }
            else if (backwardDiaCounter == 5)
            {
                return 1;
            }
            for (int i = 0; i < 5; i++)
            {
                if (rowCounter[i] == 5)
                {
                    return 1;
                } else if (colCounter[i] == 5){
                    return 1;
                }
            }
            return 0;
        }
    }
}