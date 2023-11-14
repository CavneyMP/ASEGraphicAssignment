using ASEGraphicAssignment.Commands;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASEGraphicAssignment.GraphicContext;

namespace ASEGraphicAssignment.Factory
{
    public static class CommandFactory
    {
        /// <summary>
        /// The Command factory is used to create and return the command is matched from the user input
        /// </summary>
        private static readonly GraphicsContext _GraphicContext = new GraphicsContext();

        /// <summary>
        /// This method called GetCommand is what creates the object
        /// </summary>
        /// <param name="command">This is where we have parsed the first word of the input to know what the actual user command is</param>
        /// <param name="parameters">This is an array of strings that will hold the parameters the user passes</param>
        /// <returns>This is where the method returns an object that implements the intercface and the object will be the command given by the user </returns>
        /// <exception cref="ArgumentException">If command isnt recognised then this exception will be thrown</exception>

        public static Commands.ICommandInterface GetCommand(string command, string[] parameters)
        {
            switch (command.ToLower())
            {
                case "reset":
                    return new ResetCommand(_GraphicContext);

                case "drawto":
                    if (parameters.Length == 2
                        && int.TryParse(parameters[0], out int drawX)
                        && int.TryParse(parameters[1], out int drawY))
                    {
                        return new DrawToCommand(new Point(drawX, drawY), _GraphicContext);
                    }
                    throw new ArgumentException("DrawTo command requires two integer parameters: x and y coordinates.");

                case "moveto":
                    if (parameters.Length == 2
                        && int.TryParse(parameters[0], out int moveX)
                        && int.TryParse(parameters[1], out int moveY))
                    {
                        return new MoveToCommand(new Point(moveX, moveY), _GraphicContext);
                    }
                    throw new ArgumentException("MoveTo command requires two integer parameters: x and y coordinates.");

                default:
                    throw new ArgumentException($"Command '{command}' is not recognized.");
            }
        }
    }
}
