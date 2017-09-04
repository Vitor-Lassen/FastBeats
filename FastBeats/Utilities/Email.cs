using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;


namespace FastBeats.DB
{
    class Email
    {
        public void enviarEmail(Form frm, string para, string titulo, string mensagem)
        {
            try
            {
                System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
                message.To.Add(para);
                message.Subject = titulo;
                message.From = new System.Net.Mail.MailAddress("fastbeats.suporte@gmail.com");
                message.Body = mensagem;
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("fastbeats.suporte@gmail.com", "fastcoding");
                smtp.EnableSsl = true;
                smtp.Send(message);

                MetroMessageBox.Show(frm, "Email enviado com sucesso!", "Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MetroMessageBox.Show(frm, "Não foi possivel enviar o email tente novamente!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
