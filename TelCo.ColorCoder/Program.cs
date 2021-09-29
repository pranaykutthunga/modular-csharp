using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// The 25-pair color code, originally known as even-count color code, 
    /// is a color code used to identify individual conductors in twisted-pair 
    /// wiring for telecommunications.
    /// This class provides the color coding and 
    /// mapping of pair number to color and color to pair number.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Test code for the class
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            int pairNumber = 4;
            ColorPair colorPair = Utility.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, colorPair);
            Debug.Assert(colorPair._majorColor == Color.White);
            Debug.Assert(colorPair._minorColor == Color.Brown);

            pairNumber = 5;
            colorPair = Utility.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, colorPair);
            Debug.Assert(colorPair._majorColor == Color.White);
            Debug.Assert(colorPair._minorColor == Color.SlateGray);

            pairNumber = 23;
            colorPair = Utility.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, colorPair);
            Debug.Assert(colorPair._majorColor == Color.Violet);
            Debug.Assert(colorPair._minorColor == Color.Green);

            ColorPair testPair2 = new ColorPair() { _majorColor = Color.Yellow, _minorColor = Color.Green };
            pairNumber = Utility.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
            Debug.Assert(pairNumber == 18);

            testPair2 = new ColorPair() { _majorColor = Color.Red, _minorColor = Color.Blue };
            pairNumber = Utility.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}", testPair2, pairNumber);
            Debug.Assert(pairNumber == 6);

            Utility.PrintReferenceManual();

        }
    }
}
