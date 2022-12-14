using System;
using System.Diagnostics;

namespace MisalignedSpace {
    class Misaligned {
        
        List<string> actualColorCodePairList = new List<string>();
        List<string> colorCodePairList = new List<string>();
        string[] actualColorCodePairArray = { };
        string[] colorCodePairArray = { };
        
        static int getLongestMajorColorString(string[] majorColor)
        {
            string majorColorLongString = string.Empty;
            for (int i = 1; i < majorColor.Length; i++)
            {
                if (majorColor[i].Length > majorColor[i-1].Length)
                {
                    majorColorLongString = majorColor[i];
                }
                else
                {
                    majorColorLongString = majorColor[i-1];
                }
                return majorColorLongString.Length;
        }
          
        static int getLongestMinorColorString(string[] minorColor)
        {
            string minorColorLongString = string.Empty;
            for (int i = 1; i < minorColor.Length; i++)
            {
                if (minorColor[i].Length < minorColor[i - 1].Length)
                {
                    minorColorLongString = minorColor[i];
                }
                else
                {
                    minorColorLongString = minorColor[i - 1];
                }
            }

            return minorColorLongString.Length;
        }   
            
        static string addBlankSpace(int blankSpace, string line)
        {
            for (int i = 0; i < blankSpace; i++)
            {
                line = line + " ";
            }
            return line;
        }

        static string[] correctMisalignedString(string[] array, int longestArrayLength)
        {
            List<string> newArray = new List<string>();
            foreach(string arr in array)
            {
                int lengthDifference = longestArrayLength - arr.Length;
                newArray.Add(addBlankSpace(lengthDifference, arr));
            }
            return newArray.ToArray();
        }            
            
        static int printColorMap() 
        {
            string[] majorColors = {"White", "Red", "Black", "Yellow", "Violet"};
            string[] minorColors = {"Blue", "Orange", "Green", "Brown", "Slate"};
            
            int longestMajorColorString = getLongestMajorColorString(majorColors);
            int longestMinorColorString = getLongestMinorColorString(minorColors);

            majorColors = correctMisalignedString(majorColors, longestMajorColorString);
            minorColors = correctMisalignedString(minorColors, longestMinorColorString);
            
            int i = 0, j = 0;
            for(i = 0; i < majorColors.Length; i++) 
            {
                for(j = 0; j < minorColors.Length; j++) 
                {
                    actualColorCodePairList.Add(string.Format("{0} | {1} | {2}", i * minorColors.Length + j, majorColors[i], minorColors[j]));
                }
            }
            colorCodePairArray = colorCodePairList.ToArray();
            actualColorCodePairArray = actualColorCodePairList.ToArray();
        }
        
        static void Main(string[] args) 
        {
            int result = printColorMap();
            Debug.Assert(result == 25);
            testMisaligned.getColorCodePairList();
            testMisaligned.printColorCodeMisalignementTest();
            Console.WriteLine("All is well (maybe!)");
            testMisaligned.falseColorCodePairTest();           
        }
    }
}
