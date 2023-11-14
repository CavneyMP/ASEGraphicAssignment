using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASEGraphicAssignment.GraphicContext
{
    /// <summary>
    ///This is a class that is defined to maintain the state necessary for the drawing envrioment, it is to hold drawing position, color and pen settings.
    /// </summary>
    public class GraphicsContext
    {

        /// <summary>
        /// This simply gets the current position of where the user is pointing
        /// </summary>
        public Point CurrentPosition { get; private set; }

        /// <summary>
        /// This initializes the instance of the graphicsContext class
        /// </summary>

        public GraphicsContext()
        {
            CurrentPosition = new Point(0, 0); // Instantiate with a default position
        }
        /// <summary>
        /// This updates the current positon
        /// </summary>
        /// <param name="newPosition">The new position that is set</param>

        public void UpdatePosition(Point newPosition)
        {
            CurrentPosition = newPosition;
        }

        /// <summary>
        /// This resets the cursor back to 0,0 which is the far top left
        /// </summary>
        public void Reset()
        {
            CurrentPosition = new Point(0, 0); // Reset to default position
        }
    }
}
