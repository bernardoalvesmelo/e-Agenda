namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class TelaTarefaFiltroForm
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
            btnCancelar = new Button();
            btnFiltrar = new Button();
            label1 = new Label();
            cmbAlternativa = new ComboBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(263, 114);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFiltrar.DialogResult = DialogResult.OK;
            btnFiltrar.Location = new Point(182, 114);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 41);
            btnFiltrar.TabIndex = 22;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 23);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 25;
            label1.Text = "Escolha uma alternativa";
            // 
            // cmbAlternativa
            // 
            cmbAlternativa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAlternativa.FormattingEnabled = true;
            cmbAlternativa.Items.AddRange(new object[] { "Mostrar Tarefas Existentes", "Mostrar Tarefas Completadas", "Mostrar Tarefas Pendentes", "Mostrar Tarefas Ordenadas por Prioridade" });
            cmbAlternativa.Location = new Point(78, 67);
            cmbAlternativa.Name = "cmbAlternativa";
            cmbAlternativa.Size = new Size(210, 23);
            cmbAlternativa.TabIndex = 24;
            // 
            // TelaTarefaFiltroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 167);
            Controls.Add(label1);
            Controls.Add(cmbAlternativa);
            Controls.Add(btnCancelar);
            Controls.Add(btnFiltrar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaTarefaFiltroForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaTarefaFiltroForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnFiltrar;
        private Label label1;
        private ComboBox cmbAlternativa;
    }
}