using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
using System.IO;
using System.Configuration;

namespace RegisterPage
{
    class MailDelivery
    {
        public bool SendMail(string to, string asunto, string body)
        {
            bool result = true;
            //string from = "RumMichy@outlook.com";
            string from = "sanchezbass021221@hotmail.com";
            string displayName = "RumMichy";
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from, displayName);
                mail.To.Add(to);

                mail.Subject = asunto;
                //mail.Body = body;
                mail.IsBodyHtml = true;

                AlternateView htmlView = AlternateView.CreateAlternateViewFromString(body, null, "text/html");

                string currentDirectory = Environment.CurrentDirectory;
                DirectoryInfo directory = new DirectoryInfo(
                    Path.GetFullPath(Path.Combine(currentDirectory, @"..\..\" + @"Images\")));               

                string headerDirectory = directory + "HeaderBackground.png";                
                LinkedResource headerImage = new LinkedResource(headerDirectory.ToString());
                headerImage.ContentId = "background";

                string smallMichyDirectory = directory + "SmallMichy.png";               
                LinkedResource smallMichyImage = new LinkedResource(smallMichyDirectory.ToString());
                smallMichyImage.ContentId = "smallMichyID";

                string footPrintDirectory = directory + "FootPrint.png";               
                LinkedResource footPrintImage = new LinkedResource(footPrintDirectory.ToString());
                footPrintImage.ContentId = "footPrintID";

                htmlView.LinkedResources.Add(headerImage);
                htmlView.LinkedResources.Add(smallMichyImage);
                htmlView.LinkedResources.Add(footPrintImage);
                mail.AlternateViews.Add(htmlView);


                SmtpClient client = new SmtpClient("smtp.office365.com", 587);
              
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;

                //string emailPassword = Decrypt("/U68x4k0VsCzSS+9YB/3lA==");
                string emailPassword = "RodrigoBass12";

                client.Credentials = new NetworkCredential(from, emailPassword);
                client.Send(mail);                                                    

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = false;
            }

            return result;
        }


        static readonly string password = "P455W0rd";

        public static string Decrypt(string encryptedText)
        {
            if (encryptedText == null)
            {
                return null;
            }
            
            var bytesToBeDecrypted = Convert.FromBase64String(encryptedText);
            var passwordBytes = Encoding.UTF8.GetBytes(password);

            passwordBytes = SHA512.Create().ComputeHash(passwordBytes);

            var bytesDecrypted = Decrypt(bytesToBeDecrypted, passwordBytes);

            return Encoding.UTF8.GetString(bytesDecrypted);
        }

        private static byte[] Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;
            var saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);

                    AES.KeySize = 256;
                    AES.BlockSize = 128;
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);
                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        cs.Close();
                    }

                    decryptedBytes = ms.ToArray();
                }
            }

            return decryptedBytes;
        }

       

    }
}