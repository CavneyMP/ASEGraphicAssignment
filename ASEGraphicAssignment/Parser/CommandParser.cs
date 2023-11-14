using ASEGraphicAssignment.Commands;
using ASEGraphicAssignment.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASEGraphicAssignment.Parser
{
    /// <summary>
    /// This command parser will be pasrsing the given user input, we need to know from the input what the command and passed parameters are.
    /// The Command parser will ultizie the Command Factory to create the relevant command object. 
    /// </summary>
    public class CommandParser
    {
        /// <summary>
        /// This is where the input will be split by looking for the white space in the user input and splitting the invidual parts into "tokens"
        /// It essentially takes the first word as the command, and anything affter into an array called parameters
        /// </summary>
        /// <param name="inputLine">The input line is what will contain the command and the parameters </param>
        /// <returns>The command that corresponds with the parsed input</returns>
        public ICommandInterface ParseCommand(string userInput, string multiLineContent)
        {
            string[] tokens = userInput.Split(' '); // Split the command up where white space is found.
            string command = tokens[0]; //Takes first token as the command name 
            string[] parameters = tokens.Skip(1).ToArray(); // Split and place next tokens in an array called parameters.

            return CommandFactory.GetCommand(command, parameters, multiLineContent); // Here we create and return the command
        }
    }
}
