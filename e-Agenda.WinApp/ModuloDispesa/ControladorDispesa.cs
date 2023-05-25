using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloCategoria;

namespace e_Agenda.WinApp.ModuloDispesa
{
    public class ControladorDispesa : ControladorBase
    {
        private RepositorioDispesa repositorioDispesa;
        private RepositorioCategoria repositorioCategoria;
        private ListagemDispesaControl listagemDispesa;

        public ControladorDispesa(RepositorioDispesa repositorioDispesa, RepositorioCategoria repositorioCategoria)
        {
            this.repositorioDispesa = repositorioDispesa;
            this.repositorioCategoria = repositorioCategoria;

        }

        public override string ToolTipInserir { get { return "Inserir nova Dispesa";  } }

        public override string ToolTipEditar { get { return "Editar Dispesa existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Dispesa existente"; } }

        public override bool InserirAbilitado { get { return true; } }

        public override bool EditarAbilitado { get { return true; } }

        public override bool ExcluirAbilitado { get { return true; } }

        public override bool FiltrarAbilitado { get { return false; } }

        public override bool ConcluirAbilitado { get { return false; } }

        public override bool AdicionarAbilitado { get { return false; } }
        public override void Inserir()
        {
            TelaDispesaForm telaDispesa = new TelaDispesaForm(
                repositorioCategoria.SelecionarTodos());

            DialogResult opcaoEscolhida = telaDispesa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Dispesa dispesa = telaDispesa.Dispesa;

                repositorioDispesa.Inserir(dispesa);

                CarregarDispesas();
            }
        }

        public override void Editar()
        {
            Dispesa dispesa = listagemDispesa.ObterDispesaSelecionada();

            if (dispesa == null)
            {
                MessageBox.Show($"Selecione uma dispesa primeiro!", 
                    "Edição de Dispesas",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);

                return;
            }
            TelaDispesaForm telaDispesa = new TelaDispesaForm(
                            repositorioCategoria.SelecionarTodos());
            telaDispesa.Dispesa = dispesa;

            DialogResult opcaoEscolhida = telaDispesa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioDispesa.Editar(telaDispesa.Dispesa);

                CarregarDispesas();
            }
        }

        public override void Excluir()
        {            
            Dispesa dispesa = listagemDispesa.ObterDispesaSelecionada();

            if (dispesa == null)
            {
                MessageBox.Show($"Selecione uma dispesa primeiro!", 
                    "Exclusão de Dispesas",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a dispesa {dispesa.descricao}?", "Exclusão de Dispesas",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioDispesa.Excluir(dispesa);

                CarregarDispesas();
            }
        }

        private void CarregarDispesas()
        {
            List<Dispesa> dispesas = repositorioDispesa.SelecionarTodos();

            listagemDispesa.AtualizarRegistros(dispesas);
        }

        public override UserControl ObterListagem()
        {
            if (listagemDispesa == null)
                listagemDispesa = new ListagemDispesaControl();

            CarregarDispesas();

            return listagemDispesa;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Dispesas";            
        }

        
    }
}
