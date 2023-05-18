namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class TelaCompromissoFiltroForm : Form
    {
        public DateTime Periodo { 
            get 
            {
                return dateTimePeriodo.Value;
            } 
        }
        public TelaCompromissoFiltroForm()
        {
            InitializeComponent();
            this.dateTimePeriodo.MinDate = DateTime.Now;
        }
    }
}
