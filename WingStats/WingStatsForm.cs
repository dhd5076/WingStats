using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WingStats
{
    public partial class WingStatsForm : Form
    {
        private Parser convoParser;

        public WingStatsForm()
        {
            InitializeComponent();
            convoParser = new Parser();
        }

        private void ParseFileClicked(object sender, EventArgs e)
        {

                convoParser.wingsForTheFellas = new Conversation("Wings For The Fellas");

                convoParser.ParseParticipants();
                convoParser.ParseMessages();

                convoParser.wingsForTheFellas.printStats();
        }

        private void OpenFileClicked(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Conversation File (message.json)|message.json";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileTextBox.Text = openFileDialog.FileName;
                    var filePath = fileTextBox.Text;

                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        var fileContent = reader.ReadToEnd();
                        convoParser.ParseConversationJSON(fileContent);
                    }
                }
            }
        }

        private void WingStatsForm_Load(object sender, EventArgs e)
        {

        }

    }
}
