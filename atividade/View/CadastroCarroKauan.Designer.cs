
namespace atividade.View
{
    partial class CadastroCarroKauan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCarroKauan));
            this.lblCarro = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.cbxCarro = new System.Windows.Forms.ComboBox();
            this.cbxCor = new System.Windows.Forms.ComboBox();
            this.lblMarcacarro = new System.Windows.Forms.Label();
            this.tbxPlaca = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCarro
            // 
            this.lblCarro.AutoSize = true;
            this.lblCarro.Location = new System.Drawing.Point(55, 52);
            this.lblCarro.Name = "lblCarro";
            this.lblCarro.Size = new System.Drawing.Size(36, 15);
            this.lblCarro.TabIndex = 0;
            this.lblCarro.Text = "Carro";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(56, 98);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(26, 15);
            this.lblCor.TabIndex = 1;
            this.lblCor.Text = "Cor";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(56, 151);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 15);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(56, 190);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(35, 15);
            this.lblPlaca.TabIndex = 3;
            this.lblPlaca.Text = "Placa";
            // 
            // cbxCarro
            // 
            this.cbxCarro.FormattingEnabled = true;
            this.cbxCarro.Items.AddRange(new object[] {
            "BMW",
            "Chevrollet",
            "Volkswagen",
            "Nissa"});
            this.cbxCarro.Location = new System.Drawing.Point(116, 44);
            this.cbxCarro.Name = "cbxCarro";
            this.cbxCarro.Size = new System.Drawing.Size(121, 23);
            this.cbxCarro.TabIndex = 4;
            this.cbxCarro.SelectedIndexChanged += new System.EventHandler(this.cbxCarro_SelectedIndexChanged);
            // 
            // cbxCor
            // 
            this.cbxCor.FormattingEnabled = true;
            this.cbxCor.Items.AddRange(new object[] {
            "Preto",
            "Vermelho",
            "Prata",
            "Branco",
            "Cinza"});
            this.cbxCor.Location = new System.Drawing.Point(115, 90);
            this.cbxCor.Name = "cbxCor";
            this.cbxCor.Size = new System.Drawing.Size(121, 23);
            this.cbxCor.TabIndex = 5;
            // 
            // lblMarcacarro
            // 
            this.lblMarcacarro.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblMarcacarro.Location = new System.Drawing.Point(115, 143);
            this.lblMarcacarro.Name = "lblMarcacarro";
            this.lblMarcacarro.Size = new System.Drawing.Size(196, 23);
            this.lblMarcacarro.TabIndex = 6;
            // 
            // tbxPlaca
            // 
            this.tbxPlaca.Location = new System.Drawing.Point(115, 182);
            this.tbxPlaca.Name = "tbxPlaca";
            this.tbxPlaca.Size = new System.Drawing.Size(163, 23);
            this.tbxPlaca.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(56, 262);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(123, 34);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // CadastroCarroKauan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.tbxPlaca);
            this.Controls.Add(this.lblMarcacarro);
            this.Controls.Add(this.cbxCor);
            this.Controls.Add(this.cbxCarro);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblCarro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroCarroKauan";
            this.Text = "Carro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarro;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.ComboBox cbxCarro;
        private System.Windows.Forms.ComboBox cbxCor;
        private System.Windows.Forms.Label lblMarcacarro;
        private System.Windows.Forms.TextBox tbxPlaca;
        private System.Windows.Forms.Button btnCadastrar;
    }
}