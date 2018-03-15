/*
 * Alexandra Hart 
 * 2/7/2018
 * Used Numbers Class:
 * Keeps track of all called numbers so that no number is called twice.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo.Classes
{
    public class UsedNumbers
    {
        int[] usedNumberArray = new int[76];

        //initalizes the array
        public void createArray()
        {
            int count = 0;
            while (count < 75)
            {
                usedNumberArray[count] = 0;
                count++;
            }
        }
        //checks if number is used by checking if the value at index rn is 1
        public bool isNumberUsed(int rn)
        {
            if (usedNumberArray[rn] == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //sets the valus at index rn to 1
        public void setUsedNumber(int rn)
        {
            usedNumberArray[rn] = 1;
        }
        //initalizes the array back to 0
        public void reset()
        {
            int count = 0;
            while (count < 76)
            {
                usedNumberArray[count] = 0;
                count++;
            }
        }
    }
}
