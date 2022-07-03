using BlackFridaySniffer.Models;
using BlackFridaySniffer.Services;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BlackFridaySniffer
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        ISnifferService _snifferService;
        IWhatsAppService _smsService;

        public Worker(ILogger<Worker> logger, ISnifferService snifferService, ISMSService smsService)
        {
            _logger = logger;
            _snifferService = snifferService;
            _smsService = smsService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _smsService.MessageSent += _smsService_MessageSent;
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                var goodPrices = _snifferService.SniffPrices();
                _smsService.SendGoodPrices(goodPrices.ToList());
                await Task.Delay(300000, stoppingToken);
            }
        }

        private void _smsService_MessageSent(object sender, EventArgs e)
        {
            _logger.LogInformation(((MessageSentEventArgs)e).Message, null);
        }
    }
}
