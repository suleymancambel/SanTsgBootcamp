using SanTsgBootcamp.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SanTsgBootcamp.Application.Interfaces
{
    public interface IEmailServices
    {
        Task SendMailAsync(EmailRequest emailRequest);
    }
}
