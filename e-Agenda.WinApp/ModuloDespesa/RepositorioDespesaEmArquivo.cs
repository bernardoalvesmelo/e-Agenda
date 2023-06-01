using e_Agenda.WinApp.ModuloCategoria;

namespace e_Agenda.WinApp.ModuloDespesa
{
    public class RepositorioDespesaEmArquivo : RepositorioEmArquivoBase<Despesa>,
        IRepositorioDespesa
    {
        private const string NOME_ARQUIVO_DESPESAS = "ModuloDespesa\\despesas";
        public RepositorioDespesaEmArquivo() : base(NOME_ARQUIVO_DESPESAS)
        {
        }

        public List<Despesa> ObterDespesasRespectivas(Categoria categoria)
        {
            List<Despesa> despesas = new List<Despesa>();
            foreach (Despesa despesa in base.listaRegistros)
            {
                if (despesa.categorias.Find(d => d.id == categoria.id) != null)
                {
                    despesas.Add(despesa);
                }
            }
            return despesas;
        }
    }
}
