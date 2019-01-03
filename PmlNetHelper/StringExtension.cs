namespace PmlNetHelper
{
    /// <summary>
    /// Defines the <see cref="StringExtension" />
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// The Implant
        /// </summary>
        /// <param name="line">The line<see cref="string"/></param>
        /// <param name="addLine">The addLine<see cref="string"/></param>
        /// <param name="position">The position<see cref="int"/></param>
        /// <returns>The <see cref="string"/></returns>
        public static string Implant(this string line, string addLine, int position)
        {
            position = position - 1;
            var oriLen = line.Length;
            var newLen = addLine.Length;
            var length = newLen + position;
            if (oriLen < length) line = line.PadRight(length);

            line = line.Remove(position, newLen);
            line = line.Insert(position, addLine);

            return line;
        }
    }
}
