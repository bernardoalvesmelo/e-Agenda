namespace e_Agenda.WinApp.ModuloCompromisso
{
    partial class TelaCompromissoForm
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtLocal = new TextBox();
            txtAssunto = new TextBox();
            txtId = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            cmbContatos = new ComboBox();
            dateTimeData = new DateTimePicker();
            label2 = new Label();
            label7 = new Label();
            label8 = new Label();
            dateTimeInicio = new DateTimePicker();
            dateTimeTermino = new DateTimePicker();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 137);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 27;
            label6.Text = "Início:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(271, 140);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 26;
            label5.Text = "Término:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 112);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 25;
            label4.Text = "Local:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 111);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 24;
            label3.Text = "Assunto:";
            // 
            // txtLocal
            // 
            txtLocal.Location = new Point(335, 108);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(149, 23);
            txtLocal.TabIndex = 22;
            // 
            // txtAssunto
            // 
            txtAssunto.Location = new Point(89, 108);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(149, 23);
            txtAssunto.TabIndex = 20;
            // 
            // txtId
            // 
            txtId.Location = new Point(89, 21);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 17;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 24);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 16;
            label1.Text = "Id:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(410, 191);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(329, 191);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 14;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // cmbContatos
            // 
            cmbContatos.FormattingEnabled = true;
            cmbContatos.Location = new Point(89, 50);
            cmbContatos.Name = "cmbContatos";
            cmbContatos.Size = new Size(235, 23);
            cmbContatos.TabIndex = 28;
            // 
            // dateTimeData
            // 
            dateTimeData.Location = new Point(89, 79);
            dateTimeData.Name = "dateTimeData";
            dateTimeData.Size = new Size(235, 23);
            dateTimeData.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 85);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 30;
            label2.Text = "Data:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 53);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 31;
            label7.Text = "Contato:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.IndianRed;
            label8.Location = new Point(335, 58);
            label8.Name = "label8";
            label8.Size = new Size(137, 15);
            label8.TabIndex = 32;
            label8.Text = "*campo não obrigatório";
            // 
            // dateTimeInicio
            // 
            dateTimeInicio.CustomFormat = "HH:mm";
            dateTimeInicio.Location = new Point(89, 137);
            dateTimeInicio.Name = "dateTimeInicio";
            dateTimeInicio.Size = new Size(149, 23);
            dateTimeInicio.TabIndex = 33;
            dateTimeInicio.Value = new DateTime(2023, 5, 17, 15, 51, 0, 0);
            // 
            // dateTimeTermino
            // 
            dateTimeTermino.CustomFormat = "\"HH:mm\"";
            dateTimeTermino.Location = new Point(335, 137);
            dateTimeTermino.Name = "dateTimeTermino";
            dateTimeTermino.Size = new Size(149, 23);
            dateTimeTermino.TabIndex = 34;
            dateTimeTermino.Value = new DateTime(2023, 5, 17, 15, 51, 0, 0);
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 244);
            Controls.Add(dateTimeTermino);
            Controls.Add(dateTimeInicio);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(dateTimeData);
            Controls.Add(cmbContatos);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtLocal);
            Controls.Add(txtAssunto);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCompromissoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Compromissos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtLocal;
        private TextBox txtAssunto;
        private TextBox txtId;
        private Label label1;
        private Button btnCancelar;
        private Button btnGravar;
        private ComboBox cmbContatos;
        private DateTimePicker dateTimeData;
        private Label label2;
        private Label label7;
        private Label label8;
        private DateTimePicker dateTimeInicio;
        private DateTimePicker dateTimeTermino;
    }
}