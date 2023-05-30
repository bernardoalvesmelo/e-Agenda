using e_Agenda.WinApp.ModuloCategoria;

namespace e_Agenda.WinApp.ModuloDespesa
{
    public class ControladorDespesa : ControladorBase
    {
        private IRepositorioDespesa repositorioDespesa;
        private IRepositorioCategoria repositorioCategoria;
        private TabelaDespesaControl tabelaDespesa;

        public ControladorDespesa(IRepositorioDespesa repositorioDespesa, IRepositorioCategoria repositorioCategoria)
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
            List<Categoria> categorias = repositorioCategoria.SelecionarTodos();

            TelaDespesaForm telaDespesa = new TelaDespesaForm(categorias);

            DialogResult opcaoEscolhida = telaDespesa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Despesa despesa = telaDespesa.Despesa;

                repositorioDespesa.Inserir(despesa);

                repositorioCategoria.AtualizarCategorias(despesa.categorias);

                CarregarDespesas();
            }
        }

        public override void Editar()
        {
            Despesa despesa = ObterDespesaSelecionada();

            if (despesa == null)
            {
                MessageBox.Show($"Selecione uma despesa primeiro!", 
                    "Edição de Despesas",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);

                return;
            }

            List<Categoria> categorias = repositorioCategoria.SelecionarTodos();

            TelaDespesaForm telaDespesa = new TelaDespesaForm(categorias);
            telaDespesa.Despesa = despesa;

            DialogResult opcaoEscolhida = telaDespesa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioDespesa.Editar(telaDespesa.Despesa);

                repositorioCategoria.AtualizarCategorias(despesa.categorias);

                CarregarDespesas();
            }
        }

        public override void Excluir()
        {            
            Despesa despesa = ObterDespesaSelecionada();

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

                repositorioCategoria.AtualizarCategorias(despesa.categorias);

                CarregarDespesas();
            }
        }

        private void CarregarDespesas()
        {
            List<Despesa> despesas = repositorioDespesa.SelecionarTodos();

            TelaPrincipalForm.Instancia.AtualizarRodape(
                $"Visualizando {despesas.Count} despesa(s)");

            tabelaDespesa.AtualizarRegistros(despesas);
        }

        public Despesa ObterDespesaSelecionada()
        {
            int id = tabelaDespesa.ObterIdSelecionado();

            return repositorioDespesa.SelecionarPorId(id);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaDespesa == null)
                tabelaDespesa = new TabelaDespesaControl();

            CarregarDespesas();

            return tabelaDespesa;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Despesas";            
        }
        
    }
}
