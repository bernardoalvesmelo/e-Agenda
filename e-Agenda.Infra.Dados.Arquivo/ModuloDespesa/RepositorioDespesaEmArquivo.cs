using e_Agenda.Dominio.ModuloCategoria;
using e_Agenda.Dominio.ModuloDespesa;

namespace e_Agenda.Infra.Dados.Arquivo.ModuloDespesa
{
    public class RepositorioDespesaEmArquivo : RepositorioEmArquivoBase<Despesa>,
        IRepositorioDespesa
    {
        public RepositorioDespesaEmArquivo()
        {
        }

        public List<Despesa> ObterDespesasRespectivas(Categoria categoria)
        {
            List<Despesa> despesas = new List<Despesa>();
            foreach (Despesa despesa in ObterRegistros())
            {
                if (despesa.categorias.Find(d => d.id == categoria.id) != null)
                {
                    despesas.Add(despesa);
                }
            }
            return despesas;
        }

        protected override List<Despesa> ObterRegistros()
        {
            return base.contexto.despesas;
        }
    }
}
