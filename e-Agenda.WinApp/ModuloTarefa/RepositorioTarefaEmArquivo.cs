namespace e_Agenda.WinApp.ModuloTarefa
{
    public class RepositorioTarefaEmArquivo : RepositorioEmArquivoBase<Tarefa>,
        IRepositorioTarefa
    {
        private const string NOME_ARQUIVO_TAREFAS = "ModuloTarefa\\tarefas";
        public RepositorioTarefaEmArquivo() : base(NOME_ARQUIVO_TAREFAS)
        {
        }

        private static int contadorItem;

        public void InserirItem(Tarefa tarefa, Item item)
        {
            Tarefa tarefaSelecionada = base.SelecionarPorId(tarefa.id);
            tarefaSelecionada.dataConclusao = new DateTime();
            item.id = ++contadorItem;
            tarefaSelecionada.itens.Add(item);
            base.GravarRegistrosEmArquivo();
        }

        public void ConcluirItem(Tarefa tarefa, Item item)
        {
            Tarefa tarefaSelecionada = base.SelecionarPorId(tarefa.id);
            tarefaSelecionada.dataConclusao = tarefa.dataConclusao;
            if (item != null)
            {
                tarefaSelecionada.itens.Find(i => i == item).completado = true;
            }
            base.GravarRegistrosEmArquivo();
        }


        public List<Tarefa> SelecionarAlternativa(Predicate<Tarefa> alternativa)
        {
            return base.listaRegistros.FindAll(alternativa);
        }

        public List<Tarefa> SelecionarPrioridadeOrdenada()
        {
            string[] prioridades = { "Baixa", "Normal", "Alta" };
            base.listaRegistros.Sort(CompararPrioridades);
            return base.listaRegistros;
        }

        private int CompararPrioridades(Tarefa tarefaX, Tarefa tarefaY)
        {
            string prioridadeX = tarefaX.prioridade;
            string prioridadeY = tarefaY.prioridade;
            string[] prioridades = { "Baixa", "Normal", "Alta" };
            int x = Array.IndexOf(prioridades, prioridadeX);
            int y = Array.IndexOf(prioridades, prioridadeY);
            return y.CompareTo(x);
        }
    }
}
