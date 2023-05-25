namespace e_Agenda.WinApp.ModuloDispesa
{
    partial class TelaDispesaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listDispesas = new ListBox();
            SuspendLayout();
            // 
            // listDispesas
            // 
            listDispesas.Dock = DockStyle.Fill;
            listDispesas.FormattingEnabled = true;
            listDispesas.ItemHeight = 15;
            listDispesas.Location = new Point(0, 0);
            listDispesas.Name = "listDispesas";
            listDispesas.Size = new Size(150, 150);
            listDispesas.TabIndex = 0;
            // 
            // TelaDispesaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listDispesas);
            Name = "TelaDispesaControl";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listDispesas;
    }
}
