namespace ProjetoTeste
{
    partial class frmEscolha
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEscolha));
            this.btnEscolhe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEscolha = new System.Windows.Forms.TextBox();
            this.btnMensagem = new System.Windows.Forms.Button();
            this.tmrHoraCerta = new System.Windows.Forms.Timer(this.components);
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnTestaNome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEscolhe
            // 
            this.btnEscolhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscolhe.Location = new System.Drawing.Point(342, 22);
            this.btnEscolhe.Name = "btnEscolhe";
            this.btnEscolhe.Size = new System.Drawing.Size(160, 55);
            this.btnEscolhe.TabIndex = 1;
            this.btnEscolhe.Text = "Escolher";
            this.btnEscolhe.UseVisualStyleBackColor = true;
            this.btnEscolhe.Click += new System.EventHandler(this.btnEscolhe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escolha números de 1 a 5";
            // 
            // txtEscolha
            // 
            this.txtEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEscolha.Location = new System.Drawing.Point(14, 74);
            this.txtEscolha.Name = "txtEscolha";
            this.txtEscolha.Size = new System.Drawing.Size(100, 29);
            this.txtEscolha.TabIndex = 0;
            this.txtEscolha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEscolha_KeyDown);
            // 
            // btnMensagem
            // 
            this.btnMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnMensagem.Location = new System.Drawing.Point(342, 117);
            this.btnMensagem.Name = "btnMensagem";
            this.btnMensagem.Size = new System.Drawing.Size(175, 55);
            this.btnMensagem.TabIndex = 2;
            this.btnMensagem.Text = "Exibir Mensagem";
            this.btnMensagem.UseVisualStyleBackColor = true;
            this.btnMensagem.Click += new System.EventHandler(this.btnMensagem_Click);
            // 
            // tmrHoraCerta
            // 
            this.tmrHoraCerta.Enabled = true;
            this.tmrHoraCerta.Interval = 1000;
            this.tmrHoraCerta.Tick += new System.EventHandler(this.tmrHoraCerta_Tick);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtNome.Location = new System.Drawing.Point(14, 197);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(260, 29);
            this.txtNome.TabIndex = 3;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblNome.Location = new System.Drawing.Point(14, 163);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(113, 24);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Testa Nome";
            // 
            // btnTestaNome
            // 
            this.btnTestaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnTestaNome.Location = new System.Drawing.Point(14, 233);
            this.btnTestaNome.Name = "btnTestaNome";
            this.btnTestaNome.Size = new System.Drawing.Size(156, 47);
            this.btnTestaNome.TabIndex = 5;
            this.btnTestaNome.Text = "Testa nome";
            this.btnTestaNome.UseVisualStyleBackColor = true;
            this.btnTestaNome.Click += new System.EventHandler(this.btnTestaNome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(18, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 75);
            this.panel1.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(446, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(302, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(14, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(332, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "CPF";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.maskedTextBox2.Location = new System.Drawing.Point(336, 219);
            this.maskedTextBox2.Mask = "999,999,999-99";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(223, 29);
            this.maskedTextBox2.TabIndex = 9;
            // 
            // frmEscolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 409);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTestaNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnMensagem);
            this.Controls.Add(this.txtEscolha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEscolhe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEscolha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escolha";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEscolhe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEscolha;
        private System.Windows.Forms.Button btnMensagem;
        private System.Windows.Forms.Timer tmrHoraCerta;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnTestaNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
    }
}

