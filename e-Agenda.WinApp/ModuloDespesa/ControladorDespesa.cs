using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloCategoria;

namespace e_Agenda.WinApp.ModuloDespesa
{
    public class ControladorDespesa : ControladorBase
    {
        private RepositorioDespesa repositorioDespesa;
        private RepositorioCategoria repositorioCategoria;
        private ListagemDespesaControl listagemDespesa;

        public ControladorDespesa(RepositorioDespesa repositorioDespesa, RepositorioCategoria repositorioCategoria)
        {
            this.repositorioDespesa = repositorioDespesa;
            this.repositorioCategoria = repositorioCategoria;

        }

        public override string ToolTipInserir { get { return "Inserir nova Despesa";  } }

        public override string ToolTipEditar { get { return "Editar Despesa existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Despesa existente"; } }

        public override bool InserirHabilitado { get { return true; } }

        public override bool EditarHabilitado { get { return true; } }

        public override bool ExcluirHabilitado { get { return true; } }

        public override bool FiltrarHabilitado { get { return false; } }

        public override bool ConcluirHabilitado { get { return false; } }

        public override bool AdicionarHabilitado { get { return false; } }
        public override void Inserir()
        {
            TelaDespesaForm telaDespesa = new TelaDespesaForm(
                repositorioCategoria.SelecionarTodos());

            DialogResult opcaoEscolhida = telaDespesa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Despesa despesa = telaDespesa.Despesa;

                repositorioDespesa.Inserir(despesa);

                CarregarDespesas();
            }
        }

        public override void Editar()
        {
            Despesa despesa = listagemDespesa.ObterDespesaSelecionada();

            if (despesa == null)
            {
                MessageBox.Show($"Selecione uma despesa primeiro!", 
                    "Edição de Despesas",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);

                return;
            }
            TelaDespesaForm telaDespesa = new TelaDespesaForm(
                            repositorioCategoria.SelecionarTodos());
            telaDespesa.Despesa = despesa;

            DialogResult opcaoEscolhida = telaDespesa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioDespesa.Editar(telaDespesa.Despesa);

                CarregarDespesas();
            }
        }

        public override void Excluir()
        {            
            Despesa despesa = listagemDespesa.ObterDespesaSelecionada();

            if (despesa == null)
            {
                MessageBox.Show($"Selecione uma despesa primeiro!", 
                    "Exclusão de Despesas",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a despesa {despesa.descricao}?", "Exclusão de Despesas",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioDespesa.Excluir(despesa);

                CarregarDespesas();
            }
        }

        private void CarregarDespesas()
        {
            List<Despesa> despesas = repositorioDespesa.SelecionarTodos();

            listagemDespesa.AtualizarRegistros(despesas);
        }

        public override UserControl ObterListagem()
        {
            if (listagemDespesa == null)
                listagemDespesa = new ListagemDespesaControl();

            CarregarDespesas();

            return listagemDespesa;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Despesas";            
        }

        
    }
}
