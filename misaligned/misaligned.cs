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
          
            
            
        static int printColorMap() {
            string[] majorColors = {"White", "Red", "Black", "Yellow", "Violet"};
            string[] minorColors = {"Blue", "Orange", "Green", "Brown", "Slate"};
            int i = 0, j = 0;
            for(i = 0; i < 5; i++) {
                for(j = 0; j < 5; j++) {
                    Console.WriteLine("{0} | {1} | {2}", i * 5 + j, majorColors[i], minorColors[i]);
                }
            }
            return i * j;
        }
        static void Main(string[] args) {
            int result = printColorMap();
            Debug.Assert(result == 27);
            Console.WriteLine("All is well (maybe!)");
        }
    }
}
