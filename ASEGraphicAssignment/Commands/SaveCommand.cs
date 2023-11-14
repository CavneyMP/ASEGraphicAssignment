using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASEGraphicAssignment.Commands
{
    /// <summary>
    /// Saves the current commands shown in the multi line command to a file.
    /// </summary>
    public class SaveCommand : ICommandInterface
    {
        private string _filePath;
        private string _contentToSave;

        public SaveCommand(string filePath, string contentToSave)
        {
            _filePath = filePath;
            _contentToSave = contentToSave;
        }

        public void Execute(Graphics graphics)
        {
            // Graphics context is not used in SaveCommand
            File.WriteAllText(_filePath, _contentToSave);
        }
    }
}
    
