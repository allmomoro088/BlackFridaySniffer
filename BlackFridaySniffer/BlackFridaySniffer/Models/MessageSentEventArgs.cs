using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackFridaySniffer.Models
{
    public class MessageSentEventArgs : EventArgs
    {
        public MessageSentEventArgs(string message)
        {
            Message = message;
        }
        public string Message { get; set; }
    }
}
