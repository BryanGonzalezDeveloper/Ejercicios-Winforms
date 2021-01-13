using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Envio_de_correo_electronico
{
    class ClsEnvioCorreo
    {
        string remitente;
        string destinatario;
        string asunto;
      
       static string pass;
        public ClsEnvioCorreo(string remitente, string destinatario, string asunto)
        {
            this.remitente = remitente;
            this.destinatario = destinatario;
            this.asunto = asunto;
       
        }

        public static string Pass { get => pass; set => pass = value; }

        public  void enviar(string msj)
        {
            using(MailMessage objMsj =new MailMessage())
            {
                try
                {
                    SmtpClient smtp = new SmtpClient();
                    objMsj.From = new MailAddress(remitente);
                    objMsj.Subject = asunto;
                    objMsj.To.Add((destinatario));
                    objMsj.Body = msj;
                    smtp.Port = 587;
                    smtp.Host = "smtp.gmail.com";
                    smtp.UseDefaultCredentials = false;
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential(remitente, Pass);
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Send(objMsj);
                    smtp.Dispose();
                }
                catch (Exception ex)
                {

                    System.Windows.Forms.MessageBox.Show("ERROR: "+ex.Message);
                }
                
            }
        }
    }
}
