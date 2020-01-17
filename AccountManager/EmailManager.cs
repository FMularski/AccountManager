using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;

namespace AccountManager
{
    class EmailManager
    {
        public static void SendEmail(string to, string msgType, params string[] data)
        {
            try
            {
                SmtpClient smtp = new SmtpClient();
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.Timeout = 10000;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(EmailManagerAccountData.Login, EmailManagerAccountData.Password);

                MailMessage mail = new MailMessage(EmailManagerAccountData.Login, to);
                mail.BodyEncoding = UTF8Encoding.UTF8;

                string subject = "";
                string body = "";

                switch (msgType)
                {
                    case "greeting":
                        subject = $"Hello {data[0]}!";
                        body = "Thank you for registering to Account Manager. Please verify your email address by " +
                            "entering verification code in your client window.\nPlease scroll down to see your code" +
                            ".\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n" +
                            ".\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n.\n" +
                            $"Verification code: {data[1]}\n Always remember to keep your account safe!";

                        break;
                }

                mail.Subject = subject;
                mail.Body = body;

                smtp.Send(mail);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
            
        }
    }
}
