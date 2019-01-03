namespace PmlNetHelper
{
    using Aveva.Core.Database;
    using Aveva.Core.Geometry;
    using Aveva.Core.PMLNet;
    using Aveva.Core3D.Graphics;

    /// <summary>
    /// Defines the <see cref="Navigator" />
    /// </summary>
    [PMLNetCallable]
    public class Navigator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Navigator"/> class.
        /// </summary>
        [PMLNetCallable]
        public Navigator()
        {
        }

        /// <summary>
        /// The Assign
        /// </summary>
        /// <param name="that">The that<see cref="Navigator"/></param>
        [PMLNetCallable]
        public void Assign(Navigator that)
        {
        }

        /// <summary>
        /// The Zoom
        /// </summary>
        /// <param name="element">The element<see cref="string"/></param>
        /// <param name="distance">The distance<see cref="string"/></param>
        [PMLNetCallable]
        public void Zoom(string element, string distance)
        {
            var dbElement = DbElement.GetElement(element);
            var volume = dbElement.GetDoubleArray(DbAttributeInstance.WVOL);
            var lb = LimitsBox.Create(Position.Create(volume[0], volume[1], volume[2]),
                Position.Create(volume[3], volume[4], volume[5]));
            lb.ExpandBy(DbDouble.Create(distance).Value);
            var limit = new[]
            {
                lb.Minimum.X / 2, lb.Maximum.X / 2,
                lb.Minimum.Y / 2, lb.Maximum.Y / 2,
                lb.Minimum.Z / 2, lb.Maximum.Z / 2
            };
            View3DManager.Instance.CurrentView.SetViewLimits(limit);
            var direction = View3DManager.Instance.CurrentView.GetDirection();
            var curentPosition = lb.Centre();
            var viewPosition = new[] { curentPosition.X, curentPosition.Y, curentPosition.Z };
            View3DManager.Instance.CurrentView.SetCentreAndDir(viewPosition, direction);
            View3DManager.Instance.CurrentView.SetThruPoint(viewPosition);
            View3DManager.Instance.CurrentView.UpdateView();
        }
    }
}
