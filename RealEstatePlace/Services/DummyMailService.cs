using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace VotingPoint.Services
{
    public class DummyMailService : IDummyMailService
    {
        private readonly ILogger<DummyMailService> _logger;

        public DummyMailService(ILogger<DummyMailService> logger)
        {
            _logger = logger;
        }
        public void SendMesaage(string to, string subject, string body)
        {
            _logger.LogInformation($"To: {to} Subject: {subject} Body: {body}");
        }
    }
}
