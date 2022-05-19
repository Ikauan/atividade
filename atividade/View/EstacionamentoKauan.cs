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
    public partial class EstacionamentoKauan : Form
    {
        public EstacionamentoKauan()
        {
            InitializeComponent();
        }
        public void Limpartela()
        {
            
        }

        private void tbxNome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
                if (tbxNome.Text == string.Empty)
                {
                    MessageBox.Show("Faltam dados a serem cadastrados.");
                }
                if (cbxCarro.Text == string.Empty)
                {
                    MessageBox.Show("Faltam dados a serem cadastrados.");
                }
                if (cbxCor.Text == string.Empty)
                {
                    MessageBox.Show("Faltam dados a serem cadastrados.");
                }
                else
                {
                    MessageBox.Show("Dados cadastrados com sucesso.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                       
        }

        private void lsbResultado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
