using e_Agenda.WinApp.ModuloDespesa;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public class RepositorioCategoriaEmMemoria : RepositorioEmMemoriaBase<Categoria>, IRepositorioCategoria
    {
        public void AtualizarCategorias(List<Categoria> categorias)
        {
            foreach(Categoria categoria in categorias)
            {
                base.Editar(categoria);
            }
        }
    }
}
