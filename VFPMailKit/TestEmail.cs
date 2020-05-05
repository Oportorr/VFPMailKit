using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VFPMailKit
{
    public partial class TestEmail : Form
    {
        public TestEmail()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Casino", txtUser.Text));
            message.To.Add(new MailboxAddress(txtTo.Text));
            message.To.Add(new MailboxAddress("oportorreal@digepres.gob.do"));
            message.Priority = MessagePriority.Urgent;
            message.Subject = txtSubject.Text;
            message.Body = new TextPart("plain")
            {
                Text = txtBody.Text
            };

            var builder = new BodyBuilder();
           // builder.HtmlBody = htmlContent;
            builder.TextBody = txtBody.Text;
            //string path = "C:\\Users\\oscar\\Pictures\\Revolver.png";

            string path = "D:\\C#TOOLS\\C# Screens.pdf";

            var attachment = new MimePart("file", "pdf")
            {
                Content = new MimeContent(File.OpenRead(path)),
                ContentDisposition = new ContentDisposition(ContentDisposition.Inline),
                ContentTransferEncoding = ContentEncoding.Base64,
                FileName = Path.GetFileName(path)
            };

            var multipart = new Multipart("mixed");
            multipart.Add(message.Body);
            multipart.Add(attachment);

            // now set the multipart/mixed as the message body
            message.Body = multipart;



            //OP - Regular Attachments
            //builder.Attachments.Add("D:\\C#TOOLS\\C# Screens.pdf");
            //builder.Attachments.Add("D:\\C#TOOLS\\VFP Screens.pdf");
            //message.Body = builder.ToMessageBody();


            using (var client = new SmtpClient())
            {

                try
                {
                  //client.MessageSent += (var sender, args) => { args.Response };

                    client.Connect("smtp.gmail.com", int.Parse(txtPort.Text), SecureSocketOptions.StartTls);
                   // client.Timeout = 2000;

                    // Note: since we don't have an OAuth2 token, disable
                    // the XOAUTH2 authentication mechanism.

                   // client.AuthenticationMechanisms.Remove("XOAUTH2");

                    // Note: only needed if the SMTP server requires authentication
                    client.Authenticate(txtUser.Text, txtPass.Text);

                    client.Send(message);
                    client.Disconnect(true);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

                MessageBox.Show("Message Box Sent Succefully");

            };
            //client.Disconnect(true);




        }
         private void txtUser_TextChanged(object sender, EventArgs e)
        {
            txtFrom.Text = txtUser.Text;
        }

        private void TestEmail_Load(object sender, EventArgs e)
        {
            txtFrom.Text = txtUser.Text;
            cboPriority.SelectedIndex = 0;
            cboSsl.SelectedIndex = 0;
        }
    }
}
