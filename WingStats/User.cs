using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingStats
{
    /// <summary>
    /// Contains message statistics for a single user
    /// </summary>
    class User
    {
        private string name;
        private int wingsSent;
        private List<string> messages;

        /// <summary>
        /// Creates a new user
        /// </summary>
        /// <param name="name">The user's name</param>
        public User(string name)
        {
            this.name = name;

            wingsSent = 0;
            messages = new List<string>();
        }

        /// <summary>
        /// Add a message that this user has sent
        /// </summary>
        /// <param name="messageContents">Contents of the message sent</param>
        public void addMessage(string messageContents)
        {
            if(messageContents.Contains("\u00f0\u009f\u008d\u0097"))
            {
                wingsSent++;
            }
            this.messages.Add(messageContents);
        }
        
        /// <summary>
        /// Get accessor for the name variable
        /// </summary>
        /// <returns>The user's name</returns>
        public string getName()
        {
            return this.name;
        }

        /// <summary>
        /// Get the number of wings this user has sent
        /// </summary>
        /// <returns>The number of wings this user has sent</returns>
        public int getTotalWingSent()
        {
            return this.wingsSent;
        }
    }
}
