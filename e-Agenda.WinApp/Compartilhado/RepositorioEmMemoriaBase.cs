namespace e_Agenda.WinApp.Compartilhado
{
    public abstract class RepositorioEmMemoriaBase<TEntidade>
        where TEntidade : EntidadeBase<TEntidade>
    {
        protected List<TEntidade> listaRegistros = new List<TEntidade>();
        protected int contadorRegistros = 0;

        public virtual void Inserir(TEntidade registro)
        {
            contadorRegistros++;

            registro.id = contadorRegistros;

            listaRegistros.Add(registro);
        }

        public virtual void Editar(TEntidade registroAtualizado)
        {
            TEntidade registroSelecionado = SelecionarPorId(registroAtualizado.id);

            registroSelecionado.AtualizarInformacoes(registroAtualizado);
        }

        public virtual void Excluir(TEntidade registro)
        {
            TEntidade registroSelecionado = SelecionarPorId(registro.id);

            if (registroSelecionado != null)
            {
                listaRegistros.Remove(registroSelecionado);
            }
        }

        public virtual TEntidade SelecionarPorId(int id)
        {
            return listaRegistros.FirstOrDefault(x => x.id == id);
        }

        public virtual List<TEntidade> SelecionarTodos()
        {
            return listaRegistros.OrderByDescending(x => x.id).ToList();
        }
    }

}