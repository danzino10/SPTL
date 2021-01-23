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
    public partial class frm_levantamento : Form
    {
        public frm_levantamento()
        {
            InitializeComponent();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            frm_principal p = new frm_principal();
            p.Show();
                this.Hide();
        }
    }
}
