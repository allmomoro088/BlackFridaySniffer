using BlackFridaySniffer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Rest.Api.V2010.Account;

namespace BlackFridaySniffer.Services
{
    public interface ISMSService
    {
        event EventHandler MessageSent;
        void SendGoodPrices(List<Product> goodPrices);
        void SendSMS(string body);
    }
}
