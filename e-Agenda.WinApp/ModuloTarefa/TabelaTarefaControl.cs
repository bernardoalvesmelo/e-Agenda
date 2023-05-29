namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TabelaTarefaControl : UserControl
    {
        public TabelaTarefaControl()
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
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "prioridade",
                    HeaderText = "Prioridade"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "dataCriacao",
                    HeaderText = "Data de Criação:"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "dataConclusao",
                    HeaderText = "Data de Conclusão"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "percentual",
                    HeaderText = "Percentagem Concluído"
                }
            };

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Tarefa> tarefas)
        {
            grid.Rows.Clear();
            foreach (Tarefa tarefa in tarefas)
            {
                grid.Rows.Add(tarefa.id, tarefa.titulo, tarefa.prioridade, 
                    tarefa.dataCriacao.ToString("dd/MM/yyyy"), tarefa.DataConclusao, 
                    tarefa.Percentual);
            }
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
