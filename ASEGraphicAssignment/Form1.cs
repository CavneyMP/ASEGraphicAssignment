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
            var parser = new CommandParser();
            var command = parser.ParseCommand(input); 
            var graphics = GraphicPanel.CreateGraphics();

            command.Execute(graphics); 
        }

        private void Singleline_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
