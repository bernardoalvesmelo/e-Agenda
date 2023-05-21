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
