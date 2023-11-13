﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASEGraphicAssignment.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ASEGraphicAssignment.GraphicContext;

namespace ASEGraphicAssignment.Commands.Tests
    {
        [TestClass()]
        public class ResetCommandTests
        {
            [TestMethod()]
            public void ResetCommandResetsPosition()
            {
                // NEw Instantiation of the graphics context class and reset command
                var graphicsContext = new GraphicsContext();
                var resetCommand = new ResetCommand(graphicsContext);

                // Moves cursor from orginal position, but then passes null for graphics as this part of the interface is not used in reset.
                graphicsContext.UpdatePosition(new Point(10, 10));
                resetCommand.Execute(null);

                // Assert
                Assert.AreEqual(new Point(0, 0), graphicsContext.CurrentPosition, "The cursor position should be reset to (0, 0).");
            }
        }
}