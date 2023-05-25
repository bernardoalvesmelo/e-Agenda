using e_Agenda.WinApp.ModuloCategoria;

namespace e_Agenda.WinApp.ModuloDispesa
{
    public class RepositorioDispesa
    {
        List<Dispesa> dispesas = new List<Dispesa>();
        private static int contador;

        public void Inserir(Dispesa dispesa)
        {
            contador++;
            dispesa.id = contador;
            foreach(Categoria categoria in dispesa.categorias)
            {
                categoria.dispesas.Add(dispesa);
            }
            dispesas.Add(dispesa);
        }

        public List<Dispesa> SelecionarTodos()
        {
            return dispesas;
        }

        public void Editar(Dispesa dispesa)
        {
            Dispesa dispesaSelecionada = SelecionarPorId(dispesa.id);

            dispesaSelecionada.descricao = dispesa.descricao;
            dispesaSelecionada.data = dispesa.data;
            dispesaSelecionada.valor = dispesa.valor;
            dispesaSelecionada.formaPagamento = dispesa.formaPagamento;
            foreach(Categoria categoria in dispesaSelecionada.categorias)
            {
                categoria.dispesas.Remove(dispesaSelecionada);
            }
            foreach (Categoria categoria in dispesa.categorias)
            {
                categoria.dispesas.Add(dispesa);
            }
            dispesaSelecionada.categorias = dispesa.categorias;
        }

        private Dispesa SelecionarPorId(int id)
        {
            return dispesas.FirstOrDefault(x => x.id == id);
        }

        public void Excluir(Dispesa dispesa)
        {
            foreach (Categoria categoria in dispesa.categorias)
            {
                categoria.dispesas.Remove(dispesa);
            }
            dispesas.Remove(dispesa);
        }
    }
}
