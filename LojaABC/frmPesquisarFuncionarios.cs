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
    public partial class frmPesquisarFuncionarios : Form
    {


        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);


        public frmPesquisarFuncionarios()
        {
            InitializeComponent();
            limparCampos();
        }

        private void frmPesquisarFuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        public void limparCampos()
        {
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            txtDescricao.Clear();
            txtDescricao.Focus();
            ltbPesquisar.Items.Clear();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ltbPesquisar.Items.Add(txtDescricao.Text);

        }
    }
}
