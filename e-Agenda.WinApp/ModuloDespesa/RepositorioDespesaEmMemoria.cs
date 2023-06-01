using e_Agenda.WinApp.ModuloCategoria;

namespace e_Agenda.WinApp.ModuloDespesa
{
    public class RepositorioDespesaEmMemoria : RepositorioEmMemoriaBase<Despesa>, IRepositorioDespesa
    {
        public List<Despesa> ObterDespesasRespectivas(Categoria categoria)
        {
            List<Despesa> despesas = new List<Despesa>();
            foreach(Despesa despesa in base.listaRegistros)
            {
                if(despesa.categorias.Find(d => d.id == categoria.id) != null)
                {
                    despesas.Add(despesa);
                }
            }
            return despesas;
        } 
    }
}
