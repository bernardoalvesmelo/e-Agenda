using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class TabelaCompromissoControl : UserControl
    {
        public TabelaCompromissoControl()
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
                    Name = "assunto",
                    HeaderText = "Assunto"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "local",
                    HeaderText = "Local"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "data",
                    HeaderText = "Data"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "horaInicio",
                    HeaderText = "Início"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "horaTermino",
                    HeaderText = "Término"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "contatoCompromisso",
                    HeaderText = "Contato"
                }
            };

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Compromisso> compromissos)
        {
            grid.Rows.Clear();
            foreach (Compromisso compromisso in compromissos)
            {
                grid.Rows.Add(compromisso.id, compromisso.assunto, compromisso.local,
                    compromisso.data.ToString("dd/MM/yyyy"), 
                    compromisso.horaInicio.ToString("HH:mm"), 
                    compromisso.horaTermino.ToString("HH:mm"), 
                    compromisso.Contato);
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
