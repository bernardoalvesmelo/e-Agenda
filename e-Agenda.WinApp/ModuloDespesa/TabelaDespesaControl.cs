using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloTarefa;

namespace e_Agenda.WinApp.ModuloDespesa
{
    public partial class TabelaDespesaControl : UserControl
    {
        public TabelaDespesaControl()
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
                    Name = "descricao",
                    HeaderText = "Descrição"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "valor",
                    HeaderText = "Valor R$"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "data",
                    HeaderText = "Data"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "formaPagamento",
                    HeaderText = "Pagamento"
                }
            };

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Despesa> despesas)
        {
            grid.Rows.Clear();
            foreach (Despesa despesa in despesas)
            {
                grid.Rows.Add(despesa.id, despesa.descricao, Math.Round(despesa.valor, 2),
                    despesa.data.ToString("dd/MM/yyyy"), despesa.formaPagamento);
            }
            TelaPrincipalForm.Instancia.AtualizarRodape(
                $"Visualizando {despesas.Count} despesa(s)");
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
