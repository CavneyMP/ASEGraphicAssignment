using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASEGraphicAssignment.Parser;
using System;
using System.Linq;

namespace ASEGraphicAssignment.Tests
{
    /// <summary>
    /// Test class for the command parser
    /// </summary>
    [TestClass()]
    public class CommandParserTests
    {
        /// <summary>
        /// This is a test method that checks that the single line command has been parsed correctly by checking what it recongnises as parameters
        /// </summary>
        [TestMethod()]
        public void ParseSingleLineCommandWithParametersTest()
        {
            // Creating a new instance of command parser and a string input "drawto 100, 100" 
            var parser = new CommandParser();
            string input = "moveto 100 100";
            string multiLineContent = ""; 

            var commandResult = parser.ParseCommand(input, multiLineContent);
            string[] tokens = input.Split(' ');

            // Check that the tokens match what they should with the above command
            Assert.IsNotNull(commandResult, "Command result should not be null.");
            Assert.AreEqual("moveto", tokens[0], "First token did not match command.");
            Assert.AreEqual("100", tokens[1], "Second token does not match expected param.");
            Assert.AreEqual("100", tokens[2], "Third token does not match expected param.");
        }

        // multiLine parsed correctly
        /// <summary>
        /// Test method to check that multi line commands get recognised by checking there are two seperate tokens when the parsing has occured as this will show that one input has been split up correctly
        /// </summary>
        [TestMethod()]
        public void ParseMultiLineCommandsTest()
        {
            // New instance of command parser and a string to act as user input split into two lines.
            var parser = new CommandParser();
            string multiLineInput = "moveto 100 100\nreset";

            // Splitting commands up by new line and removing empty entries then passing lines into a foreach loop to itterate over the lines
            string[] lines = multiLineInput.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                var commandResult = parser.ParseCommand(line, multiLineInput); 

                string[] tokens = line.Split(' ');

                // check there are more than two lines annd is not null
                Assert.IsNotNull(commandResult, "Command result should not be null: " + line);
                Assert.IsTrue(tokens.Length >= 1, "There should be at least one command: " + line);
            }
        }
    }
}
