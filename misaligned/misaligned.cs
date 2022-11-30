using System;
using System.Diagnostics;

namespace MisalignedSpace {
    class Misaligned {
        List<string> actualColorCodePairList = new List<string>();
        List<string> colorCodePairList = new List<string>();
        string[] colorCodePairArray = { };
        string[] actualColorCodePairArray = { };
        
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
        
         public void getColorCodePairList()
        {
            string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
            string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };
            int i = 0, j = 0;
            for (i = 0; i < majorColors.Length; i++)
            {
                for (j = 0; j < minorColors.Length; j++)
                {
                    colorCodePairList.Add(string.Format("{0} | {1} | {2}", i * minorColors.Length + j, majorColors[i], minorColors[j]));
                }
            }

            for (i = 0; i < majorColors.Length; i++)
            {
                for (j = 1; j <= minorColors.Length; j++)
                {
                    actualColorCodePairList.Add(string.Format("{0} | {1} | {2}", i * minorColors.Length + j, majorColors[i], minorColors[j]));
                }
            }
            colorCodePairArray = colorCodePairList.ToArray();
            actualColorCodePairArray = actualColorCodePairList.ToArray();
        }
        
        static void Main(string[] args) {
            int result = printColorMap();
            Debug.Assert(result == 25);
            testMisaligned.getColorCodePairList();
            Console.WriteLine("All is well (maybe!)");
        }
    }
}
