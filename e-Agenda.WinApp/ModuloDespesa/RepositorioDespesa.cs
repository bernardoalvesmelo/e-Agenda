using e_Agenda.WinApp.ModuloCategoria;
using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloDespesa
{
    public class RepositorioDespesa : RepositorioBase<Despesa>
    {


        public void Inserir(Despesa despesa)
        {
            base.Inserir(despesa);
            foreach(Categoria categoria in despesa.categorias)
            {
                categoria.despesas.Add(despesa);
            }
        }

        public void Editar(Despesa despesa)
        {
            Despesa despesaSelecionada = SelecionarPorId(despesa.id);

            despesaSelecionada.AtualizarInformacoes(despesa);

            foreach (Categoria categoria in despesaSelecionada.categorias)
            {
                categoria.despesas.Remove(despesaSelecionada);
            }
            foreach (Categoria categoria in despesa.categorias)
            {
                categoria.despesas.Add(despesa);
            }
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
