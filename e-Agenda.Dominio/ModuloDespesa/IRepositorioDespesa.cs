using e_Agenda.Dominio.ModuloCategoria;

namespace e_Agenda.Dominio.ModuloDespesa
{
    public interface IRepositorioDespesa : IRepositorioBase<Despesa>
    {
        public List<Despesa> ObterDespesasRespectivas(Categoria categoria);
    }
}
