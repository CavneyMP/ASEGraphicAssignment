using ASEGraphicAssignment.Commands;
using ASEGraphicAssignment.Parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASEGraphicAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void MultiLine_TextChanged(object sender, EventArgs e)
        {

        }

        private void SyntaxButton_Click(object sender, EventArgs e)
        {

        }

        private void GraphicPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Runbutton_Click(object sender, EventArgs e)
        {
            var input = Singleline.Text;
            var multiLineContent = MultiLine.Text; // Assuming MultiLineTextBox is the name of your multi-line text box
            var parser = new CommandParser();
            var command = parser.ParseCommand(input, multiLineContent);
            var graphics = GraphicPanel.CreateGraphics();

            command.Execute(graphics);
        }

        private void Singleline_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SyntaxReportBox(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// MultiLineRunBtn_Click holds the logic to retreive the text from the multiLine text box. Text and split it into a string array and seperates it by line
        /// The command parsers is the called to parse each command and the graphics is exeucte for each line. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MultiLineRunBtn_Click(object sender, EventArgs e)
        {
            // Split text into lines
            string multiLineTextContent = MultiLine.Text;

            // Retrieve the graphics object
            Graphics graphics = GraphicPanel.CreateGraphics();

            // Create a new CommandParser instance
            CommandParser parser = new CommandParser();

            // Split the text from MultiLine into lines
            string[] lines = multiLineTextContent.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            // Loop through each line and execute the command
            foreach (string line in lines)
            {
                try
                {
                    // Parse each line with the multiLineTextContent
                    ICommandInterface command = parser.ParseCommand(line, multiLineTextContent);

                    // Execute the command
                    command.Execute(graphics);
                }
                catch (Exception TBD)
                {
                
                }
            }

        }
    }
}

