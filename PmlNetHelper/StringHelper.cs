namespace PmlNetHelper
{
    using Aveva.Core.PMLNet;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="StringHelper" />
    /// </summary>
    [PMLNetCallable()]
    public partial class StringHelper
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StringHelper"/> class.
        /// </summary>
        [PMLNetCallable()]
        public StringHelper()
        {
        }

        /// <summary>
        /// The Assign
        /// </summary>
        /// <param name="that">The that<see cref="StringHelper"/></param>
        [PMLNetCallable()]
        public void Assign(StringHelper that)
        {
        }

        /// <summary>
        /// The ImplantText
        /// </summary>
        /// <param name="baseText">The baseText<see cref="string"/></param>
        /// <param name="addText">The addText<see cref="string"/></param>
        /// <param name="position">The position<see cref="double"/></param>
        /// <returns>The <see cref="string"/></returns>
        [PMLNetCallable]
        public string ImplantText(string baseText, string addText, double position)
        {
            return baseText.Implant(addText, (int)position);
        }

        /// <summary>
        /// The Join
        /// </summary>
        /// <param name="hashtable">Input PML array<see cref="Hashtable"/></param>
        /// <param name="delimiter">The separator<see cref="string"/></param>
        /// <returns>Single line from input array divided by delimiter<see cref="string"/></returns>
        [PMLNetCallable]
        public string Join(Hashtable hashtable, string delimiter)
        {
            var list = new List<string>();
            for (int i = 0; i < hashtable.Count; i++)
            {
                list.Add(hashtable[Convert.ToDouble(i + 1)].ToString());
            }
            return string.Join(delimiter, list);
        }
    }
}
