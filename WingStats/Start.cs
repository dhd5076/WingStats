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

            ParseParticipants();
            ParseMessages();

            Console.Read();
        }

        /// <summary>
        /// Get all participants and add them to the conversation object
        /// </summary>
        public static void ParseMessages()
        {
            Console.WriteLine("Parsing messages...");
            foreach (XmlElement message in RAWConvoObject.GetElementsByTagName("messages"))
            {
                string messageSender = message.GetElementsByTagName("sender_name")[0].InnerText;
                string messageContents = "";
                try
                {
                    messageContents = message.GetElementsByTagName("content")[0].ToString();
                }
                catch(NullReferenceException e)
                {
                    //TODO: This is a temporary fix, photo messages don't have any text content
                }

                wingsForTheFellas.addMessage(messageSender, messageContents);
            }
            Console.WriteLine("Done.");
        }

        /// <summary>
        /// Get all participants and add them to the conversation object
        /// </summary>
        public static void ParseParticipants()
        {
            Console.WriteLine("Parsing users...");
            foreach (XmlNode participant in RAWConvoObject.GetElementsByTagName("participants"))
            {
                Console.WriteLine("User Found: " + participant.InnerText);
                wingsForTheFellas.addUser(participant.InnerText);
            }
            Console.WriteLine("Done.");
        }

        /// <summary>
        /// Parse the raw conversation JSON data into an object
        /// </summary>
        public static void ParseConversationJSON()
        {
            Console.WriteLine("Parsing raw data...");
            string wingStatJSON = File.ReadAllText("message.json");
            RAWConvoObject = JsonConvert.DeserializeXmlNode(wingStatJSON, "Root");
            Console.WriteLine("Done.");
        }
    }
}
