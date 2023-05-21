namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class TelaTarefaCompletadoForm
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
            btnConcluir = new Button();
            lbItem = new Label();
            cmbItens = new ComboBox();
            dateTimeConclusao = new DateTimePicker();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(265, 89);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConcluir
            // 
            btnConcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConcluir.DialogResult = DialogResult.OK;
            btnConcluir.Location = new Point(184, 89);
            btnConcluir.Name = "btnConcluir";
            btnConcluir.Size = new Size(75, 41);
            btnConcluir.TabIndex = 13;
            btnConcluir.Text = "Concluir";
            btnConcluir.UseVisualStyleBackColor = true;
            btnConcluir.Click += btnConcluir_Click;
            // 
            // lbItem
            // 
            lbItem.AutoSize = true;
            lbItem.Location = new Point(90, 30);
            lbItem.Name = "lbItem";
            lbItem.Size = new Size(34, 15);
            lbItem.TabIndex = 15;
            lbItem.Text = "Item:";
            // 
            // cmbItens
            // 
            cmbItens.FormattingEnabled = true;
            cmbItens.Location = new Point(130, 22);
            cmbItens.Name = "cmbItens";
            cmbItens.Size = new Size(200, 23);
            cmbItens.TabIndex = 16;
            // 
            // dateTimeConclusao
            // 
            dateTimeConclusao.Location = new Point(130, 51);
            dateTimeConclusao.Name = "dateTimeConclusao";
            dateTimeConclusao.Size = new Size(200, 23);
            dateTimeConclusao.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 57);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 18;
            label2.Text = "Conclusão da Tarefa:";
            // 
            // TelaTarefaCompletadoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 142);
            Controls.Add(label2);
            Controls.Add(dateTimeConclusao);
            Controls.Add(cmbItens);
            Controls.Add(lbItem);
            Controls.Add(btnCancelar);
            Controls.Add(btnConcluir);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaTarefaCompletadoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conclusão de Itens";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnConcluir;
        private Label lbItem;
        private ComboBox cmbItens;
        private DateTimePicker dateTimeConclusao;
        private Label label2;
    }
}