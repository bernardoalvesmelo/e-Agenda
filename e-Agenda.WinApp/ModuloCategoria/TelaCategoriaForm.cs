using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public partial class TelaCategoriaForm : Form
    {
        private Categoria categoria;
        public TelaCategoriaForm()
        {
            InitializeComponent();
        }

        public Categoria Categoria
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtTitulo.Text = value.titulo;
            }
            get
            {
                return categoria;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;

            categoria = new Categoria(titulo);

            if (txtId.Text != "0")
                categoria.id = Convert.ToInt32(txtId.Text);

            string[] erros = categoria.Validar();
            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
        }
    }
}
