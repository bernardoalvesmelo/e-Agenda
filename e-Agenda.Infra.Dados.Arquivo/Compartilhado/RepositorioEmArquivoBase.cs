namespace e_Agenda.Infra.Dados.Arquivo.Compartilhado
{
    public abstract class RepositorioEmArquivoBase<TEntidade>
        where TEntidade : EntidadeBase<TEntidade>
    {
        protected ContextoDados contexto = ContextoDados.Instancia;

        protected int contadorRegistros = 0;
  
        public RepositorioEmArquivoBase()
        {
            contexto = ContextoDados.Instancia;
            AtualizarContador();
        }

        public virtual void Inserir(TEntidade registro)
        {
            contadorRegistros++;
            registro.id = contadorRegistros;
            ObterRegistros().Add(registro);

            this.contexto.GravarRegistrosEmArquivo();
        }

        public virtual void Editar(TEntidade registroAtualizado)
        {
            TEntidade registroSelecionado = SelecionarPorId(registroAtualizado.id);

            registroSelecionado.AtualizarInformacoes(registroAtualizado);

            this.contexto.GravarRegistrosEmArquivo();
        }

        public virtual void Excluir(TEntidade registroSelecionado)
        {
            ObterRegistros().Remove(registroSelecionado);

            this.contexto.GravarRegistrosEmArquivo();
        }

        public virtual TEntidade SelecionarPorId(int id)
        {
            TEntidade registro = ObterRegistros().FirstOrDefault(x => x.id == id);

            return registro;
        }

        public virtual List<TEntidade> SelecionarTodos()
        {
            return ObterRegistros();
        }

        protected virtual void AtualizarContador()
        {
            if(ObterRegistros().Count > 0)
                contadorRegistros = ObterRegistros().Max(x => x.id);
        }

        protected abstract List<TEntidade> ObterRegistros();
        
    }
}

