namespace PmlNetHelper
{
    using Aveva.Core.PMLNet;
    using System;

    /// <summary>
    /// Defines the <see cref="RandomHelper" />
    /// </summary>
    [PMLNetCallable()]
    public class RandomHelper
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RandomHelper"/> class.
        /// </summary>
        [PMLNetCallable()]
        public RandomHelper()
        {
        }

        /// <summary>
        /// The Assign
        /// </summary>
        /// <param name="that">The that<see cref="RandomHelper"/></param>
        [PMLNetCallable()]
        public void Assign(RandomHelper that)
        {
        }

        /// <summary>
        /// The Next
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        [PMLNetCallable()]
        public double Next()
        {
            var r = new Random();
            return r.Next(int.MinValue, int.MaxValue);
        }

        /// <summary>
        /// The Next
        /// </summary>
        /// <param name="min">The min<see cref="double"/></param>
        /// <param name="max">The max<see cref="double"/></param>
        /// <returns>The <see cref="double"/></returns>
        [PMLNetCallable()]
        public double Next(double min, double max)
        {
            var r = new Random();
            return r.Next((int)Math.Min(min, max), (int)Math.Max(min, max));
        }
    }
}
