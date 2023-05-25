using e_Agenda.WinApp.ModuloDispesa;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public partial class TelaCategoriaVizualisarForm : Form
    {
        private Categoria categoria;
        public TelaCategoriaVizualisarForm(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            CarregarControls();
        }

        private void CarregarControls()
        {
            txtTitulo.Text = categoria.titulo;
            foreach (Dispesa dispesa in categoria.dispesas)
            {
                listDispesas.Items.Add(dispesa);
            }
        }
    }
}
