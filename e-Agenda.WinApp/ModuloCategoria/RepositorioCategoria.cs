namespace e_Agenda.WinApp.ModuloCategoria
{
    public class RepositorioCategoria
    {
        List<Categoria> categorias = new List<Categoria>();
        private static int contador;

        public void Inserir(Categoria categoria)
        {
            contador++;
            categoria.id = contador;
            categorias.Add(categoria);
        }

        public List<Categoria> SelecionarTodos()
        {
            return categorias;
        }

        public void Editar(Categoria categoria)
        {
            Categoria categoriaSelecionada = SelecionarPorId(categoria.id);

            categoriaSelecionada.titulo = categoria.titulo;    
        }

        public Categoria SelecionarPorId(int id)
        {
            return categorias.FirstOrDefault(x => x.id == id);
        }

        public void Excluir(Categoria categoria)
        {
            categorias.Remove(categoria);
        }
    }
}
