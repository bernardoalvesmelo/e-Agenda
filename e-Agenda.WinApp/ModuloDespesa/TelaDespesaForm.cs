using e_Agenda.WinApp.ModuloCategoria;
using System.Data;
namespace e_Agenda.WinApp.ModuloDespesa
{
    public partial class TelaDespesaForm : Form
    {
        private Despesa despesa;
        private List<Categoria> categorias;
        public TelaDespesaForm(List<Categoria> categorias)
        {
            InitializeComponent();
            this.categorias = categorias;
            foreach (Categoria categoria in categorias)
            {
                listCategorias.Items.Add(categoria);
            }
            CarregarPagamentos();
        }

        private void AtualizarCategorias()
        {
            int i = 0;
            foreach (Categoria item in categorias)
            {
                if (despesa.categorias.Contains(item))
                    listCategorias.SetItemChecked(i, true);
                i++;
            }
        }

        private void CarregarPagamentos()
        {
            FormasPagamentoEnum[] pagamentos = Enum.GetValues<FormasPagamentoEnum>();

            foreach (FormasPagamentoEnum pagamento in pagamentos)
            {
                cmbPagamento.Items.Add(pagamento);
            }
            cmbPagamento.SelectedIndex = 0;
        }

        public Despesa Despesa
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtDescricao.Text = value.descricao;
                txtValor.Text = "" + value.valor;
                txtData.Value = value.data;
                cmbPagamento.SelectedItem = value.formaPagamento;
                despesa = value;
                AtualizarCategorias();
            }
            get
            {
                return despesa;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text;

            decimal valor = Convert.ToDecimal(txtValor.Text);

            DateTime data = txtData.Value.Date;

            FormasPagamentoEnum formaPagamento = (FormasPagamentoEnum)cmbPagamento.SelectedItem;

            List<Categoria> categorias = listCategorias
                .CheckedItems.Cast<Categoria>().ToList();

            despesa = new Despesa(descricao, valor, data, formaPagamento);
            despesa.categorias = categorias;

            if (txtId.Text != "0")
                despesa.id = Convert.ToInt32(txtId.Text);

            string[] erros = despesa.Validar();
            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
        }
    }
}
