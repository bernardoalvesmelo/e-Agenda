using e_Agenda.WinApp.ModuloDespesa;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public partial class TelaCategoriaVisualizarForm : Form
    {
        private Categoria categoria;
        private List<Despesa> despesas;
        public TelaCategoriaVisualizarForm(Categoria categoria, List<Despesa> despesas)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            this.categoria = categoria;
            this.despesas = despesas;
            CarregarControls();
        }

        private void CarregarControls()
        {
            txtTitulo.Text = categoria.titulo;
            tabelaDespesa.AtualizarRegistros(this.despesas);
            lbDespesas.Text = $"Visualizando {this.despesas.Count} despesa(s)";
        }
    }
}
