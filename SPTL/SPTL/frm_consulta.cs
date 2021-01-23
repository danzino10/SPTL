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

namespace SPTL
{
    public partial class frm_consulta : Form
    {
        public int user_id;
        public string Nome;
        public string Email;
        public int Telefone;
        public int NivelAcesso;


        //variaveis de cartao
        float saldo;
        int numero_cartao;
        string banco;

        public frm_consulta()
        {
            InitializeComponent();
        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void frm_consulta_Load(object sender, EventArgs e)
        {
            Conexao nova = new Conexao();
            nova.abrir();
            SqlCommand command = new SqlCommand();
            command.Connection = nova.SaberConexao();
            command.CommandText = "Select * From tb_cartao Where id_user = '" + user_id + "'";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                numero_cartao = int.Parse(reader.GetValue(0).ToString());
                banco = reader.GetString(1);
                saldo = float.Parse(reader.GetValue(2).ToString());
                cb_cartao.Items.Add(banco + " - " + numero_cartao);
            }

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            frm_principal jj = new frm_principal();
            jj.Id = user_id;
            jj.Nome = Nome;
            jj.Telefone = Telefone;
            jj.Email = Email;
            jj.Show();
            this.Hide();
        }

        private void labelX2_Click_1(object sender, EventArgs e)
        {

        }

        private void cb_cartao_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexao nova = new Conexao();
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
                }
                lbl_monatnte.Text = saldo + " Kz";
                nova.fechar();
            }
            catch(Exception er)
            {
                MessageBox.Show("erro " + er);
                nova.fechar();
            }
            
        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_monatnte_Click(object sender, EventArgs e)
        {

        }

        private void lbl_saldo_Click(object sender, EventArgs e)
        {

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {

        }

    }
}
