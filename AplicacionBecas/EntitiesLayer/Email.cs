// The following example codes demonstrate sending email message using Gmail SMTP server
// To get full sample projects, please download and install EASendMail on your machine.
// To run it correctly, please change SMTP server, user, password, sender, recipient value to yours

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using EASendMail;

namespace EntitiesLayer 
{

    public class Email : IEntity
    {

        private int _idEmail;
        public int Id
        {
            get { return _idEmail; }
            set { _idEmail = value; }
        }

        SmtpMail oMail = new SmtpMail("TryIt");
        SmtpClient oSmtp = new SmtpClient();
        public String receptor { get; set; }
        public String emisor { get; set; }
        public String asunto { get; set; }
        public String mensaje { get; set; }
        public String smtpServidor { get; set; }
        public String userName { get; set; }
        public String contrasenna { get; set; }

        public Email(String pemisor, String pasunto, String pmensaje, String psmtpServidor, String puserName, String pcontrasenna)
        {
            emisor = pemisor;
            asunto = pasunto;
            mensaje = pmensaje;
            smtpServidor = psmtpServidor;
            userName = puserName;
            contrasenna = pcontrasenna;
        }

        public Email()
        {
            
        }

        public void envioEmail(){
            
            // Your gmail email address
            //oMail.From = "gmailid@gmail.com";
            oMail.From = emisor;

            // Set recipient email address
            //oMail.To = "support@emailarchitect.net";
            oMail.To = receptor;

            // Set email subject
            //oMail.Subject = "test email from gmail account";
            oMail.Subject = asunto;

            // Set email body
            //oMail.TextBody = "this is a test email sent from c# project with gmail.";
            oMail.TextBody = mensaje;

            // Gmail SMTP server address
            //SmtpServer oServer = new SmtpServer("smtp.gmail.com");
            SmtpServer oServer = new SmtpServer(smtpServidor);

            // If you want to use direct SSL 465 port,
            // please add this line, otherwise TLS will be used.
            // oServer.Port = 465;

            // detect SSL/TLS automatically
            oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;

            // Gmail user authentication
            // For example: your email is "gmailid@gmail.com", then the user should be the same
            oServer.User = userName;
            oServer.Password = contrasenna;

            try
            {
                Console.WriteLine("start to send email over SSL ...");
                oSmtp.SendMail(oServer, oMail);
                Console.WriteLine("email was sent successfully!");
            }
            catch (Exception ep)
            {
                Console.WriteLine("failed to send email with the following error:");
                Console.WriteLine(ep.Message);
            }
        }
    }
}