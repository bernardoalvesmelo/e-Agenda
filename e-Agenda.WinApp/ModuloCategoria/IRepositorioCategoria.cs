namespace e_Agenda.WinApp.ModuloCategoria
{
    public interface IRepositorioCategoria : IRepositorioBase<Categoria>
    {
        public void AtualizarCategorias(List<Categoria> categorias);
    }
}
