namespace PmlNetHelper
{
    using System.Drawing;
    using Tulpep.NotificationWindow;

    /// <summary>
    /// Defines the <see cref="Subscriber" />
    /// </summary>
    internal static class Subscriber
    {
        /// <summary>
        /// Defines the Font
        /// </summary>
        internal static readonly Font Font = new Font("Microsoft Sans", 20.0f);

        /// <summary>
        /// Defines the TitleFont
        /// </summary>
        internal static readonly Font TitleFont = new Font("Microsoft Sans", 16.0f);

        /// <summary>
        /// Defines the PopupNotifier
        /// </summary>
        internal static readonly PopupNotifier PopupNotifier = new PopupNotifier
        {
            HeaderHeight = 5,
            BodyColor = Color.DarkSeaGreen,
            ContentFont = Font,
            Size = new Size(500, 150),
            Scroll = true,
            TitleFont = TitleFont

        };

        /// <summary>
        /// The PopUp
        /// </summary>
        /// <param name="content">The content<see cref="string"/></param>
        /// <param name="title">The title<see cref="string"/></param>
        internal static void PopUp(string content, string title)
        {
            PopupNotifier.TitleText = title;
            PopupNotifier.ContentText = content;
            PopupNotifier.IsRightToLeft = false;
            PopupNotifier.Popup();
            PopupNotifier.Scroll = true;
        }
    }
}
