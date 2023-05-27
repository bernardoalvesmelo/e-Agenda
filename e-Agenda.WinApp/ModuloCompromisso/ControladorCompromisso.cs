using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class ControladorCompromisso : ControladorBase
    {
        private RepositorioCompromisso repositorioCompromisso;
        private RepositorioContato repositorioContato;
        private TabelaCompromissoControl tabelaCompromisso;

        public ControladorCompromisso(RepositorioCompromisso repositorioCompromisso, RepositorioContato repositorioContato)
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

                tabelaCompromisso.AtualizarRegistros(compromissos);

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
                tabelaCompromisso.AtualizarRegistros(compromissos);
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
