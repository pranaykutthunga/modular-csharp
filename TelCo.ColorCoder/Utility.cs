using System;

namespace TelCo.ColorCoder
{
    internal class Utility
    {
        
        /// <summary>
        /// Given a pair number function returns the major and minor colors in that order
        /// </summary>
        /// <param name="pairNumber">Pair number of the color to be fetched</param>
        /// <returns>return colorpair</returns>
        public static ColorPair GetColorFromPairNumber(int pairNumber)
        {
            // The function supports only 1 based index. Pair numbers valid are from 1 to 25
            int minorSize = ColorMap._colorMapMinor.Length;
            int majorSize = ColorMap._colorMapMajor.Length;
            if (pairNumber < 1 || pairNumber > minorSize * majorSize)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }

            // Find index of major and minor color from pair number
            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorSize;
            int minorIndex = zeroBasedPairNumber % minorSize;

            // Construct the return val from the arrays
            ColorPair pair = new ColorPair()
            {
                _majorColor = ColorMap._colorMapMajor[majorIndex],
                _minorColor = ColorMap._colorMapMinor[minorIndex]
            };

            // return the value
            return pair;
        }

        /// <summary>
        /// For providing Color Coding Reference Manual
        /// </summary>
        public static void PrintReferenceManual()
        {
            int count = 1;
            foreach(var itemMajor in ColorMap._colorMapMajor)
            {
                foreach (var itemMinor in ColorMap._colorMapMinor)
                {
                    Console.WriteLine("Pair no. " + count + "\n" + "Major color " + itemMajor.Name + "\n" + "Minor color " + itemMinor.Name);
                    Console.WriteLine("\n");
                    count++;
                }
                
            }
        }
    }
}
