namespace e_Agenda.WinApp.ModuloCategoria
{
    public partial class ListagemCategoriaControl : UserControl
    {
        public ListagemCategoriaControl()
        {
            InitializeComponent();
        }
        public void AtualizarRegistros(List<Categoria> categorias)
        {
            listCategorias.Items.Clear();

            foreach (Categoria item in categorias)
            {
                listCategorias.Items.Add(item);
            }

        }

        public Categoria ObterCategoriaSelecionada()
        {
            return (Categoria)listCategorias.SelectedItem;
        }
    }
}
