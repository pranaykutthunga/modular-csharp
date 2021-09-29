using System.Drawing;

namespace TelCo.ColorCoder
{
    internal static class ColorMap
    {
        /// <summary>
        /// Array of Major colors
        /// </summary>
        public static Color[] _colorMapMajor;
        /// <summary>
        /// Array of minor colors
        /// </summary>
        public static Color[] _colorMapMinor;


        /// <summary>
        /// Static constructor required to initialize static variable
        /// </summary>
        static ColorMap()
        {
            _colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            _colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }
    }
}
