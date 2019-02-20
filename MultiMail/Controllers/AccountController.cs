using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using MultiMail.Services;
using System.Threading.Tasks;

namespace MultiMail.Controllers
{
    public class AccountController
    {
        private readonly IEmailService _emailService;
        public AccountController(IEmailService emailService)
        {
            _emailService = emailService;
        }
        [HttpPost]
        [Route("account/send-email")]
        public async Task<IActionResult> SendEmailAsync(string email, string subject, string message)
        {
            await _emailService.SendEmail(email, subject, message);
            //return Ok();
            return null;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddTransient<IEmailService, EmailService>();
        }
    }
}
