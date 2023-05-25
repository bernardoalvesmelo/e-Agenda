namespace e_Agenda.WinApp.ModuloCategoria
{
    partial class TelaCategoriaVizualisarForm
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
            listDispesas = new ListBox();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Location = new Point(52, 33);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(40, 15);
            lbTitulo.TabIndex = 21;
            lbTitulo.Text = "Título:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(107, 30);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(200, 23);
            txtTitulo.TabIndex = 20;
            // 
            // listDispesas
            // 
            listDispesas.FormattingEnabled = true;
            listDispesas.ItemHeight = 15;
            listDispesas.Location = new Point(39, 84);
            listDispesas.Name = "listDispesas";
            listDispesas.Size = new Size(341, 94);
            listDispesas.TabIndex = 6;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFechar.DialogResult = DialogResult.Cancel;
            btnFechar.Location = new Point(327, 195);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 41);
            btnFechar.TabIndex = 18;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // TelaCategoriaVizualisarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 248);
            Controls.Add(listDispesas);
            Controls.Add(lbTitulo);
            Controls.Add(txtTitulo);
            Controls.Add(btnFechar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCategoriaVizualisarForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCategoriaVizualisarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitulo;
        private TextBox txtTitulo;
        private ListBox listDispesas;
        private Button btnFechar;
    }
}