using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Dot.Net._6.WF.Calendario.Senac
{
    public partial class enviarCodigo : Form
    {
        string randomCode;
        public static string de;
        public enviarCodigo()
        {
            InitializeComponent();
        }

        private void btnEnviarCodigo_Click(object sender, EventArgs e)
        {
            string para, senha, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            de = (txtEmail.Text).ToString();
            para = txtEmail.Text;
            senha = txtValidar.Text;
            messageBody = "O seu código é:" + randomCode;
            message.To.Add(para);
            message.From = new MailAddress(de);
            message.Body = messageBody;
            message.Subject = " código para alterar a senha";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(para, senha);

            try
            {
                smtp.Send(message);
                MessageBox.Show("O código foi enviado com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (randomCode == (txtValidar.Text).ToString())
            {
                de = txtEmail.Text;
                ResetarSenha resetarSenha = new ResetarSenha();
                this.Hide();
                resetarSenha.Show();
            }
            else
            {
                MessageBox.Show("O código não é válido.");
            }
        }
    }
}
