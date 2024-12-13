using System.Net.Mail;

namespace AfterSRP
{
    public class ReportGenerator
    {
        private readonly IEmailSender _emailSender;
        private readonly ILogger _logger;

        public ReportGenerator(IEmailSender emailSender, ILogger logger)
        {
            _emailSender = emailSender;
            _logger = logger;
        }

        public void GenerateReport()
        {
            try
            {
                // Code for generating the report
                // ...

                // Send the report via email
                MailMessage mailMessage = new MailMessage("from@example.com", "to@example.com", "Report", "Here is the report.");
                _emailSender.SendEmail(mailMessage);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex);
            }
        }
    }

}
