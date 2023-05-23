using e_Agenda.WinApp.ModuloCompromisso;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaTarefaCompletadoForm : Form
    {
        private Item item;
        public Item Item { get { return item; } }

        private List<Item> itens;

        private Tarefa tarefa;

        public Tarefa Tarefa
        {
            set
            {
                this.itens = value.itens;
                this.tarefa = new Tarefa(value.titulo, value.prioridade, value.dataCriacao);
            }
            get
            {
                return this.tarefa;
            }
        }

        public DateTime DataConclusao { 
            get 
            {
               return dateTimeConclusao.Enabled ?
               dateTimeConclusao.Value : new DateTime();
            } 
        }
        public TelaTarefaCompletadoForm()
        {
            InitializeComponent();
        }

        public void CarregarItens()
        {
            if(itens.Count > 1)
            {
                dateTimeConclusao.Enabled = false;
            }
            if(itens.Count > 0)
            {
                foreach(Item item in itens)
                {
                    cmbItens.Items.Add(item.descricao);
                }
                cmbItens.SelectedItem = itens[0].descricao;
                return;
            }
            if (itens.Count == 0)
            {
                cmbItens.Enabled = false;
            }
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            if(itens.Count > 0)
            {
                item = itens.Find(i => i.descricao == cmbItens.SelectedItem);
            }

            tarefa.dataConclusao = dateTimeConclusao.Enabled ?
               dateTimeConclusao.Value : new DateTime();
            string[] erros = tarefa.Validar();
            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
        }
    }
}
