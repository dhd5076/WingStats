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
        /// 
        /// </summary>
        /// <param name="name">The name of the conversation</param>
        public Conversation(string name)
        {
            this.name = name;
        }
    }
}
