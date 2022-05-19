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
    public partial class CadastroPessoaKauan : Form
    {
        public CadastroPessoaKauan()
        {
            InitializeComponent();
        }

        public void LimparTela()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is ComboBox)
                {
                    ctl.Text = string.Empty;
                }
                else if (ctl is TextBox)
                {
                    ctl.Text = string.Empty;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {


                 lbxReusultado.Items.Add(tbxNome.Text);
                 lbxReusultado.Items.Add(tbxCelular.Text);
                 lbxReusultado.Items.Add(tbxEmail.Text);
                 lbxReusultado.Items.Add(tbxCpf.Text);


                // System.Object[] item = new System.Object[4];
                //String[] items = new string[4];

                //items = ["tbx1.Text", "tbx2.Text", "tbx3.Text", "tbx4.Text"};

                //for (int i = 1; i < 5; i++)
                //{
                 // items[i] = $"tbx{i}.Text";


                    //lbxReusultado.Items.Add(items[i]);
                //}
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void CadastroPessoaKauan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 27)
            {
                LimparTela();
            }
        }

        private void tbx1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
