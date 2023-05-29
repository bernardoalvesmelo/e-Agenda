namespace e_Agenda.WinApp.Compartilhado
{
    public abstract class EntidadeBase<TEntidade>
    {
        public int id;

        public abstract string[] Validar();

        public abstract void AtualizarInformacoes(TEntidade entidade);
       
    }
}
