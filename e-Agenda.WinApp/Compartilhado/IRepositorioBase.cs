namespace e_Agenda.WinApp.Compartilhado
{
    public interface IRepositorioBase<TEntidade>
        where TEntidade : EntidadeBase<TEntidade>
    {
        void Editar(TEntidade registro);
        void Excluir(TEntidade registro);
        void Inserir(TEntidade registro);
        TEntidade SelecionarPorId(int id);
        List<TEntidade> SelecionarTodos();
    }
}
