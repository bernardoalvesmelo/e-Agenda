namespace e_Agenda.WinApp.ModuloTarefa
{

    public partial class TelaTarefaForm : Form
    {
        private Tarefa tarefa;
        public TelaTarefaForm()
        {
            InitializeComponent();
            this.cmbPrioridade.SelectedItem = "Normal";
        }
        public Tarefa Tarefa
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtTitulo.Text = value.titulo;
                cmbPrioridade.SelectedItem = value.prioridade;
                dateTimeCriacao.Value = value.dataCriacao;
                this.tarefa = new Tarefa(value.titulo, value.prioridade, value.dataCriacao);
            }
            get
            {
                return this.tarefa;
            }
        }

        public void DesabilitarDataCriacao()
        {
            dateTimeCriacao.Enabled = false;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string prioridade = (string)cmbPrioridade.SelectedItem;
            DateTime dataCriacao;
            if (dateTimeCriacao.Enabled)
            {
                dataCriacao = dateTimeCriacao.Value;
            }
            else
            {
                dataCriacao = tarefa.dataCriacao;
            }
            this.tarefa = new Tarefa(titulo, prioridade, dataCriacao);

            if (txtId.Text != "0")
                this.tarefa.id = Convert.ToInt32(txtId.Text);
        }
    }
}
