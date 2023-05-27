using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloContato
{
    public partial class TabelaContatoControl : UserControl
    {
        public TabelaContatoControl()
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
                    Name = "nome",
                    HeaderText = "Nome"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "telefone",
                    HeaderText = "Telefone"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "email",
                    HeaderText = "Email"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "cargo",
                    HeaderText = "Cargo"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "empresa",
                    HeaderText = "Empresa"
                }
        };

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Contato> contatos)
        {
            grid.Rows.Clear();
            foreach (Contato contato in contatos)
            {
                grid.Rows.Add(contato.id, contato.nome, contato.telefone, contato.email, 
                    contato.cargo, contato.empresa);
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
