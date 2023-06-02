

using e_Agenda.Dominio.ModuloDespesa;

namespace e_Agenda.WinApp.ModuloDespesa
{
    public partial class ListagemDespesaControl : UserControl
    {
        public ListagemDespesaControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Despesa> despesas)
        {
            listDespesas.Items.Clear();

            foreach (Despesa item in despesas)
            {
                listDespesas.Items.Add(item);
            }
        }

        public Despesa ObterDespesaSelecionada()
        {
            return (Despesa)listDespesas.SelectedItem;
        }
    }
}
