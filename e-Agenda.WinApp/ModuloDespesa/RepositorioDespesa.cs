using e_Agenda.WinApp.ModuloCategoria;

namespace e_Agenda.WinApp.ModuloDespesa
{
    public class RepositorioDespesa
    {
        List<Despesa> despesas = new List<Despesa>();
        private static int contador;

        public void Inserir(Despesa despesa)
        {
            contador++;
            despesa.id = contador;
            foreach(Categoria categoria in despesa.categorias)
            {
                categoria.despesas.Add(despesa);
            }
            despesas.Add(despesa);
        }

        public List<Despesa> SelecionarTodos()
        {
            return despesas;
        }

        public void Editar(Despesa despesa)
        {
            Despesa despesaSelecionada = SelecionarPorId(despesa.id);

            despesaSelecionada.descricao = despesa.descricao;
            despesaSelecionada.data = despesa.data;
            despesaSelecionada.valor = despesa.valor;
            despesaSelecionada.formaPagamento = despesa.formaPagamento;
            foreach(Categoria categoria in despesaSelecionada.categorias)
            {
                categoria.despesas.Remove(despesaSelecionada);
            }
            foreach (Categoria categoria in despesa.categorias)
            {
                categoria.despesas.Add(despesa);
            }
            despesaSelecionada.categorias = despesa.categorias;
        }

        public Despesa SelecionarPorId(int id)
        {
            return despesas.FirstOrDefault(x => x.id == id);
        }

        public void Excluir(Despesa despesa)
        {
            foreach (Categoria categoria in despesa.categorias)
            {
                categoria.despesas.Remove(despesa);
            }
            despesas.Remove(despesa);
        }
    }
}
