using System;
using System.Net.Mail;

namespace BeforeSRP
{
    /*The problem of this class is that it has a lot of responsibilities: 
     * 1.GenerateReport (that is ok)
     * 2.Sending an email (not ok) 
     * 3.Logging error to file (not ok) 
     * 
      We have to modify the class in such way to have only the responsibility for generating of
      reports (as the name suggests). The other responsibilities should be managed from different classes*/

    public class ReportGenerator
    {
        public void GenerateReport()
        {
            try
            {
                // Code for generating the report
                // ...

                // Send the report via email
                MailMessage mailMessage = new MailMessage("from@example.com", "to@example.com", "Report", "Here is the report.");
                SendReportEmail(mailMessage);
            }
            catch (Exception ex)
            {
                // Error Logging
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }

        public void SendReportEmail(MailMessage mailMessage)
        {
            try
            {
                // Code for sending email
                // ...
            }
            catch (Exception ex)
            {
                // Error Logging
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }
    }

}
