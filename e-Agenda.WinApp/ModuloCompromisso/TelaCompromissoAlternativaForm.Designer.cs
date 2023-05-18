namespace e_Agenda.WinApp.ModuloCompromisso
{
    partial class TelaCompromissoAlternativaForm
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
            cmbAlternativa = new ComboBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnExibir = new Button();
            SuspendLayout();
            // 
            // cmbAlternativa
            // 
            cmbAlternativa.FormattingEnabled = true;
            cmbAlternativa.Items.AddRange(new object[] { "Mostrar todos compromissos", "Mostrar compromissos futuros", "Mostrar compromissos passados" });
            cmbAlternativa.Location = new Point(72, 74);
            cmbAlternativa.Name = "cmbAlternativa";
            cmbAlternativa.Size = new Size(210, 23);
            cmbAlternativa.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 30);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 1;
            label1.Text = "Escolha uma alternativa";
            label1.Click += label1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(248, 127);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExibir
            // 
            btnExibir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExibir.DialogResult = DialogResult.OK;
            btnExibir.Location = new Point(167, 127);
            btnExibir.Name = "btnExibir";
            btnExibir.Size = new Size(75, 41);
            btnExibir.TabIndex = 22;
            btnExibir.Text = "Exibir";
            btnExibir.UseVisualStyleBackColor = true;
            // 
            // TelaCompromissoAlternativaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 189);
            Controls.Add(btnCancelar);
            Controls.Add(btnExibir);
            Controls.Add(label1);
            Controls.Add(cmbAlternativa);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCompromissoAlternativaForm";
            Text = "Seleção de Exibição";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbAlternativa;
        private Label label1;
        private Button btnCancelar;
        private Button btnExibir;
    }
}