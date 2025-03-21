namespace Componente
{
    partial class frmComponentes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComponentes));
            this.gpbComponentes = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblListarProdutoa = new System.Windows.Forms.Label();
            this.lbxListarProdutos = new System.Windows.Forms.ListBox();
            this.lblListarNome = new System.Windows.Forms.Label();
            this.cbbListarNome = new System.Windows.Forms.ComboBox();
            this.cbxLivros = new System.Windows.Forms.CheckBox();
            this.lblEscolha = new System.Windows.Forms.Label();
            this.cbxComputador = new System.Windows.Forms.CheckBox();
            this.cbxMesa = new System.Windows.Forms.CheckBox();
            this.cbxBanana = new System.Windows.Forms.CheckBox();
            this.pcbImagens = new System.Windows.Forms.PictureBox();
            this.gpbComponentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagens)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbComponentes
            // 
            this.gpbComponentes.Controls.Add(this.pcbImagens);
            this.gpbComponentes.Controls.Add(this.cbxBanana);
            this.gpbComponentes.Controls.Add(this.cbxMesa);
            this.gpbComponentes.Controls.Add(this.cbxComputador);
            this.gpbComponentes.Controls.Add(this.lblEscolha);
            this.gpbComponentes.Controls.Add(this.cbxLivros);
            this.gpbComponentes.Controls.Add(this.cbbListarNome);
            this.gpbComponentes.Controls.Add(this.lblListarNome);
            this.gpbComponentes.Controls.Add(this.lbxListarProdutos);
            this.gpbComponentes.Controls.Add(this.lblListarProdutoa);
            this.gpbComponentes.Controls.Add(this.txtNome);
            this.gpbComponentes.Controls.Add(this.lblNome);
            this.gpbComponentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbComponentes.Location = new System.Drawing.Point(39, 22);
            this.gpbComponentes.Name = "gpbComponentes";
            this.gpbComponentes.Size = new System.Drawing.Size(716, 502);
            this.gpbComponentes.TabIndex = 0;
            this.gpbComponentes.TabStop = false;
            this.gpbComponentes.Text = "groupBox1";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(74, 92);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(78, 115);
            this.txtNome.MaxLength = 30;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(147, 26);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // lblListarProdutoa
            // 
            this.lblListarProdutoa.AutoSize = true;
            this.lblListarProdutoa.Location = new System.Drawing.Point(400, 92);
            this.lblListarProdutoa.Name = "lblListarProdutoa";
            this.lblListarProdutoa.Size = new System.Drawing.Size(115, 20);
            this.lblListarProdutoa.TabIndex = 2;
            this.lblListarProdutoa.Text = "Listar produtos";
            // 
            // lbxListarProdutos
            // 
            this.lbxListarProdutos.FormattingEnabled = true;
            this.lbxListarProdutos.ItemHeight = 20;
            this.lbxListarProdutos.Location = new System.Drawing.Point(404, 115);
            this.lbxListarProdutos.Name = "lbxListarProdutos";
            this.lbxListarProdutos.Size = new System.Drawing.Size(227, 144);
            this.lbxListarProdutos.TabIndex = 3;
            // 
            // lblListarNome
            // 
            this.lblListarNome.AutoSize = true;
            this.lblListarNome.Location = new System.Drawing.Point(74, 200);
            this.lblListarNome.Name = "lblListarNome";
            this.lblListarNome.Size = new System.Drawing.Size(92, 20);
            this.lblListarNome.TabIndex = 4;
            this.lblListarNome.Text = "Listar nome";
            // 
            // cbbListarNome
            // 
            this.cbbListarNome.FormattingEnabled = true;
            this.cbbListarNome.Location = new System.Drawing.Point(78, 223);
            this.cbbListarNome.Name = "cbbListarNome";
            this.cbbListarNome.Size = new System.Drawing.Size(147, 28);
            this.cbbListarNome.TabIndex = 2;
            // 
            // cbxLivros
            // 
            this.cbxLivros.AutoSize = true;
            this.cbxLivros.Location = new System.Drawing.Point(78, 306);
            this.cbxLivros.Name = "cbxLivros";
            this.cbxLivros.Size = new System.Drawing.Size(69, 24);
            this.cbxLivros.TabIndex = 4;
            this.cbxLivros.Text = "Livros";
            this.cbxLivros.UseVisualStyleBackColor = true;
            this.cbxLivros.CheckedChanged += new System.EventHandler(this.cbxLivros_CheckedChanged);
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Location = new System.Drawing.Point(74, 283);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(66, 20);
            this.lblEscolha.TabIndex = 7;
            this.lblEscolha.Text = "Escolha";
            // 
            // cbxComputador
            // 
            this.cbxComputador.AutoSize = true;
            this.cbxComputador.Location = new System.Drawing.Point(78, 366);
            this.cbxComputador.Name = "cbxComputador";
            this.cbxComputador.Size = new System.Drawing.Size(116, 24);
            this.cbxComputador.TabIndex = 6;
            this.cbxComputador.Text = "Computador";
            this.cbxComputador.UseVisualStyleBackColor = true;
            this.cbxComputador.CheckedChanged += new System.EventHandler(this.cbxComputador_CheckedChanged);
            // 
            // cbxMesa
            // 
            this.cbxMesa.AutoSize = true;
            this.cbxMesa.Location = new System.Drawing.Point(78, 336);
            this.cbxMesa.Name = "cbxMesa";
            this.cbxMesa.Size = new System.Drawing.Size(67, 24);
            this.cbxMesa.TabIndex = 5;
            this.cbxMesa.Text = "Mesa";
            this.cbxMesa.UseVisualStyleBackColor = true;
            this.cbxMesa.CheckedChanged += new System.EventHandler(this.cbxMesa_CheckedChanged);
            // 
            // cbxBanana
            // 
            this.cbxBanana.AutoSize = true;
            this.cbxBanana.Location = new System.Drawing.Point(78, 396);
            this.cbxBanana.Name = "cbxBanana";
            this.cbxBanana.Size = new System.Drawing.Size(84, 24);
            this.cbxBanana.TabIndex = 7;
            this.cbxBanana.Text = "Banana";
            this.cbxBanana.UseVisualStyleBackColor = true;
            this.cbxBanana.CheckedChanged += new System.EventHandler(this.cbxBanana_CheckedChanged);
            // 
            // pcbImagens
            // 
            this.pcbImagens.Location = new System.Drawing.Point(404, 276);
            this.pcbImagens.Name = "pcbImagens";
            this.pcbImagens.Size = new System.Drawing.Size(227, 144);
            this.pcbImagens.TabIndex = 8;
            this.pcbImagens.TabStop = false;
            // 
            // frmComponentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gpbComponentes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmComponentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componentes";
            this.gpbComponentes.ResumeLayout(false);
            this.gpbComponentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbComponentes;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.CheckBox cbxBanana;
        private System.Windows.Forms.CheckBox cbxMesa;
        private System.Windows.Forms.CheckBox cbxComputador;
        private System.Windows.Forms.Label lblEscolha;
        private System.Windows.Forms.CheckBox cbxLivros;
        private System.Windows.Forms.ComboBox cbbListarNome;
        private System.Windows.Forms.Label lblListarNome;
        private System.Windows.Forms.ListBox lbxListarProdutos;
        private System.Windows.Forms.Label lblListarProdutoa;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.PictureBox pcbImagens;
    }
}