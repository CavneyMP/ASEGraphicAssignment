using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASEGraphicAssignment.GraphicContext;
using ASEGraphicAssignment.Commands;
using ASEGraphicAssignment.Factory;


namespace ASEGraphicAssignment.Commands
{
    /// <summary>
    /// The draw to command is to allow the user to draw from the current point to the new specified point
    /// </summary>
    public class DrawToCommand : ICommandInterface
    {
        private Point _endPosition;
        private readonly GraphicsContext _GraphicContext;

        /// <summary>
        /// this initialises a new instance of the Drawtocommand with an end position and a graphic context
        /// </summary>
        /// <param name="endPosition">This is the end position that should be drawn to </param>
        /// <param name="GraphicContext">This is the graphics context that maintains the current drawing state </param>

        public DrawToCommand(Point endPosition, GraphicsContext GraphicContext)
        {
            _endPosition = endPosition;
            _GraphicContext = GraphicContext;
        }

        /// <summary>
        /// This executes the drawing line from the current to end position.
        /// </summary>
        /// <param name="graphics">The graphics object used for drawing the line</param>

        public void Execute(Graphics graphics)
        {
            graphics.DrawLine(Pens.Black, _GraphicContext.CurrentPosition, _endPosition); // Draws a line from the current position to the end position
            _GraphicContext.UpdatePosition(_endPosition); // After drawing, update the current position to the end position
        }
    }
}
