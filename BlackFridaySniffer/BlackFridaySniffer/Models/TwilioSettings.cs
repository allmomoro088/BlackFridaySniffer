using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackFridaySniffer.Models
{
    public class TwilioSettings
    {
        public string SenderPhone { get; set; }
        public string ReceiverPhone { get; set; }
        public string AccountSid { get; set; }
        public string AuthToken { get; set; }
    }
}
