using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiMail
{
    public interface IEmailService
    {
        Task SendEmail(string email, string message);
    }
}
