namespace PmlNetHelper
{
    using Aveva.Core.PMLNet;

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
    }
}
