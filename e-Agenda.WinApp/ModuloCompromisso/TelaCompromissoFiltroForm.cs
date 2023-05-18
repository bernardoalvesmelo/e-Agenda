namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class TelaCompromissoFiltroForm : Form
    {
        public DateTime DataInicial
        {
            get
            {
                return dateTimeInicio.Value;
            }
        }

        public DateTime DataFinal
        {
            get
            {
                return dateTimeFinal.Value;
            }
        }
        public TelaCompromissoFiltroForm()
        {
            InitializeComponent();
            this.dateTimeInicio.MinDate = DateTime.Now;
            this.dateTimeFinal.MinDate = DateTime.Now;
        }
    }
}
