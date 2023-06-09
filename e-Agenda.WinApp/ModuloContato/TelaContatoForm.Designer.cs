﻿namespace e_Agenda.WinApp.ModuloContato
{
    partial class TelaContatoForm
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
            btnGravar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            txtCargo = new TextBox();
            txtEmail = new TextBox();
            txtEmpresa = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panInputs = new Panel();
            txtTelefone = new MaskedTextBox();
            panInputs.SuspendLayout();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(288, 185);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 0;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(369, 185);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 24);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 2;
            label1.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(90, 20);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 3;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 8);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(66, 3);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(334, 23);
            txtNome.TabIndex = 5;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(66, 62);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(100, 23);
            txtCargo.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(267, 36);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(133, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(267, 65);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(133, 23);
            txtEmpresa.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 36);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 10;
            label3.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(218, 40);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 11;
            label4.Text = "E-mail:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(207, 69);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 12;
            label5.Text = "Empresa:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 66);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 13;
            label6.Text = "Cargo:";
            // 
            // panInputs
            // 
            panInputs.Controls.Add(txtTelefone);
            panInputs.Controls.Add(label6);
            panInputs.Controls.Add(label5);
            panInputs.Controls.Add(label4);
            panInputs.Controls.Add(label3);
            panInputs.Controls.Add(txtEmpresa);
            panInputs.Controls.Add(txtEmail);
            panInputs.Controls.Add(txtCargo);
            panInputs.Controls.Add(txtNome);
            panInputs.Controls.Add(label2);
            panInputs.Location = new Point(24, 45);
            panInputs.Name = "panInputs";
            panInputs.Size = new Size(423, 121);
            panInputs.TabIndex = 15;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(66, 33);
            txtTelefone.Mask = "(99) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 16;
            // 
            // TelaContatoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 238);
            Controls.Add(panInputs);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaContatoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Contatos";
            panInputs.ResumeLayout(false);
            panInputs.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGravar;
        private Button btnCancelar;
        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtCargo;
        private TextBox txtEmail;
        private TextBox txtEmpresa;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panInputs;
        private MaskedTextBox txtTelefone;
    }
}