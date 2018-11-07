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
    /// Creates a new conversation and adds all users 
    /// Next all users are updated with the messages they have sent
    /// </summary>
    class Start
    {
        public static Conversation wingsForTheFellas;
        public static XmlDocument RAWConvoObject;

        static void Main(string[] args)
        {
            ParseConversationJSON();
            wingsForTheFellas = new Conversation("Wings For The Fellas");


            foreach(XmlNode participant in RAWConvoObject.GetElementsByTagName("participants"))
            {
                Console.WriteLine(participant.InnerText);
            }

            ParseParticipants();
            Console.Read();
        }

        public static void ParseParticipants()
        {
            
        }

        /// <summary>
        /// Parse the raw conversation JSON data into an object
        /// </summary>
        public static void ParseConversationJSON()
        {
            string wingStatJSON = File.ReadAllText("message.json");
            RAWConvoObject = JsonConvert.DeserializeXmlNode(wingStatJSON, "Root");
            
        }
    }
}
