using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;


namespace LibraryAPI
{
    public class ColorApp
    {
        /// <summary>
        /// Convert type Color to type uint.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <returns></returns>
        public uint ColorToUInt(Color color)
        {
            return (uint)((color.A << 24) | (color.R << 16) | (color.G << 8) | (color.B << 0));
        }
        /// <summary>
        /// Convert type uint to type Color.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <returns></returns>
        public Color UIntToColor(uint color)
        {
            byte a = (byte)(color >> 24);
            byte r = (byte)(color >> 16);
            byte g = (byte)(color >> 8);
            byte b = (byte)(color >> 0);
            return Color.FromArgb(a, r, g, b);
        }
    }
}
