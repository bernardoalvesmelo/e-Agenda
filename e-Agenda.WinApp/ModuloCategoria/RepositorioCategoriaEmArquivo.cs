namespace e_Agenda.WinApp.ModuloCategoria
{
    public class RepositorioCategoriaEmArquivo : RepositorioEmArquivoBase<Categoria>,
        IRepositorioCategoria
    {
        private const string NOME_ARQUIVO_CATEGORIAS = "C:\\temp\\categorias\\dados-categorias.bin";
        public RepositorioCategoriaEmArquivo() : base(NOME_ARQUIVO_CATEGORIAS)
        {
        }

        public void AtualizarCategorias(List<Categoria> categorias)
        {
            foreach (Categoria categoria in categorias)
            {
                base.Editar(categoria);
            }
        }
    }
}
