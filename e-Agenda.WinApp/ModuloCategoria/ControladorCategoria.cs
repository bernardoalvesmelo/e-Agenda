using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public class ControladorCategoria : ControladorBase
    {
        private RepositorioCategoria repositorioCategoria;
        private TabelaCategoriaControl tabelaCategoria;

        public ControladorCategoria(RepositorioCategoria repositorioCategoria)
        {
            this.repositorioCategoria = repositorioCategoria;
        }

        public override string ToolTipInserir { get { return "Inserir nova Categoria";  } }

        public override string ToolTipEditar { get { return "Editar Categoria existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Categoria existente"; } }

        public override string ToolTipVisualizar { get { return "Visualizar Despesas correspondentes"; } }

        public override bool InserirHabilitado { get { return true; } }

        public override bool EditarHabilitado { get { return true; } }

        public override bool ExcluirHabilitado { get { return true; } }

        public override bool FiltrarHabilitado { get { return false; } }

        public override bool ConcluirHabilitado { get { return false; } }

        public override bool AdicionarHabilitado { get { return false; } }

        public override bool VisualizarHabilitado { get { return true; } }
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
            Categoria categoria = ObterCategoriaSelecionada();

            if (categoria == null)
            {
                MessageBox.Show($"Selecione uma categoria primeiro!",
                    "Visualização de Dispesas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaCategoriaVisualizarForm telaCategoria = new TelaCategoriaVisualizarForm(categoria);

            telaCategoria.ShowDialog();
            CarregarCategorias();
        }

        public override void Editar()
        {
            Categoria categoria = ObterCategoriaSelecionada();

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
            Categoria categoria = ObterCategoriaSelecionada();

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

            tabelaCategoria.AtualizarRegistros(categorias);
        }

        public Categoria ObterCategoriaSelecionada()
        {
            int id = tabelaCategoria.ObterIdSelecionado();

            return repositorioCategoria.SelecionarPorId(id);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaCategoria == null)
                tabelaCategoria = new TabelaCategoriaControl();

            CarregarCategorias();

            return tabelaCategoria;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Categorias";            
        }
    }
}
