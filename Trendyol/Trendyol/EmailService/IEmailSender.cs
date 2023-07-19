using System.Threading.Tasks;

namespace Trendyol.EmailService
{
    public interface IEmailSender
    {
        // smtp => gmail, hotmail
        // api  => sendgrid

        Task SendEmailAsync(string email, string subject, string htmlMessage);

    }
}
