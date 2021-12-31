using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPai_Filho
{
    public partial class FrmFilho : Form
    {

        FrmPai fp;

        public FrmFilho(FrmPai f)
        {
            InitializeComponent();
            fp = f;
        }

        // Evento Form Closed //
        private void FrmFilho_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormFilho = null;
        }

        // Botão Enviar para Form Pai //
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            fp.txtNome.Text = txtNome.Text;
            fp.txtTelefone.Text = txtTelefone.Text;
            this.Close();
        }
    }
}
