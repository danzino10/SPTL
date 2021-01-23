using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPTL
{
    public partial class frm_principal : Form
    {
        public int Id;
        public string Nome;
        public string Email;
        public int Telefone;
        public int NivelAcesso;

        public frm_principal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lbl_Data.Text = DateTime.Now.ToString("d");
            lbl_hora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btn_visualização_Click(object sender, EventArgs e)
        {
            frm_tranferencia hh = new frm_tranferencia();
            hh.user_id = Id;
            hh.Show();
            this.Hide();
        }

        private void btn_cadUsua_Click(object sender, EventArgs e)
        {

        }

        private void btn_cadFor_Click(object sender, EventArgs e)
        {

        }

        private void frm_principal_Load(object sender, EventArgs e)
        {

        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Cadastro_Click(object sender, EventArgs e)
        {
            frm_consulta kk = new frm_consulta();
            kk.user_id = Id;
           
            kk.Show();
            this.Hide();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            frm_levantamento gg = new frm_levantamento();
            gg.Show();
            this.Hide();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            frm_recargas r = new frm_recargas();
            r.Show();
            this.Hide();
        }
    }
}
