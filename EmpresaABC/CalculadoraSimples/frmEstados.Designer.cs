namespace CalculadoraSimples
{
    partial class frmEstados
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
            this.cboCarregaEstados = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCarregaEstados = new System.Windows.Forms.Button();
            this.btnRemoveLista = new System.Windows.Forms.Button();
            this.ltbListaEstado = new System.Windows.Forms.ListBox();
            this.btnCarregaLista = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCarregaLabel = new System.Windows.Forms.Label();
            this.btnCarregaLabel = new System.Windows.Forms.Button();
            this.lblCarregaLista = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.lblRetornoRadioButton = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbManha = new System.Windows.Forms.CheckBox();
            this.ckbTarde = new System.Windows.Forms.CheckBox();
            this.ckbNoite = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEscolha = new System.Windows.Forms.Button();
            this.btnEscolhaLista = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCarregaEstados
            // 
            this.cboCarregaEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCarregaEstados.FormattingEnabled = true;
            this.cboCarregaEstados.Location = new System.Drawing.Point(44, 72);
            this.cboCarregaEstados.Name = "cboCarregaEstados";
            this.cboCarregaEstados.Size = new System.Drawing.Size(212, 37);
            this.cboCarregaEstados.TabIndex = 5;
            this.cboCarregaEstados.SelectedIndexChanged += new System.EventHandler(this.cboCarregaEstados_SelectedIndexChanged);
            this.cboCarregaEstados.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboCarregaEstados_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Estados";
            // 
            // btnCarregaEstados
            // 
            this.btnCarregaEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaEstados.Location = new System.Drawing.Point(44, 297);
            this.btnCarregaEstados.Name = "btnCarregaEstados";
            this.btnCarregaEstados.Size = new System.Drawing.Size(196, 82);
            this.btnCarregaEstados.TabIndex = 3;
            this.btnCarregaEstados.Text = "Carrega Estados";
            this.btnCarregaEstados.UseVisualStyleBackColor = true;
            this.btnCarregaEstados.Click += new System.EventHandler(this.btnCarregaEstados_Click);
            // 
            // btnRemoveLista
            // 
            this.btnRemoveLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveLista.Location = new System.Drawing.Point(497, 420);
            this.btnRemoveLista.Name = "btnRemoveLista";
            this.btnRemoveLista.Size = new System.Drawing.Size(193, 87);
            this.btnRemoveLista.TabIndex = 6;
            this.btnRemoveLista.Text = "Limpar";
            this.btnRemoveLista.UseVisualStyleBackColor = true;
            // 
            // ltbListaEstado
            // 
            this.ltbListaEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbListaEstado.FormattingEnabled = true;
            this.ltbListaEstado.ItemHeight = 29;
            this.ltbListaEstado.Location = new System.Drawing.Point(278, 54);
            this.ltbListaEstado.Name = "ltbListaEstado";
            this.ltbListaEstado.Size = new System.Drawing.Size(196, 207);
            this.ltbListaEstado.TabIndex = 7;
            this.ltbListaEstado.SelectedIndexChanged += new System.EventHandler(this.ltbListaEstado_SelectedIndexChanged);
            // 
            // btnCarregaLista
            // 
            this.btnCarregaLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaLista.Location = new System.Drawing.Point(44, 420);
            this.btnCarregaLista.Name = "btnCarregaLista";
            this.btnCarregaLista.Size = new System.Drawing.Size(196, 82);
            this.btnCarregaLista.TabIndex = 8;
            this.btnCarregaLista.Text = "Carrega Lista";
            this.btnCarregaLista.UseVisualStyleBackColor = true;
            this.btnCarregaLista.Click += new System.EventHandler(this.btnCarregaLista_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Estados";
            // 
            // lblCarregaLabel
            // 
            this.lblCarregaLabel.AutoSize = true;
            this.lblCarregaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblCarregaLabel.Location = new System.Drawing.Point(278, 350);
            this.lblCarregaLabel.Name = "lblCarregaLabel";
            this.lblCarregaLabel.Size = new System.Drawing.Size(79, 29);
            this.lblCarregaLabel.TabIndex = 10;
            this.lblCarregaLabel.Text = "label3";
            // 
            // btnCarregaLabel
            // 
            this.btnCarregaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnCarregaLabel.Location = new System.Drawing.Point(278, 417);
            this.btnCarregaLabel.Name = "btnCarregaLabel";
            this.btnCarregaLabel.Size = new System.Drawing.Size(193, 84);
            this.btnCarregaLabel.TabIndex = 11;
            this.btnCarregaLabel.Text = "Carrega Label";
            this.btnCarregaLabel.UseVisualStyleBackColor = true;
            this.btnCarregaLabel.Click += new System.EventHandler(this.btnCarregaLabel_Click);
            // 
            // lblCarregaLista
            // 
            this.lblCarregaLista.AutoSize = true;
            this.lblCarregaLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblCarregaLista.Location = new System.Drawing.Point(497, 350);
            this.lblCarregaLista.Name = "lblCarregaLista";
            this.lblCarregaLista.Size = new System.Drawing.Size(79, 29);
            this.lblCarregaLista.TabIndex = 12;
            this.lblCarregaLista.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label4.Location = new System.Drawing.Point(278, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Combo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label5.Location = new System.Drawing.Point(497, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Lista";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.rdbMasculino.Location = new System.Drawing.Point(54, 30);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(143, 33);
            this.rdbMasculino.TabIndex = 15;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            this.rdbMasculino.CheckedChanged += new System.EventHandler(this.rdbMasculino_CheckedChanged);
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.rdbFeminino.Location = new System.Drawing.Point(54, 95);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(135, 33);
            this.rdbFeminino.TabIndex = 16;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            this.rdbFeminino.CheckedChanged += new System.EventHandler(this.rdbFeminino_CheckedChanged);
            // 
            // lblRetornoRadioButton
            // 
            this.lblRetornoRadioButton.AutoSize = true;
            this.lblRetornoRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblRetornoRadioButton.Location = new System.Drawing.Point(522, 199);
            this.lblRetornoRadioButton.Name = "lblRetornoRadioButton";
            this.lblRetornoRadioButton.Size = new System.Drawing.Size(266, 29);
            this.lblRetornoRadioButton.TabIndex = 17;
            this.lblRetornoRadioButton.Text = "Retorno do radio button";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbFeminino);
            this.groupBox1.Controls.Add(this.rdbMasculino);
            this.groupBox1.Location = new System.Drawing.Point(494, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 166);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo:";
            // 
            // ckbManha
            // 
            this.ckbManha.AutoSize = true;
            this.ckbManha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.ckbManha.Location = new System.Drawing.Point(63, 49);
            this.ckbManha.Name = "ckbManha";
            this.ckbManha.Size = new System.Drawing.Size(107, 33);
            this.ckbManha.TabIndex = 19;
            this.ckbManha.Text = "Manhã";
            this.ckbManha.UseVisualStyleBackColor = true;
            // 
            // ckbTarde
            // 
            this.ckbTarde.AutoSize = true;
            this.ckbTarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.ckbTarde.Location = new System.Drawing.Point(63, 105);
            this.ckbTarde.Name = "ckbTarde";
            this.ckbTarde.Size = new System.Drawing.Size(100, 33);
            this.ckbTarde.TabIndex = 20;
            this.ckbTarde.Text = "Tarde";
            this.ckbTarde.UseVisualStyleBackColor = true;
            // 
            // ckbNoite
            // 
            this.ckbNoite.AutoSize = true;
            this.ckbNoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.ckbNoite.Location = new System.Drawing.Point(63, 160);
            this.ckbNoite.Name = "ckbNoite";
            this.ckbNoite.Size = new System.Drawing.Size(93, 33);
            this.ckbNoite.TabIndex = 21;
            this.ckbNoite.Text = "Noite";
            this.ckbNoite.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbNoite);
            this.groupBox2.Controls.Add(this.ckbManha);
            this.groupBox2.Controls.Add(this.ckbTarde);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.groupBox2.Location = new System.Drawing.Point(820, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 204);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Escolha";
            // 
            // btnEscolha
            // 
            this.btnEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnEscolha.Location = new System.Drawing.Point(624, 290);
            this.btnEscolha.Name = "btnEscolha";
            this.btnEscolha.Size = new System.Drawing.Size(164, 49);
            this.btnEscolha.TabIndex = 23;
            this.btnEscolha.Text = "Escolha";
            this.btnEscolha.UseVisualStyleBackColor = true;
            this.btnEscolha.Click += new System.EventHandler(this.btnEscolha_Click);
            // 
            // btnEscolhaLista
            // 
            this.btnEscolhaLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnEscolhaLista.Location = new System.Drawing.Point(819, 287);
            this.btnEscolhaLista.Name = "btnEscolhaLista";
            this.btnEscolhaLista.Size = new System.Drawing.Size(164, 49);
            this.btnEscolhaLista.TabIndex = 24;
            this.btnEscolhaLista.Text = "Escolha Lista";
            this.btnEscolhaLista.UseVisualStyleBackColor = true;
            this.btnEscolhaLista.Click += new System.EventHandler(this.btnEscolhaLista_Click);
            // 
            // frmEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 553);
            this.Controls.Add(this.btnEscolhaLista);
            this.Controls.Add(this.btnEscolha);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblRetornoRadioButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCarregaLista);
            this.Controls.Add(this.btnCarregaLabel);
            this.Controls.Add(this.lblCarregaLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCarregaLista);
            this.Controls.Add(this.ltbListaEstado);
            this.Controls.Add(this.btnRemoveLista);
            this.Controls.Add(this.cboCarregaEstados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCarregaEstados);
            this.Name = "frmEstados";
            this.Text = "frmEstados";
            this.Load += new System.EventHandler(this.frmEstados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCarregaEstados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCarregaEstados;
        private System.Windows.Forms.Button btnRemoveLista;
        private System.Windows.Forms.ListBox ltbListaEstado;
        private System.Windows.Forms.Button btnCarregaLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCarregaLabel;
        private System.Windows.Forms.Button btnCarregaLabel;
        private System.Windows.Forms.Label lblCarregaLista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.Label lblRetornoRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbManha;
        private System.Windows.Forms.CheckBox ckbTarde;
        private System.Windows.Forms.CheckBox ckbNoite;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEscolha;
        private System.Windows.Forms.Button btnEscolhaLista;
    }
}