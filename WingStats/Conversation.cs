using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingStats
{
    /// <summary>
    /// Keeps info, stats, and users for a conversation
    /// </summary>
    class Conversation
    {
        private string name;
        private int totalMessagesSent;
        private List<User> members;

        /// <summary>
        /// Create a new conversation instance
        /// </summary>
        /// <param name="name">The name of the conversation</param>
        public Conversation(string name)
        {
            this.name = name;

            members = new List<User>();
        }

        /// <summary>
        /// Add a new member to the conversation
        /// </summary>
        /// <param name="name"></param>
        public void addUser(string name)
        {
            this.members.Add(new User(name));
        }

        /// <summary>
        /// Add a message to the conversation
        /// </summary>
        public void addMessage(string name, string message)
        {
            foreach(User user in members)
            {
                if(user.getName() == name)
                {
                    user.addMessage(message);
                    totalMessagesSent++;
                }
            }
        }

        /// <summary>
        /// Prints all collected statistics
        /// </summary>
        public void printStats()
        {
            int totalWingsSent = 0;

            Console.WriteLine("Processing Stats....");
            Console.WriteLine("Total Messages Sent: " + totalMessagesSent);
            foreach(User user in members)
            {
                Console.WriteLine("User: " + user.getName() + "\n Total Wings Sent: " + user.getTotalWingSent() + "\n Total Messages Sent: " + user.getTotalMessagesSent());
                totalWingsSent += user.getTotalWingSent();
            }

            Console.WriteLine("Total Wing Messages: " + totalWingsSent);
            Console.WriteLine("Done. \n Press any key to exit");
        }
    }
}