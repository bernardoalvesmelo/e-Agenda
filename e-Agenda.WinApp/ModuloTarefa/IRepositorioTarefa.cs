namespace e_Agenda.WinApp.ModuloTarefa
{
    public interface IRepositorioTarefa : IRepositorioBase<Tarefa>
    {
        void ConcluirItem(Tarefa tarefa, Item item);
        void InserirItem(Tarefa tarefa, Item item);
        List<Tarefa> SelecionarAlternativa(Predicate<Tarefa> alternativa);
        List<Tarefa> SelecionarPrioridadeOrdenada();
    }
}
