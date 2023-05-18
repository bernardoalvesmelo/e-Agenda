namespace e_Agenda.WinApp.ModuloCompromisso
{
    partial class TelaCompromissoFiltroForm
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
            lbInicial = new Label();
            dateTimeInicio = new DateTimePicker();
            btnCancelar = new Button();
            btnFiltrar = new Button();
            lbFinal = new Label();
            dateTimeFinal = new DateTimePicker();
            SuspendLayout();
            // 
            // lbInicial
            // 
            lbInicial.AutoSize = true;
            lbInicial.Location = new Point(118, 18);
            lbInicial.Name = "lbInicial";
            lbInicial.Size = new Size(36, 15);
            lbInicial.TabIndex = 23;
            lbInicial.Text = "Início";
            // 
            // dateTimeInicio
            // 
            dateTimeInicio.Location = new Point(34, 51);
            dateTimeInicio.MinDate = new DateTime(2023, 5, 18, 0, 0, 0, 0);
            dateTimeInicio.Name = "dateTimeInicio";
            dateTimeInicio.Size = new Size(200, 23);
            dateTimeInicio.TabIndex = 22;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(388, 104);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFiltrar.DialogResult = DialogResult.OK;
            btnFiltrar.Location = new Point(307, 104);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 41);
            btnFiltrar.TabIndex = 20;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // lbFinal
            // 
            lbFinal.AutoSize = true;
            lbFinal.Location = new Point(350, 18);
            lbFinal.Name = "lbFinal";
            lbFinal.Size = new Size(32, 15);
            lbFinal.TabIndex = 25;
            lbFinal.Text = "Final";
            // 
            // dateTimeFinal
            // 
            dateTimeFinal.Location = new Point(264, 51);
            dateTimeFinal.MinDate = new DateTime(2023, 5, 18, 0, 0, 0, 0);
            dateTimeFinal.Name = "dateTimeFinal";
            dateTimeFinal.Size = new Size(200, 23);
            dateTimeFinal.TabIndex = 24;
            // 
            // TelaCompromissoFiltroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 157);
            Controls.Add(lbFinal);
            Controls.Add(dateTimeFinal);
            Controls.Add(lbInicial);
            Controls.Add(dateTimeInicio);
            Controls.Add(btnCancelar);
            Controls.Add(btnFiltrar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCompromissoFiltroForm";
            Text = "Filtro por Período";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbInicial;
        private DateTimePicker dateTimeInicio;
        private Button btnCancelar;
        private Button btnFiltrar;
        private Label lbFinal;
        private DateTimePicker dateTimeFinal;
    }
}