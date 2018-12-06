using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Xml;

namespace WingStats
{
    /// <summary>
    /// Entry point of the application
    /// Creates a new window instance
    /// </summary>
    class Start
    {
        [STAThread]
        static void Main(string[] args)
        {
            using (WingStatsForm window = new WingStatsForm())
            {
                window.ShowDialog();
            }

            /*selectFileDialog = new WingStatsForm();

            selectFileDialog.ShowDialog();

            ParseConversationJSON();
            wingsForTheFellas = new Conversation("Wings For The Fellas");

            ParseParticipants();
            ParseMessages();

            wingsForTheFellas.printStats();
            */
   
            Console.Read();
        }
    }
}
