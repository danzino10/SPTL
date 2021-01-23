using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Globalization;
namespace SPTL
{
    public partial class frm_registo : Form
    {
        public frm_registo()
        {
            InitializeComponent();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            txt_email.Text = "";
            txt_nome.Text = "";
            txt_telefone.Text = "";
            txt_senha.Text = "";
            txt_senha.PasswordChar = '*';
            txt_senha2.Text = "";
            checkBox1.Checked = false;
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_senha.PasswordChar == '*')
            {
                txt_senha.PasswordChar = ' ';
            }
            else
            {
                txt_senha.PasswordChar = '*';
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_senha.Text == txt_senha2.Text)
                {
                    Conexao nova = new Conexao();
                    nova.abrir();
                    SqlCommand command = new SqlCommand();
                    command.Connection = nova.SaberConexao();
                    DateTime myDateTime = DateTime.Now;
                    string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                    command.CommandText = "INSERT INTO tb_user (nome, email, password, telefone, nivel_acesso, data_hora) VALUES ('" + txt_nome.Text + "','" + txt_email.Text + "','" + txt_senha.Text + "','" + txt_telefone.Text + "','1','" + sqlFormattedDate + "')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Usuário adicionado a frota com sucesso");
                    nova.fechar();
                    this.Close();

                    // instanciar email
                    SmtpClient cliente = new SmtpClient();
                    NetworkCredential credencial = new NetworkCredential();

                    // configurar cliente
                    cliente.Host = "smtp.gmail.com";
                    cliente.Port = 587;
                    cliente.EnableSsl = true;
                    cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
                    cliente.UseDefaultCredentials = false;

                    //configurar credenciais de acesso ao email

                    credencial.UserName = "danzino10";
                    credencial.Password = "MestreFigas12";

                    //configurar credenciais no cliente
                    cliente.Credentials = credencial;


                    //preparar a mensagem de email
                    MailMessage sms = new MailMessage();
                    sms.From = new MailAddress("danzino10@gmail.com");
                    sms.Subject = "Express, o seu dinheiro em um clique";
                    sms.Body = "Bem vindo ao Express no seu Windows ";
                    sms.Body += "No caso de Alguma dúvida contacte os desenvolvedores do sistema directamente pelos seguintes endereços";
                    sms.Body += "Email: danzino10@gmail.com ";
                    sms.Body += "Telefone 1: +244 936530760 ";
                    sms.Body += "Telefone 2: +244 912599797 ";
                    sms.To.Add(txt_email.Text);

                    //envio do email
                    cliente.Send(sms);

                    frm_principal h = new frm_principal();
                    h.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Palavras-passes incompatíveis ");
                    txt_senha.Text = "";
                    txt_senha2.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, conexão falhada" + ex);
            }
        }
    }
}
