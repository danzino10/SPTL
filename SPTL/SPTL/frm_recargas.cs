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
    public partial class frm_recargas : Form
    {
        public frm_recargas()
        {
            InitializeComponent();
        }

        private void btn_unitel_Click(object sender, EventArgs e)
        {
            frm_unitel u = new frm_unitel();
            u.Show();
            this.Hide();
        }

        private void btn_movicel_Click(object sender, EventArgs e)
        {
            frm_movicel h = new frm_movicel();
            h.Show();
            this.Hide();
        }

        private void btn_tvcabo_Click(object sender, EventArgs e)
        {
            frm_tvcabo t = new frm_tvcabo();
            t.Show();
            this.Hide();
        }

        private void btn_ende_Click(object sender, EventArgs e)
        {
            frm_ende a= new frm_ende();
            a.Show();
            this.Hide();
        }

        private void btn_zap_Click(object sender, EventArgs e)
        {
            frm_zap p = new frm_zap();
            p.Show();
            this.Hide();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            frm_principal kg = new frm_principal();
            kg.Show();
            this.Close();
        }
    }
}
