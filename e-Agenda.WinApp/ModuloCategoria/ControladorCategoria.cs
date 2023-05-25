using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public class ControladorCategoria : ControladorBase
    {
        private RepositorioCategoria repositorioCategoria;
        private ListagemCategoriaControl listagemCategoria;

        public ControladorCategoria(RepositorioCategoria repositorioCategoria)
        {
            this.repositorioCategoria = repositorioCategoria;
        }

        public override string ToolTipInserir { get { return "Inserir nova Categoria";  } }

        public override string ToolTipEditar { get { return "Editar Categoria existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Categoria existente"; } }

        public override bool InserirAbilitado { get { return true; } }

        public override bool EditarAbilitado { get { return true; } }

        public override bool ExcluirAbilitado { get { return true; } }

        public override bool FiltrarAbilitado { get { return false; } }

        public override bool ConcluirAbilitado { get { return false; } }

        public override bool AdicionarAbilitado { get { return false; } }
        public override void Inserir()
        {
            TelaCategoriaForm telaCategoria = new TelaCategoriaForm();

            DialogResult opcaoEscolhida = telaCategoria.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Categoria categoria = telaCategoria.Categoria;

                repositorioCategoria.Inserir(categoria);

                CarregarCategorias();
            }
        }

        public override void Visualizar()
        {
            Categoria categoria = listagemCategoria.ObterCategoriaSelecionada();

            if (categoria == null)
            {
                MessageBox.Show($"Selecione uma categoria primeiro!",
                    "Visualização de Dispesas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaCategoriaVizualisarForm telaCategoria = new TelaCategoriaVizualisarForm(categoria);

            telaCategoria.ShowDialog();
          
        }

        public override void Editar()
        {
            Categoria categoria = listagemCategoria.ObterCategoriaSelecionada();

            if (categoria == null)
            {
                MessageBox.Show($"Selecione uma categoria primeiro!", 
                    "Edição de Categorias",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaCategoriaForm telaCategoria = new TelaCategoriaForm();
            telaCategoria.Categoria = categoria;

            DialogResult opcaoEscolhida = telaCategoria.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCategoria.Editar(telaCategoria.Categoria);

                CarregarCategorias();
            }
        }

        public override void Excluir()
        {            
            Categoria categoria = listagemCategoria.ObterCategoriaSelecionada();

            if (categoria == null)
            {
                MessageBox.Show($"Selecione uma categoria primeiro!", 
                    "Exclusão de Categorias",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a categoria {categoria.titulo}?",
                "Exclusão de Categorias",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCategoria.Excluir(categoria);

                CarregarCategorias();
            }
        }

        private void CarregarCategorias()
        {
            List<Categoria> categorias = repositorioCategoria.SelecionarTodos();

            listagemCategoria.AtualizarRegistros(categorias);
        }

        public override UserControl ObterListagem()
        {
            if (listagemCategoria == null)
                listagemCategoria = new ListagemCategoriaControl();

            CarregarCategorias();

            return listagemCategoria;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Categorias";            
        }

        
    }
}
