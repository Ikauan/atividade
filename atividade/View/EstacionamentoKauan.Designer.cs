﻿
namespace atividade.View
{
    partial class EstacionamentoKauan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstacionamentoKauan));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblCarro = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(57, 53);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(57, 94);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(31, 15);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data";
            // 
            // lblCarro
            // 
            this.lblCarro.AutoSize = true;
            this.lblCarro.Location = new System.Drawing.Point(57, 136);
            this.lblCarro.Name = "lblCarro";
            this.lblCarro.Size = new System.Drawing.Size(89, 15);
            this.lblCarro.TabIndex = 2;
            this.lblCarro.Text = "Marca do Carro";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(57, 183);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(26, 15);
            this.lblCor.TabIndex = 3;
            this.lblCor.Text = "Cor";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(103, 53);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(134, 23);
            this.tbxNome.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(232, 23);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblResultado.Location = new System.Drawing.Point(422, 270);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(333, 132);
            this.lblResultado.TabIndex = 10;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(422, 216);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(112, 39);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Preto",
            "Vermelho",
            "Prata",
            "Branco",
            "Cinza"});
            this.comboBox1.Location = new System.Drawing.Point(89, 183);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 12;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "BMW",
            "Chevrollet",
            "Volkswagen",
            "Nissa"});
            this.comboBox2.Location = new System.Drawing.Point(152, 136);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(111, 23);
            this.comboBox2.TabIndex = 13;
            // 
            // EstacionamentoKauan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblCarro);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EstacionamentoKauan";
            this.Text = "Estacionamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblCarro;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}