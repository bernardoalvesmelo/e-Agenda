using e_Agenda.WinApp.ModuloDespesa;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public partial class TelaCategoriaVisualizarForm : Form
    {
        private Categoria categoria;
        public TelaCategoriaVisualizarForm(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            CarregarControls();
        }

        private void CarregarControls()
        {
            txtTitulo.Text = categoria.titulo;
            foreach (Despesa despesa in categoria.despesas)
            {
                listDespesas.Items.Add(despesa);
            }
        }
    }
}
