namespace e_Agenda.WinApp.ModuloCategoria
{
    partial class TelaCategoriaVisualizarForm
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
            lbTitulo = new Label();
            txtTitulo = new TextBox();
            btnFechar = new Button();
            tabelaDespesa = new ModuloDespesa.TabelaDespesaControl();
            statusStrip1 = new StatusStrip();
            lbDespesas = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Location = new Point(231, 26);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(40, 15);
            lbTitulo.TabIndex = 21;
            lbTitulo.Text = "Título:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(286, 23);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(200, 23);
            txtTitulo.TabIndex = 20;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFechar.DialogResult = DialogResult.Cancel;
            btnFechar.Location = new Point(673, 252);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 41);
            btnFechar.TabIndex = 18;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // tabelaDespesa
            // 
            tabelaDespesa.Location = new Point(35, 59);
            tabelaDespesa.Name = "tabelaDespesa";
            tabelaDespesa.Size = new Size(668, 177);
            tabelaDespesa.TabIndex = 22;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbDespesas });
            statusStrip1.Location = new Point(0, 296);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(760, 22);
            statusStrip1.TabIndex = 23;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbDespesas
            // 
            lbDespesas.Name = "lbDespesas";
            lbDespesas.Size = new Size(124, 17);
            lbDespesas.Text = "Vizualizando Despesas";
            // 
            // TelaCategoriaVisualizarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 318);
            Controls.Add(statusStrip1);
            Controls.Add(tabelaDespesa);
            Controls.Add(lbTitulo);
            Controls.Add(txtTitulo);
            Controls.Add(btnFechar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCategoriaVisualizarForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCategoriaVizualisarForm";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitulo;
        private TextBox txtTitulo;
        private Button btnFechar;
        private ModuloDespesa.TabelaDespesaControl tabelaDespesa;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbDespesas;
    }
}