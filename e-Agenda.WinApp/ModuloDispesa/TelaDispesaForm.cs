using e_Agenda.WinApp.ModuloCategoria;
using e_Agenda.WinApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
namespace e_Agenda.WinApp.ModuloDispesa
{
    public partial class TelaDispesaForm : Form
    {
        private Dispesa dispesa;
        private List<Categoria> categorias;
        public TelaDispesaForm(List<Categoria> categorias)
        {
            InitializeComponent();
            this.categorias = categorias;
            foreach (Categoria categoria in categorias)
            {
                listCategorias.Items.Add(categoria);
            }
        }

        private void AtualizarCategorias()
        {
            int i = 0;
            foreach (Categoria item in categorias)
            {
                if (dispesa.categorias.Contains(item))
                    listCategorias.SetItemChecked(i, true);
                i++;
            }
        }

        private void CarregarPagamentos()
        {
            FormasPagamento[] pagamentos = Enum.GetValues<FormasPagamento>();

            foreach (FormasPagamento pagamento in pagamentos)
            {
                cmbPagamento.Items.Add(pagamento);
            }
            cmbPagamento.SelectedIndex = 0;
        }

        public Dispesa Dispesa
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtDescricao.Text = value.descricao;
                txtValor.Text = "" + value.valor;
                txtData.Value = value.data;
                cmbPagamento.SelectedItem = value.formaPagamento;
                AtualizarCategorias();
            }
            get
            {
                return dispesa;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text;

            decimal valor = Convert.ToDecimal(txtValor.Text);

            DateTime data = txtData.Value.Date;

            FormasPagamento formasPagamento = (FormasPagamento)cmbPagamento.SelectedItem;

            List<Categoria> categorias = listCategorias
                .CheckedItems.Cast<Categoria>().ToList();

            if (txtId.Text != "0")
                dispesa.id = Convert.ToInt32(txtId.Text);

            string[] erros = dispesa.Validar();
            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
        }
    }
}
