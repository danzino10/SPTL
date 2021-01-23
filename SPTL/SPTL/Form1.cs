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
    public partial class frm_splash : Form
    {
        int cont;
        public frm_splash()
        {
            InitializeComponent();
        }

        private void frm_splash_Load(object sender, EventArgs e)
        {
            cont = 0;
            
        }

        private void tmr_contagen_Tick(object sender, EventArgs e)
        {
            if (cont <= 100)
            {
                cont = cont + 1;

                if (cont == 30)
                {
                    lbl_titulo.Text = "Carregando formulários.";
                }
                else if (cont == 40)
                {
                    lbl_titulo.Text = "Carregando formulários..";
                }
                else if (cont == 50)
                {
                    lbl_titulo.Text = "Carregando formulários...";
                }
                else if (cont == 60)
                {
                    lbl_titulo.Text = "Carregando banco de dados.";
                }
                else if (cont == 74)
                {
                    lbl_titulo.Text = "Carregando banco de dados..";
                }
                else if (cont == 90)
                {
                    lbl_titulo.Text = "Carregando banco de dados...";
                }
                else if (cont == 95)
                {
                    lbl_titulo.Text = "Abrindo o sistema...";
                }
            }
            else
            {
                tmr_contagen.Enabled = false;
                frm_login login = new frm_login();
                this.Visible = false;
                login.Show();
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
