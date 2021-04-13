using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerMaker.Services
{    
    // tutaj już bez zmian
    public interface IMailService
    {
        Task SendMail(string recipient, string subject, string template, Dictionary<string, string> settings);
    }
    public class MailService : IMailService
    {
        private readonly ILogger<MailService> _logger;

        public Task SendMail(string recipient, string subject, string template, Dictionary<string, string> settings)
        {
            throw new NotImplementedException();
        }
    }
}
