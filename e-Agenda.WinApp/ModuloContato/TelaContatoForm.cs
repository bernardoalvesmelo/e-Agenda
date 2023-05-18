using System.Text.RegularExpressions;

namespace e_Agenda.WinApp.ModuloContato
{
    public partial class TelaContatoForm : Form
    {
        private Contato contato;

        public TelaContatoForm()
        {
            InitializeComponent();
            ConfigurarEventos();
        }

        public Contato Contato
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtNome.Text = value.nome;
                txtTelefone.Text = value.telefone;
                txtEmail.Text = value.email;
                txtCargo.Text = value.cargo;
                txtEmpresa.Text = value.empresa;
            }
            get
            {
                return contato;
            }
        }

        private void ConfigurarEventos()
        {
            foreach (Control control in panInputs.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.TextChanged += ValidarInputs;
                }
            }
        }

        private void ValidarInputs(object sender, EventArgs e)
        {
            List<string> erros = ObterErros();
            if (erros.Count == 0)
            {
                btnGravar.Enabled = true;
                lbErros.Text = "Sem erros";
                return;
            }
            btnGravar.Enabled = false;
            lbErros.Text = erros[0];
        }

        public List<string> ObterErros()
        {
            List<string> erros = new List<string>();
            if (txtNome.Text.Trim() == "")
            {
                erros.Add("Nome não pode ser vazio");
            }
            if (txtTelefone.Text.Trim() == "")
            {
                erros.Add("Telefone não pode ser vazio");
            }
            if (txtEmail.Text.Trim() == "")
            {
                erros.Add("Nome não pode ser vazio");
            }
            if (txtCargo.Text.Trim() == "")
            {
                erros.Add("Cargo não pode ser vazio");
            }
            if (txtEmpresa.Text.Trim() == "")
            {
                erros.Add("Empresa não pode ser vazio");
            }
            if (!Regex.IsMatch(txtTelefone.Text,
                @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$"))
            {
                erros.Add("Telefone está com formato incorreto");
            }
            if (!Regex.IsMatch(txtEmail.Text,
                "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*"))
            {
                erros.Add("Email está com formato incorreto");
            }
            return erros;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            string telefone = txtTelefone.Text;

            string email = txtEmail.Text;

            string cargo = txtCargo.Text;

            string empresa = txtEmpresa.Text;

            contato = new Contato(nome, telefone, email, cargo, empresa);

            if (txtId.Text != "0")
                contato.id = Convert.ToInt32(txtId.Text);
        }
    }
}
