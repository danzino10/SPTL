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
using System.Data.Sql;
using System.Globalization;
namespace SPTL
{
    public partial class frm_login : Form
    {
        //variaveis publicas para armazenar dados do usuário
        public int ID;
        public string Nome;
        public string Email;
        public int Telefone;
        public int NivelAcesso;
        //public int codigo;

        public frm_login()
        {
            InitializeComponent();

        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }

        //botao de sair: sai da aplicação
        private void buttonX1_Click(object sender, EventArgs e)
        {
            //comando para fechar aplicação
            Application.Exit();
        }


        //Botao de entrar: verifica as credenciais
        private void btn_entrar_Click(object sender, EventArgs e)
        {
            //caminho para a base de dados
            string conexao = @"Data Source=DANZ\SQLEXPRESS;Initial Catalog=Express;Integrated Security=True";

            //cria conexão com base de dados
            SqlConnection conn = new SqlConnection(conexao);
                //abre a conexao
                conn.Open();

                //instancia comando SQL
                SqlCommand command = new SqlCommand();
                //atribui conexao ao comando
                command.Connection = conn;
                //atribui texto de consulta para a base de dados
                command.CommandText = "SELECT * from tb_user where nome = '" + txt_user.Text + "' AND password = '" + txt_senha.Text + "'";
                //executa leitura na base de dados
                SqlDataReader reader = command.ExecuteReader();
                //conta o numero de usuarios existentes na base de dados com as credenciais introduzidas
                int count = 0;
                //codigo para armazenar dados da base dados na aplicação
                while (reader.Read())
                {
                    count++;
                    ID = int.Parse(reader.GetValue(0).ToString());
                    Nome = reader.GetString(1);
                    Email = reader.GetString(3);
                    Telefone = int.Parse(reader.GetValue(2).ToString());
                }
                //Caso haja pelo menos um usuario existente
                if (count == 1)
                {
                    //mensagem de confirmação
                    MessageBox.Show("Usuário e Password correctos");
                    //fecha conexão
                    conn.Close();
                    try
                    {
                        //reabre conexão
                        conn.Open();
                        //cria novo comando com conexão e texto
                        SqlCommand command2 = new SqlCommand();
                        command2.Connection = conn;
                        command2.CommandText = "UPDATE tb_user set data_hora = '" + DateTime.Now + "' Where id_user = " + ID;
                        //executa a consulta
                        command.ExecuteNonQuery();
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Erro," + er);
                    }

                    //fecha novamente a conexão
                    conn.Close();
                    //esconde a pagina de login
                    this.Hide();
                    //abre nova pagina
                    frm_principal h = new frm_principal();
                    h.Id = ID;
                    h.Email = Email;
                    h.Telefone = Telefone;
                    h.ShowDialog();

                }
                //caso hajam mais de um usuario com as mesmas credenciais
                else if (count > 1)
                {
                    MessageBox.Show("Mais de um usuário existente");
                    conn.Close();
                }
                //caso nao haja nenhum usuario com estas credenciais 
                else
                {
                    MessageBox.Show("Usuário e/ou Password incorrectos");
                    conn.Close();
                }


        }

        private void frm_login_Load(object sender, EventArgs e)
        {
                btn_entrar.Enabled = false;
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {
                btn_entrar.Enabled = true;
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {
            btn_entrar.Enabled = true;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            frm_registo registo = new frm_registo();
            registo.ShowDialog();
            this.Hide();
        }
    }
}
