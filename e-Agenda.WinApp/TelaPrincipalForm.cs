using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloCompromisso;
using e_Agenda.WinApp.ModuloTarefa;

namespace e_Agenda.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;
        private RepositorioContato repositorioContato = new RepositorioContato();
        private RepositorioCompromisso repositorioCompromisso = new RepositorioCompromisso();
        private RepositorioTarefa repositorioTarefa = new RepositorioTarefa();

        public TelaPrincipalForm()
        {
            InitializeComponent();
        }

        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorContato(repositorioContato);

            ConfigurarTelaPrincipal(controlador);
        }

        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCompromisso(repositorioCompromisso, repositorioContato);

            ConfigurarTelaPrincipal(controlador);
        }

        private void tarefasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTarefa(repositorioTarefa);

            ConfigurarTelaPrincipal(controlador);
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            labelTipoCadastro.Text = controladorBase.ObterTipoCadastro();

            ConfigurarToolBotoes(controlador);

            ConfigurarToolTips(controlador);

            ConfigurarListagem(controlador);
        }

        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            UserControl listagem = controladorBase.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(listagem);
        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
            btnFiltrar.ToolTipText = controlador.ToolTipFiltrar;
            btnAdicionar.ToolTipText = controlador.ToolTipAdicionar;
            btnConcluir.ToolTipText = controlador.ToolTipConcluir;
        }

        private void ConfigurarToolBotoes(ControladorBase controlador)
        {
            btnInserir.Enabled = controlador.InserirAbilitado;
            btnEditar.Enabled = controlador.EditarAbilitado;
            btnExcluir.Enabled = controlador.ExcluirAbilitado;
            btnFiltrar.Enabled = controlador.FiltrarAbilitado;
            btnAdicionar.Enabled = controlador.AdicionarAbilitado;
            btnConcluir.Enabled = controlador.ConcluirAbilitado;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            controlador.Filtrar();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controlador.AdicionarItem();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            controlador.Concluir();
        }
    }
}