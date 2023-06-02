using e_Agenda.Dominio.ModuloCategoria;
using e_Agenda.Dominio.ModuloDespesa;

namespace e_Agenda.Infra.Dados.Memoria.ModuloDespesa
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
