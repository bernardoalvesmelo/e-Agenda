using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class TelaCompromissoForm : Form
    {
        public Compromisso compromisso;

        public List<Contato> contatos;

        public TelaCompromissoForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
            configurarDateTime(dateTimeInicio);
            configurarDateTime(dateTimeTermino);
        }

        private void configurarDateTime(DateTimePicker data)
        {
            data.Format = DateTimePickerFormat.Custom;
            data.CustomFormat = "HH:mm";
            data.ShowUpDown = true;
        }
        public void ObterContatos(List<Contato> contatos)
        {
            this.contatos = contatos;
            foreach (Contato contato in contatos)
            {
                cmbContatos.Items.Add(contato.nome);
            }
        }

        public Compromisso Compromisso
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtAssunto.Text = value.assunto;
                txtLocal.Text = value.local;
                dateTimeInicio.Value = value.horaInicio;
                dateTimeTermino.Value = value.horaTermino;
                dateTimeData.Value = value.data;
                if (value.contatoCompromisso != null)
                {
                    cmbContatos.SelectedItem = value.contatoCompromisso.nome;
                }
            }
            get
            {
                return compromisso;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            string assunto = txtAssunto.Text;
            string local = txtLocal.Text;
            DateTime data = dateTimeData.Value;
            DateTime horaInicio = dateTimeInicio.Value;
            DateTime horaTermino = dateTimeTermino.Value;

            Contato contato = contatos.Find(c => c.nome == cmbContatos.SelectedItem);

            compromisso = new Compromisso(assunto, local, data, horaInicio, horaTermino, contato);

            if (txtId.Text != "0")
                compromisso.id = Convert.ToInt32(txtId.Text);

            string[] erros = compromisso.Validar();
            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
        }
    }
}
