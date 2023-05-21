using e_Agenda.WinApp.ModuloCompromisso;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class RepositorioTarefa
    {
        List<Tarefa> tarefas = new List<Tarefa>();
        private static int contador;
        private static int contadorItem;

        public void Inserir(Tarefa tarefa)
        {
            contador++;
            tarefa.id = contador;
            tarefas.Add(tarefa);
        }

        public void InserirItem(Tarefa tarefa, Item item)
        {
            Tarefa tarefaSelecionada = SelecionarPorId(tarefa.id);
            tarefaSelecionada.dataConclusao = new DateTime();
            item.id = ++contadorItem;
            tarefaSelecionada.itens.Add(item);
        }

        public void ConcluirItem(Tarefa tarefa, Item item)
        {
            Tarefa tarefaSelecionada = SelecionarPorId(tarefa.id);
            tarefaSelecionada.dataConclusao = tarefa.dataConclusao;
            if (item != null) {
                tarefaSelecionada.itens.Find(i => i == item).completado = true;
            }
        } 

        public List<Tarefa> SelecionarTodos()
        {
            return tarefas;
        }

        public List<Tarefa> SelecionarAlternativa(Predicate<Tarefa> alternativa)
        {
            return tarefas.FindAll(alternativa);
        }

        public List<Tarefa> SelecionarPrioridadeOrdenada()
        {
            string[] prioridades = { "Baixa", "Normal", "Alta" };
            tarefas.Sort(CompararPrioridades);
            return tarefas;
        }

        private int CompararPrioridades(Tarefa tarefaX, Tarefa tarefaY)
        {
            string prioridadeX = tarefaX.prioridade;
            string prioridadeY = tarefaY.prioridade;
            string[] prioridades = { "Baixa", "Normal", "Alta" };
            int x = Array.IndexOf(prioridades, prioridadeX);
            int y = Array.IndexOf(prioridades,prioridadeY);
            return x.CompareTo(y);
        }

        public void Editar(Tarefa tarefa)
        {
            Tarefa tarefaSelecionada = SelecionarPorId(tarefa.id);
            tarefaSelecionada.titulo = tarefa.titulo;
            tarefaSelecionada.prioridade = tarefa.prioridade;
        }

        private Tarefa SelecionarPorId(int id)
        {
            return tarefas.FirstOrDefault(x => x.id == id);
        }

        public void Excluir(Tarefa tarefa)
        {
            tarefas.Remove(tarefa);
        }
    }
}
