
namespace atividade.View
{
    partial class MenuPrincipalKauan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalKauan));
            this.btnCarro = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnEsta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCarro
            // 
            this.btnCarro.Location = new System.Drawing.Point(268, 233);
            this.btnCarro.Name = "btnCarro";
            this.btnCarro.Size = new System.Drawing.Size(223, 27);
            this.btnCarro.TabIndex = 0;
            this.btnCarro.Text = "Cadastro do Carro";
            this.btnCarro.UseVisualStyleBackColor = true;
            this.btnCarro.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(268, 181);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(223, 29);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "Cadastro do Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(271, 107);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(220, 35);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Atividade Para o Silvio";
            // 
            // btnEsta
            // 
            this.btnEsta.Location = new System.Drawing.Point(268, 278);
            this.btnEsta.Name = "btnEsta";
            this.btnEsta.Size = new System.Drawing.Size(223, 33);
            this.btnEsta.TabIndex = 4;
            this.btnEsta.Text = "Cadastro do Estacionamento";
            this.btnEsta.UseVisualStyleBackColor = true;
            this.btnEsta.Click += new System.EventHandler(this.button4_Click);
            // 
            // MenuPrincipalKauan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEsta);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnCarro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipalKauan";
            this.Text = "MenuPrincipalKauan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarro;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnEsta;
    }
}