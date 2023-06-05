namespace e_Agenda.WinApp.ModuloDespesa
{
    partial class TelaDespesaForm
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
            txtId = new TextBox();
            label2 = new Label();
            txtDescricao = new TextBox();
            lbDescricao = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            lbValor = new Label();
            txtValor = new TextBox();
            lbData = new Label();
            txtData = new DateTimePicker();
            lbPagamento = new Label();
            cmbPagamento = new ComboBox();
            listCategorias = new CheckedListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(92, 12);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 13;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 16);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 12;
            label2.Text = "Id:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(92, 41);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(135, 23);
            txtDescricao.TabIndex = 11;
            // 
            // lbDescricao
            // 
            lbDescricao.AutoSize = true;
            lbDescricao.Location = new Point(20, 44);
            lbDescricao.Name = "lbDescricao";
            lbDescricao.Size = new Size(61, 15);
            lbDescricao.TabIndex = 10;
            lbDescricao.Text = "Descrição:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(274, 264);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(193, 264);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Location = new Point(45, 73);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(36, 15);
            lbValor.TabIndex = 14;
            lbValor.Text = "Valor:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(92, 70);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 15;
            // 
            // lbData
            // 
            lbData.AutoSize = true;
            lbData.Location = new Point(47, 105);
            lbData.Name = "lbData";
            lbData.Size = new Size(34, 15);
            lbData.TabIndex = 16;
            lbData.Text = "Data:";
            // 
            // txtData
            // 
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(92, 99);
            txtData.Name = "txtData";
            txtData.Size = new Size(100, 23);
            txtData.TabIndex = 17;
            // 
            // lbPagamento
            // 
            lbPagamento.AutoSize = true;
            lbPagamento.Location = new Point(10, 133);
            lbPagamento.Name = "lbPagamento";
            lbPagamento.Size = new Size(71, 15);
            lbPagamento.TabIndex = 18;
            lbPagamento.Text = "Pagamento:";
            // 
            // cmbPagamento
            // 
            cmbPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPagamento.FormattingEnabled = true;
            cmbPagamento.Location = new Point(92, 130);
            cmbPagamento.Name = "cmbPagamento";
            cmbPagamento.Size = new Size(135, 23);
            cmbPagamento.TabIndex = 19;
            // 
            // listCategorias
            // 
            listCategorias.FormattingEnabled = true;
            listCategorias.Location = new Point(92, 159);
            listCategorias.Name = "listCategorias";
            listCategorias.Size = new Size(232, 94);
            listCategorias.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 159);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 21;
            label1.Text = "Categorias:";
            // 
            // TelaDespesaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 317);
            Controls.Add(label1);
            Controls.Add(listCategorias);
            Controls.Add(cmbPagamento);
            Controls.Add(lbPagamento);
            Controls.Add(txtData);
            Controls.Add(lbData);
            Controls.Add(txtValor);
            Controls.Add(lbValor);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(txtDescricao);
            Controls.Add(lbDescricao);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaDespesaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaDispesaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label2;
        private TextBox txtDescricao;
        private Label lbDescricao;
        private Button btnCancelar;
        private Button btnGravar;
        private Label lbValor;
        private TextBox txtValor;
        private Label lbData;
        private DateTimePicker txtData;
        private Label lbPagamento;
        private ComboBox cmbPagamento;
        private CheckedListBox listCategorias;
        private Label label1;
    }
}