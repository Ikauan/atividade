using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade.View
{
    public partial class CadastroCarroKauan : Form
    {
        public CadastroCarroKauan()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (cbxCarro.Text == string.Empty)
            {
                MessageBox.Show("Faltam dados a serem cadastrados.");
            }
            else
            {
                lblMarcacarro.Text = cbxCarro.Text;
            }
            if (cbxCor.Text == string.Empty)
            {
                MessageBox.Show("Faltam dados a serem cadastrados.");
            }
            if (lblPlaca.Text == string.Empty)
            {
                MessageBox.Show("Faltam dados a serem cadastrados.");
            }
            else
            {
                MessageBox.Show("Dados cadastrados com sucesso.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbxCarro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
