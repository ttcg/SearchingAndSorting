using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAndSorting
{
    public class BinarySearch
    {
        public bool Search(int[] arr, int num)
        {
            if (arr == null || arr.Length == 0)
                return false;

            int startPos = 0;
            int endPos =  arr.Length - 1;            

            var isFound = false;

            while (isFound == false && startPos <= endPos)
            {
                int midPos = (startPos + endPos ) /2;
                if (num == arr[midPos])
                {
                    isFound = true; // exit the loop
                }
                else if (arr[midPos] > num)
                {
                    endPos = midPos - 1;
                }
                else
                {
                    startPos = midPos + 1;
                }
            }

            return isFound;
        }
    }
}
