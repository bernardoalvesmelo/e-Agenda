namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class TelaCompromissoAlternativaForm : Form
    {
        public int Alternativa
        {
            get
            {
                return cmbAlternativa.SelectedIndex;
            }
        }
        public TelaCompromissoAlternativaForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

    }
}
