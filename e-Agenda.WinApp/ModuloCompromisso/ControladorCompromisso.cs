using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class ControladorCompromisso : ControladorBase,  IControladorFiltrador, IControladorApresentador
    {
        private bool alternadorData = false;
        private RepositorioCompromisso repositorioCompromisso;
        private RepositorioContato repositorioContato;
        private ListagemCompromissoControl listagemCompromisso;

        public ControladorCompromisso(RepositorioCompromisso repositorioCompromisso, RepositorioContato repositorioContato)
        {
            this.repositorioCompromisso = repositorioCompromisso;
            this.repositorioContato = repositorioContato;
        }

        public override string ToolTipInserir { get { return "Inserir novo Compromisso";  } }

        public override string ToolTipEditar { get { return "Editar Compromisso existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Compromisso existente"; } }

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
            Compromisso compromisso = listagemCompromisso.ObterCompromissoSelecionado();

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
            Compromisso compromisso = listagemCompromisso.ObterCompromissoSelecionado();

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

            listagemCompromisso.AtualizarRegistros(compromissos);
        }

        public override UserControl ObterListagem()
        {
            if (listagemCompromisso == null)
                listagemCompromisso = new ListagemCompromissoControl();

            CarregarCompromissos();

            return listagemCompromisso;
        }

        public void MostrarListagemFiltrada()
        {
            if (listagemCompromisso == null)
                listagemCompromisso = new ListagemCompromissoControl();

            TelaCompromissoFiltroForm telaCompromisso = new TelaCompromissoFiltroForm();

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Predicate<Compromisso> periodo  = c => c.data > telaCompromisso.DataInicial
                && c.data <= telaCompromisso.DataFinal;

                List<Compromisso> compromissos = repositorioCompromisso.SelecionarAlternativa(periodo);

                listagemCompromisso.AtualizarRegistros(compromissos);

            }
        }

        public void MostrarListagemAlternativa()
        {
            if (listagemCompromisso == null)
                listagemCompromisso = new ListagemCompromissoControl();

            TelaCompromissoAlternativaForm telaCompromisso = new TelaCompromissoAlternativaForm();

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

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

                listagemCompromisso.AtualizarRegistros(compromissos);

            }
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Compromissos";            
        }

        
    }
}
