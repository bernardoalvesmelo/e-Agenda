namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaTarefaCompletadoForm : Form
    {
        private Item item;
        public Item Item { get { return item; } }

        private List<Item> itens;
        public List<Item> ListaItens { set { itens = value; } }

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
        }
    }
}
