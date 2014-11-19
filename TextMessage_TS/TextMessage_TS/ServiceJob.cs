using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using System.IO.Compression;
using System.Diagnostics;
using System.Net.Mail;

namespace TextMessage_TS
{
    class ServiceJob : IJob
    {
        const long THRESHOLD = 13000;

        public ServiceJob()
        {
        }

        public void Execute(IJobExecutionContext context)
        {
            PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            var ram = ramCounter.NextValue();
            if (ram < THRESHOLD)
            {
                sendEmailText(ram);
            }
            Console.WriteLine(String.Format("Available RAM: {0} MB", ram));
        }

        public void sendEmailText(float ram)
        {
            MailMessage mail = new MailMessage("mike.melusky@gmail.com", "7173437075@tmomail.net");
            SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = "localhost";
            mail.Subject = "RAM LOW";
            mail.Body = String.Format("available RAM remaining: {0}", ram);
            client.Send(mail);
        }
    }
}
