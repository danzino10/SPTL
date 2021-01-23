using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;

namespace SPTL
{
    public partial class frm_tranferencia : Form
    {
        public int user_id;
        public string Nome;
        public string Email;
        public int Telefone;
        public int NivelAcesso;

        Conexao nova = new Conexao();
        float saldo;
        int iban, iban2;
        public frm_tranferencia()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            frm_principal gg = new frm_principal();
            gg.Show();
            this.Hide();
        }

        private void cb_cartao_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {

                nova.abrir();
                SqlCommand command = new SqlCommand();
                command.Connection = nova.SaberConexao();
                string num_cartao = cb_cartao.SelectedItem.ToString();
                string[] palavras = num_cartao.Split('-');
                command.CommandText = "Select * From tb_cartao Where numero_cartao = '" + palavras[1] + "'";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    saldo = float.Parse(reader.GetValue(2).ToString());
                    iban = int.Parse(reader.GetValue(5).ToString());
                }
                nova.fechar();
            }
            catch (Exception er)
            {
                MessageBox.Show("erro " + er);
                nova.fechar();
            }
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception er)
            {
                MessageBox.Show("Erro " + er);
                nova.fechar();
            }
        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            if(txt_iban.TextLength == txt_iban.MaxLength)
            {
                try
                {

                nova.abrir();
                SqlCommand command = new SqlCommand();
                command.Connection = nova.SaberConexao();
                string num_cartao = cb_cartao.SelectedItem.ToString();
                command.CommandText = "Select * From tb_cartao Where numero_cartao = '" + num_cartao + "'";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                    {
                        lbl_nome.Text = reader.GetString(2);
                    }
                btn_entrar.Enabled = false;

                nova.fechar();
                }
                catch (Exception er)
                {
                    MessageBox.Show("erro " + er);
                    nova.fechar();
                }
            }
        }
    }
}
