using e_Agenda.WinApp.ModuloCategoria;

namespace e_Agenda.WinApp.ModuloDespesa
{
    public class RepositorioDespesaEmMemoria : RepositorioEmMemoriaBase<Despesa>, IRepositorioDespesa
    {


        public override void Inserir(Despesa despesa)
        {
            base.Inserir(despesa);
            foreach(Categoria categoria in despesa.categorias)
            {
                categoria.despesas.Add(despesa);
            }
        }

        public override void Editar(Despesa despesa)
        {
            Despesa despesaSelecionada = SelecionarPorId(despesa.id);

            foreach (Categoria categoria in despesaSelecionada.categorias)
            {
                categoria.despesas = categoria.despesas.FindAll(d => d.id != despesa.id);
            }
            foreach (Categoria categoria in despesa.categorias)
            {
                categoria.despesas.Add(despesa);
            }

            despesaSelecionada.AtualizarInformacoes(despesa);
        }


        public override void Excluir(Despesa despesa)
        {
            foreach (Categoria categoria in despesa.categorias)
            {
                categoria.despesas = categoria.despesas.FindAll(d => d.id != despesa.id);
            }
            base.listaRegistros.Remove(despesa);
        }
    }
}
