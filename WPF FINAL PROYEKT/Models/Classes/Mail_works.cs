using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interop;
using System.Windows;

namespace WPF_FINAL_PROYEKT.Models.Classes
{
    public class Mail_works
    {

        public static bool CheckEmailFormat(string email)
        {
            if (email.Contains("@") && email.Contains(".com"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int SendEmail(string to)
        {
            try
            {
                var client = new SmtpClient("smtp.gmail.com", 587)
                {
                    EnableSsl = true,
                    Credentials = new NetworkCredential("denemeeeer10@gmail.com", "bwcg sopr cxht nlrn")
                };

                Random rand = new Random();
                int verificationCode = rand.Next(10000, 99999);

                string htmlMessage = $@"
                    <!DOCTYPE html>
                    <html lang=""en"">
                    <head>
                        <meta charset=""UTF-8"">
                        <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
                        <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                        <title>Email Message</title>
                        <style>
                            body {{
                                font-family: Arial, sans-serif;
                                background-color: #f4f4f4;
                                margin: 0;
                                padding: 0;
                            }}
                            .container {{
                                width: 80%;
                                margin: 20px auto;
                                background-color: #fff;
                                padding: 20px;
                                border-radius: 8px;
                                box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
                            }}
                            h1 {{
                                color: #333;
                                text-align: center;
                            }}
                            p {{
                                color: #666;
                                line-height: 1.6;
                            }}
                            .code {{
                                font-weight: bold;
                                color: #007bff;
                                font-size: 24px;
                            }}
                        </style>
                    </head>
                    <body>
                        <div class=""container"">
                            <h1>FindFootball Doğrulama Kodunuz</h1>
                            <p>
                                FindFootball doğrulama kodunuz aşağıdaki gibidir:
                            </p>
                            <p class=""code"">{verificationCode}</p>
                        </div>
                    </body>
                    </html>
                ";

                var message = new MailMessage()
                {
                    Subject = "FindFootball Doğrulama Kodu",
                    Body = htmlMessage,
                    IsBodyHtml = true,
                    From = new MailAddress("denemeeeer10@gmail.com", "FindFootball")
                };

                if (CheckEmailFormat(to))
                {
                    message.To.Add(new MailAddress(to));
                    client.Send(message);
                    MessageBox.Show("Succesfully");
                    return verificationCode;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
