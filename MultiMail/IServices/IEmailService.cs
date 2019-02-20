using System.Threading.Tasks;

namespace MultiMail
{
    public interface IEmailService
    {
        Task SendEmail(string email, string subject, string message);
    }
}
