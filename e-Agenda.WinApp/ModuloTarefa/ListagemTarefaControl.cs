namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class ListagemTarefaControl : UserControl
    {
        public ListagemTarefaControl()
        {
            InitializeComponent();
        }
        public void AtualizarRegistros(List<Tarefa> tarefas)
        {
            listTarefas.Items.Clear();

            foreach (Tarefa item in tarefas)
            {
                listTarefas.Items.Add(item);
            }
        }

        public Tarefa ObterTarefaSelecionada()
        {
            return (Tarefa)listTarefas.SelectedItem;
        }
    }
}

