using e_Agenda.Dominio.ModuloTarefa;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaTarefaListaForm : Form
    {
        private List<Item> listaItens;

        private Item item;
        public Item Item { get { return item; } }
        public List<Item> ListaItens
        {
            get { return listaItens; }
            set { listaItens = value; }
        }
        public TelaTarefaListaForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public void CarregarItens()
        {
            foreach (Item item in listaItens)
            {
                listItens.Items.Add(item.ToString());
            }
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text;
            bool completado = false;
            this.item = new Item(descricao, completado);

            string[] erros = item.Validar();
            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
        }
    }
}
