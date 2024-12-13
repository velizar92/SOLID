using System.Net.Mail;

namespace AfterSRP
{
    public interface IEmailSender
    {
        void SendEmail(MailMessage mailMessage);
    }
}
