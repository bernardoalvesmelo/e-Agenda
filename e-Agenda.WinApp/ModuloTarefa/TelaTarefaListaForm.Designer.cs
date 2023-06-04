namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class TelaTarefaListaForm
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
            lbDescricao = new Label();
            txtDescricao = new TextBox();
            panel1 = new Panel();
            listItens = new ListBox();
            btnCancelar = new Button();
            btnAdicionar = new Button();
            btnInserir = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbDescricao
            // 
            lbDescricao.AutoSize = true;
            lbDescricao.Location = new Point(15, 15);
            lbDescricao.Name = "lbDescricao";
            lbDescricao.Size = new Size(61, 15);
            lbDescricao.TabIndex = 16;
            lbDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(82, 12);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(200, 23);
            txtDescricao.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.Controls.Add(listItens);
            panel1.Location = new Point(82, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 13;
            // 
            // listItens
            // 
            listItens.Dock = DockStyle.Fill;
            listItens.Enabled = false;
            listItens.FormattingEnabled = true;
            listItens.ItemHeight = 15;
            listItens.Location = new Point(0, 0);
            listItens.Name = "listItens";
            listItens.Size = new Size(200, 100);
            listItens.TabIndex = 6;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(299, 157);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdicionar.DialogResult = DialogResult.OK;
            btnAdicionar.Location = new Point(218, 157);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 41);
            btnAdicionar.TabIndex = 11;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnConcluir_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(299, 15);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 17;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // TelaTarefaListaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 210);
            Controls.Add(btnInserir);
            Controls.Add(lbDescricao);
            Controls.Add(txtDescricao);
            Controls.Add(panel1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdicionar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaTarefaListaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adição de Items";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDescricao;
        private TextBox txtDescricao;
        private Panel panel1;
        private ListBox listItens;
        private Button btnCancelar;
        private Button btnAdicionar;
        private Button btnInserir;
    }
}