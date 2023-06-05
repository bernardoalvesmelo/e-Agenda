using e_Agenda.Dominio.ModuloTarefa;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaTarefaListaForm : Form
    {
        private List<Item> listaItens;
        public List<Item> ListaItens
        {
            get { return listaItens; }
        }
        public TelaTarefaListaForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
            listaItens = new List<Item>();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            if (listaItens.Count == 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("Nenhum item inserido");
                DialogResult = DialogResult.None;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text;
            bool completado = false;
            Item item = new Item(descricao, completado);

            string[] erros = item.Validar();
            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                return;
            }

            listaItens.Add(item);
            listItens.Items.Add(item.descricao);
        }
    }
}
