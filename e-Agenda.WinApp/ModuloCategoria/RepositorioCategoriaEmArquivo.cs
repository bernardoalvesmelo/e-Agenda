namespace e_Agenda.WinApp.ModuloCategoria
{
    public class RepositorioCategoriaEmArquivo : RepositorioEmArquivoBase<Categoria>,
        IRepositorioCategoria
    {
        public RepositorioCategoriaEmArquivo()
        {
        }

        protected override List<Categoria> ObterRegistros()
        {
            return base.contexto.categorias;
        }
    }
}
