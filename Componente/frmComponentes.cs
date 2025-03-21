using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componente
{
    public partial class frmComponentes : Form
    {
        public frmComponentes()
        {
            InitializeComponent();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {


            if (txtNome.Text.Equals(""))
            {
                MessageBox.Show("Digite um valor válido", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            if (e.KeyCode == Keys.Enter)
            {
                cbbListarNome.Items.Add(txtNome.Text);
                txtNome.Clear();
                txtNome.Focus();
            }
            
        }

        private void cbxLivros_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxLivros.Checked)
            {
                lbxListarProdutos.Items.Add("Livros");
            }
            else
            {
                lbxListarProdutos.Items.Remove("Livros");
            }
        }

        private void cbxMesa_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMesa.Checked)
            {
                lbxListarProdutos.Items.Add("Mesa");
            }
            else
            {
                lbxListarProdutos.Items.Remove("Mesa");
            }
        }

        private void cbxComputador_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxComputador.Checked)
            {
                lbxListarProdutos.Items.Add("Computador");
            }
            else
            {
                lbxListarProdutos.Items.Remove("Computador");
            }
        }

        private void cbxBanana_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxBanana.Checked)
            {
                lbxListarProdutos.Items.Add("Banana");
            }
            else
            {
                lbxListarProdutos.Items.Remove("Banana");
            }
        }
    }
}
