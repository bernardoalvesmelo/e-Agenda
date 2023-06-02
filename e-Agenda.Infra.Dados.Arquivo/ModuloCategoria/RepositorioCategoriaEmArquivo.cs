using e_Agenda.Dominio.ModuloCategoria;

namespace e_Agenda.Infra.Dados.Arquivo.ModuloCategoria
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
