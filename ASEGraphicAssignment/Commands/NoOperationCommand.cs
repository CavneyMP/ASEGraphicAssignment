﻿using System;
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
    namespace ASEGraphicAssignment.Commands
    {
        /// <summary>
        /// A command that performs no operation
        /// </summary>
        public class NoOpCommand : ICommandInterface
        {
            /// <summary>
            /// Performs no operation.
            /// </summary>
            /// <param name="graphics">Graphics context which is not used in this command.</param>
            public void Execute(Graphics graphics)
            {
                // Nothing is done intentionally. 
            }
        }
    }
}
