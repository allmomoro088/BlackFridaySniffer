using BlackFridaySniffer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace BlackFridaySniffer.Services.Handlers
{
    public class DefaultSMSService : ISMSService
    {
        TwilioSettings _twilioSettings;

        public event EventHandler MessageSent;
        protected virtual void OnMessageSent(MessageSentEventArgs e)
        {
            MessageSent?.Invoke(this, e);
        }

        public DefaultSMSService(TwilioSettings twilioSettings)
        {
            _twilioSettings = twilioSettings;
        }

        public void SendGoodPrices(List<Product> goodPrices)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Best prices: ");
            foreach (var item in goodPrices)
            {
                sb.Append($"\n*{item.Name}* - {item.CurrentPrice}; ");
            }
            SendSMS(sb.ToString());
        }

        public void SendSMS(string body)
        {
            TwilioClient.Init(_twilioSettings.AccountSid, _twilioSettings.AuthToken);

            MessageResource.Create(
                body: body,
                from: new Twilio.Types.PhoneNumber(_twilioSettings.SenderPhone),
                to: new Twilio.Types.PhoneNumber(_twilioSettings.ReceiverPhone)
                );
            OnMessageSent(new MessageSentEventArgs(body));
        }
    }
}
