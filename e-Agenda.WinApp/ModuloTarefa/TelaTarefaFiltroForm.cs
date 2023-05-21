namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaTarefaFiltroForm : Form
    {
        public int Alternativa
        {
            get
            {
                return cmbAlternativa.SelectedIndex;
            }
        }

        public TelaTarefaFiltroForm()
        {
            InitializeComponent();
        }
    }
}
