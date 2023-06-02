using e_Agenda.Dominio.ModuloCompromisso;
using e_Agenda.Dominio.ModuloContato;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class ControladorCompromisso : ControladorBase
    {
        private IRepositorioCompromisso repositorioCompromisso;
        private IRepositorioContato repositorioContato;
        private TabelaCompromissoControl tabelaCompromisso;

        public ControladorCompromisso(IRepositorioCompromisso repositorioCompromisso, IRepositorioContato repositorioContato)
        {
            this.repositorioCompromisso = repositorioCompromisso;
            this.repositorioContato = repositorioContato;
        }

        public override string ToolTipInserir { get { return "Inserir novo Compromisso";  } }

        public override string ToolTipEditar { get { return "Editar Compromisso existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Compromisso existente"; } }

        public  override string ToolTipFiltrar { get { return "Filtrar Compromissos existentes"; } }

        public override bool InserirHabilitado { get {return true;} }

        public override bool EditarHabilitado { get { return true; } }

        public override bool ExcluirHabilitado { get { return true; } }

        public override bool FiltrarHabilitado { get { return true; } }

        public override bool ConcluirHabilitado { get { return false; } }

        public override bool AdicionarHabilitado { get { return false; } }

        public override void Inserir()
        {
            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm();

            telaCompromisso.ObterContatos(this.repositorioContato.SelecionarTodos());
            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();
            if (opcaoEscolhida == DialogResult.OK)
            {
                Compromisso compromisso = telaCompromisso.Compromisso;

                repositorioCompromisso.Inserir(compromisso);

                CarregarCompromissos();
            }
        }

        public override void Editar()
        {
            Compromisso compromisso = ObterCompromissoSelecionado();

            if (compromisso == null)
            {
                MessageBox.Show($"Selecione um compromisso primeiro!", 
                    "Edição de Compromissos",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm();
            telaCompromisso.ObterContatos(repositorioContato.SelecionarTodos());
            telaCompromisso.Compromisso = compromisso;

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCompromisso.Editar(telaCompromisso.Compromisso);

                CarregarCompromissos();
            }
        }

        public override void Excluir()
        {            
            Compromisso compromisso = ObterCompromissoSelecionado();

            if (compromisso == null)
            {
                MessageBox.Show($"Selecione um compromisso primeiro!", 
                    "Exclusão de Compromissos",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o compromisso {compromisso.assunto}?", "Exclusão de Compromissos",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCompromisso.Excluir(compromisso);

                CarregarCompromissos();
            }
        }

        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();

            TelaPrincipalForm.Instancia.AtualizarRodape(
                $"Visualizando {compromissos.Count} compromisso(s)");

            tabelaCompromisso.AtualizarRegistros(compromissos);
        }

        private void CarregarCompromissos(List<Compromisso> compromissos)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape(
                $"Visualizando {compromissos.Count} compromisso(s)");

            tabelaCompromisso.AtualizarRegistros(compromissos);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaCompromisso == null)
                tabelaCompromisso = new TabelaCompromissoControl();

            CarregarCompromissos();

            return tabelaCompromisso;
        }

        public void FiltrarPeriodo()
        {
            if (tabelaCompromisso == null)
                tabelaCompromisso = new TabelaCompromissoControl();

            TelaCompromissoFiltroForm telaCompromisso = new TelaCompromissoFiltroForm();

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Predicate<Compromisso> periodo  = c => c.data > telaCompromisso.DataInicial
                && c.data <= telaCompromisso.DataFinal;

                List<Compromisso> compromissos = repositorioCompromisso.SelecionarAlternativa(periodo);

                CarregarCompromissos(compromissos);

            }
        }

        public override void Filtrar()
        {
            if (tabelaCompromisso == null)
                tabelaCompromisso = new TabelaCompromissoControl();

            TelaCompromissoAlternativaForm telaCompromisso = new TelaCompromissoAlternativaForm();

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();
            if(opcaoEscolhida == DialogResult.Continue)
            {
                FiltrarPeriodo();
                return;
            }
            if (opcaoEscolhida == DialogResult.OK)
            {
                List<Compromisso> compromissos;

                switch (telaCompromisso.Alternativa)
                {
                    case 1:
                        compromissos = repositorioCompromisso.SelecionarAlternativa(c => c.data > DateTime.Now);
                        break;
                    case 2:
                        compromissos = repositorioCompromisso.SelecionarAlternativa(c => c.data < DateTime.Now);
                        break;
                    default:
                        compromissos = repositorioCompromisso.SelecionarTodos();
                        break;
                }
                CarregarCompromissos(compromissos);
            }
        }

        private Compromisso ObterCompromissoSelecionado()
        {
            int id = tabelaCompromisso.ObterIdSelecionado();
            return repositorioCompromisso.SelecionarPorId(id);
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Compromissos";            
        }

    }
}
