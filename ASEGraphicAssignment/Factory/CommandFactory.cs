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
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <param name="parameters"></param>
        /// <param name="multiLineContent"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>

        public static ICommandInterface GetCommand(string command, string[] parameters, string multiLineContent)
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

                case "clear":
                    return new ClearCommand();

                case "save":
                    if (parameters.Length == 1)
                    {
                        return new SaveCommand(parameters[0], multiLineContent);
                    }
                    throw new ArgumentException("Save command requires a file path parameter.");

                case "circle":
                    if (parameters.Length == 1 && int.TryParse(parameters[0], out int radius))
                    {
                        return new CircleCommand(radius, _GraphicContext);
                    }
                    throw new ArgumentException("Circle command requires one integer parameter: radius.");


                case "square":
                    if (parameters.Length == 2
                        && int.TryParse(parameters[0], out int width)
                        && int.TryParse(parameters[1], out int height))
                    {
                        return new SquareCommand(width, height, _GraphicContext);
                    }
                    throw new ArgumentException("Square command requires two integers to represent the width and height.");

                default:
                    throw new ArgumentException($"Command '{command}' is not recognized.");
              
            }
        }
    }
}
