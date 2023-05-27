using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloDespesa;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public partial class TabelaCategoriaControl : UserControl
    {
        public TabelaCategoriaControl()
        {
            InitializeComponent();

            ConfigurarColunas();

            grid.ConfigurarGridZebrado();

            grid.ConfigurarGridSomenteLeitura();
        }

        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "Id"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "titulo",
                    HeaderText = "Título"
                }
            };

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Categoria> categorias)
        {
            grid.Rows.Clear();
            foreach (Categoria categoria in categorias)
            {
                grid.Rows.Add(categoria.id, categoria.titulo);
            }
            TelaPrincipalForm.Instancia.AtualizarRodape(
                $"Visualizando {categorias.Count} categoria(s)");
        }

        public int ObterIdSelecionado()
        {
            int id = -1;
            try
            {
                id = Convert.ToInt32(grid.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
            }

            return id;
        }
    }
}
