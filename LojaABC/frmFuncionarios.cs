using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LojaABC
{
    public partial class frmFuncionarios : Form
    {


        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);



        public frmFuncionarios()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal voltar = new frmMenuPrincipal();
            voltar.Show();
            this.Hide();

        }

        //desabilitando os componentes
        public void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtCPF.Enabled = false;
            dtpNascimento.Enabled = false;
            mskCelular.Enabled = false;
            gpbSexo.Enabled = false;

            txtLogradouro.Enabled = false;
            txtNumero.Enabled = false;
            mskCEP.Enabled = false;
            txtComplemento.Enabled = false;
            txtEstado.Enabled = false;
            txtCidade.Enabled = false;
            cbbUF.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnLimpar.Enabled = false;
            btnExcluir.Enabled = false;
            
        }


        //limpando campos
        public void limparCampos()
        {

            //dados pessoais
            txtNome.Clear();
            txtEmail.Clear();
            txtCPF.Clear();
            dtpNascimento.Text = "";
            mskCelular.Clear();
            rdbMasculino.Checked = false;
            rdbFeminino.Checked = false;
            rdbNãoDesejo.Checked = false;

            //endereço
            txtLogradouro.Clear();
            txtNumero.Clear();
            mskCEP.Clear();
            txtComplemento.Clear();
            txtEstado.Clear();
            txtCidade.Clear();
            cbbUF.Text = "";

            //botões
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnLimpar.Enabled = true;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = true;

            txtNome.Focus();
        }


        //habilitando campos
        public void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtCPF.Enabled = true;
            dtpNascimento.Enabled = true;
            mskCelular.Enabled = true;
            gpbSexo.Enabled = true;

            txtLogradouro.Enabled = true;
            txtNumero.Enabled = true;
            mskCEP.Enabled = true;
            txtComplemento.Enabled = true;
            txtEstado.Enabled = true;
            txtCidade.Enabled = true;
            cbbUF.Enabled = true;

            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnLimpar.Enabled = true;
            btnExcluir.Enabled = false;

            btnNovo.Enabled = false;

            txtNome.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //executando habilitar campos
            habilitarCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") || txtEmail.Text.Equals("") || 
                txtCPF.Text.Equals("   .   .   -") || mskCelular.Text.Equals("     -") || 
                txtComplemento.Text.Equals("") || txtLogradouro.Text.Equals("") || 
                txtCidade.Text.Equals("") || txtNumero.Text.Equals("") || txtEstado.Text.Equals("") ||
                mskCEP.Text.Equals("     -") || cbbUF.Text.Equals(""))
            {
                MessageBox.Show("Favor preencher o campo",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Cadastrado com sucesso");
            }
        }
    }

}
