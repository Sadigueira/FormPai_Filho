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
    public partial class FrmPai : Form
    {
        public FrmPai()
        {
            InitializeComponent();
        }

        // Evento Form Pai //
        private void FrmPai_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormPai = null;
        }

        // Botão Abrir Form Filho //
        private void btnFormFilho_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormFilho == null)
                MeusFormularios.FormFilho = new FrmFilho(this);
            MeusFormularios.FormFilho.ShowDialog();
        }
    }
}
