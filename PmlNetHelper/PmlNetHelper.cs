namespace PmlNetHelper
{
    using Aveva.Core.PMLNet;

    /// <summary>
    /// Defines the <see cref="PmlNetHelper" />
    /// </summary>
    [PMLNetCallable()]
    public partial class PmlNetHelper
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PmlNetHelper"/> class.
        /// </summary>
        [PMLNetCallable()]
        public PmlNetHelper()
        {
        }

        /// <summary>
        /// The Assign
        /// </summary>
        /// <param name="that">The that<see cref="PmlNetHelper"/></param>
        [PMLNetCallable()]
        public void Assign(PmlNetHelper that)
        {
        }

        /// <summary>
        /// The SendNotification
        /// </summary>
        /// <param name="content">The content<see cref="string"/></param>
        /// <param name="title">The title<see cref="string"/></param>
        [PMLNetCallable()]
        public void SendNotification(string content, string title)
        {
            Subscriber.PopUp(content, title);
        }
    }
}
