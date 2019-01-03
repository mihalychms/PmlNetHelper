namespace PmlNetHelper
{
    using Aveva.Core.PMLNet;
    using System;
    using System.Collections;

    /// <summary>
    /// Defines the <see cref="Regex" />
    /// </summary>
    [PMLNetCallable()]
    public partial class Regex
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Regex"/> class.
        /// </summary>
        [PMLNetCallable()]
        public Regex()
        {
        }

        /// <summary>
        /// The Assign
        /// </summary>
        /// <param name="that">The that<see cref="Regex"/></param>
        [PMLNetCallable()]
        public void Assign(Regex that)
        {
        }

        /// <summary>
        /// The DigitsFromString
        /// </summary>
        /// <param name="line">The line<see cref="string"/></param>
        /// <returns>The <see cref="Hashtable"/></returns>
        [PMLNetCallable()]
        public Hashtable DigitsFromString(string line)
        {
            var ht = new Hashtable();
            string[] numbers = System.Text.RegularExpressions.Regex.Split(line, @"\D+");
            for (int j = 0; j < numbers.Length; j++)
            {
                string value = numbers[j];
                if (!string.IsNullOrEmpty(value))
                    ht.Add(Convert.ToDouble(j), double.Parse(value));
            }
            return ht;
        }
    }
}
