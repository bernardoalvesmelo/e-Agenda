namespace e_Agenda.WinApp.ModuloCategoria
{
    public class RepositorioCategoriaEmArquivo : RepositorioEmArquivoBase<Categoria>,
        IRepositorioCategoria
    {
        private const string NOME_ARQUIVO_CATEGORIAS = "ModuloCategoria\\categorias";
        public RepositorioCategoriaEmArquivo() : base(NOME_ARQUIVO_CATEGORIAS)
        {
        }
    }
}
