namespace e_Agenda.WinApp.ModuloCategoria
{
    public partial class TelaCategoriaVisualizarForm : Form
    {
        private Categoria categoria;
        public TelaCategoriaVisualizarForm(Categoria categoria)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            this.categoria = categoria;
            CarregarControls();
        }

        private void CarregarControls()
        {
            txtTitulo.Text = categoria.titulo;
            tabelaDespesa.AtualizarRegistros(categoria.despesas);
            lbDespesas.Text = $"Visualizando {categoria.despesas.Count} despesa(s)";
        }
    }
}
