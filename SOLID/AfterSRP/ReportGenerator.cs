using System.Net.Mail;

namespace AfterSRP
{
    public class ReportGenerator
    {
        /*Here are used separate classes for email sending and logging of errors.
         They are injected via constructor through interfaces. 
         Now each class has own responsibility and the SRP principle is not violated. 
        */
        
        private readonly IEmailSender _emailSender;
        private readonly ILogger _logger;


        //Here it is used dependency injection (adhering to Dependency Inversion Principle)
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
